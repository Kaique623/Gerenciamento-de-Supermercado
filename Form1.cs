
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;

namespace Gerenciamento_de_Supermercado
{

    public partial class Form1 : Form
    {  
        string telaAtual = "🛒 Compras";
        Dictionary<string, Dictionary<string, string>> EstoqueData = new Dictionary<string, Dictionary<string, string>>();

        string JsonFileData = "";
        int productQuant = 0;
        int totalQuant = 0;

        public Form1()
        {
            InitializeComponent();
            compra_label_returnDayBuy.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now); 
        }

        void updateTime()
        {
            compra_returnTimeBuy.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
            Task.Delay(20000).ContinueWith(t => updateTime());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            updateTime();
            splitContainer1.IsSplitterFixed = true;
            if (!File.Exists("EstoqueData.json"))
                File.Create("EstoqueData.json").Dispose();
            var text = File.ReadAllText("EstoqueData.json");
            EstoqueData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(text);

            try {
                compra_comboBox.DataSource = new BindingSource(EstoqueData.Keys, null);
            }
            catch {
                Console.WriteLine("Nada a carregar");
            }
        }

        private void reloadEstoque()
        {
            try
            {
                EstoqueDataGrid.Rows.Clear();
                foreach (string data in EstoqueData.Keys)
                {
                    EstoqueDataGrid.Rows.Add();
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[0].Value = data;
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[1].Value = EstoqueData[data]["Nome"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[2].Value = EstoqueData[data]["Categoria"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[3].Value = EstoqueData[data]["Setor"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[4].Value = EstoqueData[data]["Quant"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[5].Value = EstoqueData[data]["Preco"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[6].Value = EstoqueData[data]["Desc"];
                }
            }

            catch
            {
                Console.WriteLine("ERROR WHILE READING FILE");
            }
        }

        private void dashboardButton_click(object sender, EventArgs e)
        {
            telaAtual = (sender as Button).Text;
            if (telaAtual == "🛒 Compras")
                tabControl1.SelectedIndex = 0;
            else if (telaAtual == "📖 Histórico ")
                tabControl1.SelectedIndex = 1;
            else if (telaAtual == "📦 Estoque")
            {
                tabControl1.SelectedIndex = 2;
                reloadEstoque();
            }
            else if (telaAtual == "Alertas")
                tabControl1.SelectedIndex = 3;
            else if (telaAtual == "🚪 Sair")
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EstoqueTextbox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (compra_comboBox.Text == "" || compra_comboBox.Text == "(Coleção)")
            {
                MessageBox.Show("Digite um ID");
            }

            else
            {
                bool addCompra = false;
                foreach (DataGridViewRow row in compra_dataView.Rows)
                {
                    if (compra_comboBox.Text == (string)row.Cells[0].Value)
                    {
                        addCompra = true;
                        
                    }
                }

                if (addCompra && Convert.ToInt16(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value) < Convert.ToInt16(EstoqueData[compra_comboBox.Text]["Quant"])) {
                    totalQuant += 1;
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value = Convert.ToString(Convert.ToInt16(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value) + 1);
                }
                    
                else if (addCompra)
                    MessageBox.Show("Quantidade Indisponível no estoque!");

                else
                {
                    productQuant += 1;
                    totalQuant += 1;
                    compra_dataView.Rows.Add();
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[0].Value = compra_comboBox.Text;
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[1].Value = EstoqueData[compra_comboBox.Text]["Nome"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[2].Value = EstoqueData[compra_comboBox.Text]["Categoria"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[3].Value = EstoqueData[compra_comboBox.Text]["Setor"];

                    if (Convert.ToInt16(EstoqueData[compra_comboBox.Text]["Quant"]) > 0)
                    {
                        compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value = "1";
                    }
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[5].Value = EstoqueData[compra_comboBox.Text]["Preco"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[6].Value = EstoqueData[compra_comboBox.Text]["Desc"];
                    compra_comboBox.Text = "";
                }
            }
            updateTelaDeCompra();
        }
        double CalcularValorFinal()
        {
            double total = 0;
            foreach (DataGridViewRow row in compra_dataView.Rows)
            {
                    if (double.TryParse(row.Cells[5].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double valor) &&
                        int.TryParse(row.Cells[4].Value.ToString(), out int quantidade))
                    {
                        total += valor * quantidade;
                    }
            }
            return total;
        }

        void updateTelaDeCompra()
        {
            compra_label_returnFinalPrice.Text = $"R$: {CalcularValorFinal():F2}";
            compra_label_returnQuantTotal.Text = totalQuant.ToString();
            compra_label_returnQuantPreduct.Text = productQuant.ToString();
        }

        private void EstoqueButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                if (e.ColumnIndex == 7){
                    EstoqueDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception){
                Console.WriteLine("Unable to delete row");
            }
        }
        private void EstoqueAddButon(object sender, EventArgs e)
        {
            EstoqueDataGrid.Rows.Add();
        }

        private void compra_dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    totalQuant -= Convert.ToInt16(compra_dataView.Rows[e.RowIndex].Cells[4].Value);
                    productQuant -= 1;
                    compra_dataView.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == 7)
                {
                    int rowValue = Convert.ToInt16(compra_dataView.Rows[e.RowIndex].Cells[4].Value.ToString());
                    if (rowValue == 1)
                    {
                        compra_dataView.Rows.RemoveAt(e.RowIndex);
                        totalQuant -= 1;
                        productQuant -= 1;
                    }
                    else if (rowValue > 1)
                    {
                        rowValue--;
                        compra_dataView.Rows[e.RowIndex].Cells[4].Value = rowValue.ToString();
                        totalQuant -= 1;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Deu ruim");
            }
            updateTelaDeCompra();
        }
        private void EstoqueSaveButtonFunc(object sender, EventArgs e)
        {
            EstoqueData = new Dictionary<string, Dictionary<string, string>>();
            foreach (DataGridViewRow row in EstoqueDataGrid.Rows)
            {
                MessageBox.Show((string)row.Cells[0].Value);
                string aux = (string)row.Cells[5].Value;
                row.Cells[5].Value = aux.Replace(",", ".");
                EstoqueData.Add((string)row.Cells[0].Value, new Dictionary<string, string>()
                {
                    {"Nome", (string)row.Cells[1].Value},
                    {"Categoria", (string)row.Cells[2].Value},
                    {"Setor", (string)row.Cells[3].Value},
                    {"Quant", (string)row.Cells[4].Value},
                    {"Preco", (string)row.Cells[5].Value},
                    {"Desc", (string)row.Cells[6].Value},
                });
            }
            compra_comboBox.DataSource = new BindingSource(EstoqueData, null);
            compra_comboBox.DisplayMember = "Key";

            JsonFileData = JsonConvert.SerializeObject(EstoqueData);

            using (StreamWriter file = new StreamWriter("EstoqueData.json"))
                file.WriteLine(JsonFileData);
        }
        private void compra_button_endbuy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in compra_dataView.Rows)
            {
                int temp_quant = int.TryParse(row.Cells[4].Value?.ToString(), out int result) ? result : 0;
                MessageBox.Show(temp_quant.ToString());
                string temp_id = (string)row.Cells[0].Value; MessageBox.Show(temp_id);
                EstoqueData[temp_id]["Quant"] = (Convert.ToInt16(EstoqueData[temp_id]["Quant"]) - temp_quant).ToString();
            }
            compra_dataView.Rows.Clear();
        }
    }
}