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

            tabPage2.Width = 0;
        }

        private void dashboardButton_click(object sender, EventArgs e)
        {
            telaAtual = (sender as Button).Text;
            MessageBox.Show(telaAtual);
            if (telaAtual == "🚪 Sair")
                this.Close();
            tabControl1.SelectedIndex = 1;
        }

    }
}
