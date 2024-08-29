
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
        bool stateCompraRadioButton = false;

        Dictionary<string, Dictionary<string, string>> EstoqueData = new Dictionary<string, Dictionary<string, string>>();

        Dictionary<string, System.Windows.Forms.Panel> cloneRowsPanel = new Dictionary<string, System.Windows.Forms.Panel>();
        Dictionary<string, Dictionary<string, System.Windows.Forms.Label>> cloneRowsLabel = new Dictionary<string, Dictionary<string, Label>>();

        List<string> Alertas = new List<string>();

        string JsonFileData = "";
        int productQuant = 0;
        int totalQuant = 0;

        int AlertaRowCounter = 0;

        public Form1()
        {
            InitializeComponent();
            compra_label_returnDayBuy.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now); 
        }

        void createRow(string id)
        {

            cloneRowsPanel[id] = new Panel();
            AlertaPanel1.Controls.Add(cloneRowsPanel[id]);
            cloneRowsPanel[id].BackColor = System.Drawing.Color.WhiteSmoke;
            cloneRowsPanel[id].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            cloneRowsPanel[id].Location = new System.Drawing.Point(3, 0 + (51 * AlertaRowCounter));
            cloneRowsPanel[id].Name = "TemplatePanel";
            cloneRowsPanel[id].Size = new System.Drawing.Size(1140, 53);


            int tempCounter = 0;
            foreach (KeyValuePair<string, string> value in new Dictionary<string, string> {
            { "ID: ", "Id" },
            { "Nome do Produto: ", "Nome" },
            { "Categoria: ", "Categoria"},
            { "Setor:",  "Setor"},
            { "Preço", "Preco"},
            { "Quantidade Disponível", "Quant" },
            { "Alerta (Máximo)", "AlertaMax" },
            { "Alerta (Mínimo)", "AlertaMin" }
            })
            {
                cloneRowsLabel[id] = new Dictionary<string, Label>();
                cloneRowsLabel[id][value.Key] = new Label();
                cloneRowsPanel[id].Controls.Add(cloneRowsLabel[id][value.Key]);
                cloneRowsLabel[id][value.Key].AutoSize = true;
                cloneRowsLabel[id][value.Key].Location = new System.Drawing.Point(4 + (150 * tempCounter), 4);
                cloneRowsLabel[id][value.Key].Size = new System.Drawing.Size(80, 13);
                cloneRowsLabel[id][value.Key].TabIndex = 0;
                if (tempCounter == 0)
                    cloneRowsLabel[id][value.Key].Text = $"{value.Key}\n{id}";
                else
                    cloneRowsLabel[id][value.Key].Text = $"{value.Key}\n{EstoqueData[id][value.Value]}";
                tempCounter++;
                Alertas.Add(id);
            }

        }
        private void AlertaPanel1_Paint(object sender, PaintEventArgs e)
        {
            AlertaPanel1.AutoScroll = true;
            AlertaPanel1.HorizontalScroll.Maximum = 0;
        }

        void refreshAlerta()
        {
            try
            {
                foreach (string id in EstoqueData.Keys)
                {
                    if (Convert.ToInt16(EstoqueData[id]["Quant"]) <= Convert.ToInt16(EstoqueData[id]["AlertaMin"]) && !Alertas.Contains(id))
                    {
                        createRow(id);
                        AlertaRowCounter += 1;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Erro ao Criar Fileira");
            }
            label_alerta.Text = Convert.ToString(AlertaRowCounter);
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
            refreshAlerta();
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
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[7].Value = EstoqueData[data]["AlertaMin"];
                    EstoqueDataGrid.Rows[EstoqueDataGrid.Rows.Count - 1].Cells[8].Value = EstoqueData[data]["AlertaMax"];
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
            {
                refreshAlerta();
                tabControl1.SelectedIndex = 3;
            }
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
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value 
                        = Convert.ToString(Convert.ToInt16(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value) + 1);
                    if (decimal.TryParse(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[5].Value.ToString(), out decimal valor1) &&
                        int.TryParse(compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value.ToString(), out int valor2))
                    {
                        decimal resultado = valor1 * valor2;
                        compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[6].Value = $"{resultado:F2}";
                    }
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
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[6].Value = EstoqueData[compra_comboBox.Text]["Preco"];
                    compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[7].Value = EstoqueData[compra_comboBox.Text]["Desc"];
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
                if (double.TryParse(row.Cells[5].Value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double valor) 
                    && int.TryParse(row.Cells[4].Value.ToString(), out int quantidade))
                {
                    total += valor * quantidade;
                }
            }

            if (compra_radio_cre.Checked)
            {
                total += (total * 0.02);
            }
            else if (compra_radio_deb.Checked)
            {
                total += (total * 0.01);
            }
            else if (compra_radio_din.Checked)
            {

            }
            else if (compra_radio_pix.Checked)
            {
                
            }
            return total;
        }

        private void updateTelaDeCompra()
        {
            compra_label_returnFinalPrice.Text = $"R$: {CalcularValorFinal():F2}";
            compra_label_returnQuantTotal.Text = totalQuant.ToString();
            compra_label_returnQuantPreduct.Text = productQuant.ToString();
        }

        private void EstoqueButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                if (e.ColumnIndex == 9){
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
                if (e.ColumnIndex == 9)
                {
                    totalQuant -= Convert.ToInt16(compra_dataView.Rows[e.RowIndex].Cells[4].Value);
                    productQuant -= 1;
                    compra_dataView.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == 8)
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
                        compra_dataView.Rows[e.RowIndex].Cells[6].Value =
                        Convert.ToDecimal(compra_dataView.Rows[e.RowIndex].Cells[6].Value) -
                        Convert.ToDecimal(compra_dataView.Rows[e.RowIndex].Cells[5].Value);
                        
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
                    {"AlertaMin", (string)row.Cells[7].Value },
                    {"AlertaMax", (string)row.Cells[8].Value }
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
            if (stateCompraRadioButton == false)
            {
                MessageBox.Show("Selecione uma forma de Pagamento", "Erro de Seleção");
            }
            else
            {
                foreach (DataGridViewRow row in compra_dataView.Rows)
                {
                    int temp_quant = int.TryParse(row.Cells[4].Value?.ToString(), out int result) ? result : 0;
                    string temp_id = (string)row.Cells[0].Value; MessageBox.Show(temp_id);
                    EstoqueData[temp_id]["Quant"] = (Convert.ToInt16(EstoqueData[temp_id]["Quant"]) - temp_quant).ToString();
                }           
                compra_dataView.Rows.Clear();
                compra_label_returnFinalPrice.Text = $"R$: {0:F2}";
            }
        }

        private void compra_radio_pix_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_click(sender, e);
            stateCompraRadioButton = true;
        }

        private void compra_radio_din_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_click(sender, e);
            stateCompraRadioButton = true;
        }

        private void compra_radio_deb_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_click(sender, e);
            stateCompraRadioButton = true;
        }

        private void compra_radio_cre_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_click(sender, e);
            stateCompraRadioButton = true;
        }

        private void radioButton_click(object sender, EventArgs e)
        {
            if ((sender as RadioButton)?.Checked == true)
            {
                updateTelaDeCompra();
            }
        }

        private void RenerateBuyRegister()
        {
            foreach (DataGridViewRow row in compra_dataView.Rows)
            {
                string id = Convert.ToString(row.Cells[0].Value);
                string name = Convert.ToString(row.Cells[1].Value);
                string quant = Convert.ToString(row.Cells[2].Value);
                // string id = Convert.ToString(row.Cells[3].Value);
                // string id = Convert.ToString(row.Cells[4].Value);
            }
        }
    }
}