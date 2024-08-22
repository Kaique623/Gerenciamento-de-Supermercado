using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Supermercado
{

    public partial class Form1 : Form
    {
        string telaAtual = "🛒 Compras";

        Dictionary<string, Dictionary<string, string>> EstoqueData = new Dictionary<string, Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            splitContainer1.IsSplitterFixed = true;
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_click(object sender, EventArgs e)
        {
            telaAtual = (sender as Button).Text;
            if (telaAtual == "🛒 Compras")
                tabControl1.SelectedIndex = 0;
            else if (telaAtual == "📖 Histórico ")
                tabControl1.SelectedIndex = 1;
            else if (telaAtual == "📦 Estoque")
                tabControl1.SelectedIndex = 2;
            else if (telaAtual == "Alertas")
                tabControl1.SelectedIndex = 3;
            else if (telaAtual == "🚪 Sair")
                this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EstoqueTextbox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (compra_comboBox.Text == "")
            {
                MessageBox.Show("Digite um ID");
            }
            else
            {
                compra_dataView.Rows.Add();
                compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[4].Value = "1";
                compra_dataView.Rows[compra_dataView.Rows.Count - 1].Cells[0].Value = compra_comboBox.Text;
                compra_comboBox.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EstoqueButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    EstoqueDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception)
            {
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
                    compra_dataView.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == 7)
                {
                    int rowValue = Convert.ToInt16(compra_dataView.Rows[e.RowIndex].Cells[4].Value.ToString());
                    if (rowValue == 1)
                    {
                        compra_dataView.Rows.RemoveAt(e.RowIndex);
                    }
                    else if (rowValue > 1)
                    {
                        rowValue--;
                        compra_dataView.Rows[e.RowIndex].Cells[4].Value = rowValue.ToString();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Deu ruim");
            }
        }
        private void EstoqueSaveButtonFunc(object sender, EventArgs e)
        {
            EstoqueData = new Dictionary<string, Dictionary<string, string>>();
            foreach (DataGridViewRow row in EstoqueDataGrid.Rows)
            {
                MessageBox.Show((string)row.Cells[0].Value);
                EstoqueData.Add((string)row.Cells[0].Value, new Dictionary<string, string>()
                {
                    {"Nome", (string)row.Cells[1].Value},
                    {"Tipo", (string)row.Cells[2].Value},
                    {"Setor", (string)row.Cells[3].Value},
                    {"Quant", (string)row.Cells[4].Value},
                    {"Preco", (string)row.Cells[5].Value},
                    {"Desc", (string)row.Cells[6].Value},
                });
            }
            foreach (var id in EstoqueData.Keys)
                foreach (var value in EstoqueData[id].Keys)
                    MessageBox.Show(EstoqueData[id][value], "ID: " + id + " | " + value);
        }
    }
}
