namespace Gerenciamento_de_Supermercado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_alerta = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.compra_comboBox = new System.Windows.Forms.ComboBox();
            this.compra_label_returnFinalPrice = new System.Windows.Forms.Label();
            this.compra_label_finalPrice = new System.Windows.Forms.Label();
            this.compra_groupBox = new System.Windows.Forms.GroupBox();
            this.compra_returnTimeBuy = new System.Windows.Forms.Label();
            this.compra_label_timeBuy = new System.Windows.Forms.Label();
            this.compra_label_returnDayBuy = new System.Windows.Forms.Label();
            this.compra_label_dayBuy = new System.Windows.Forms.Label();
            this.compra_label_returnQuantPreduct = new System.Windows.Forms.Label();
            this.compra_label_quantProduct = new System.Windows.Forms.Label();
            this.compra_label_returnQuantTotal = new System.Windows.Forms.Label();
            this.compra_label_quantTotal = new System.Windows.Forms.Label();
            this.compra_button_endbuy = new System.Windows.Forms.Button();
            this.compra_button_cancelbuy = new System.Windows.Forms.Button();
            this.compra_label_idDesc = new System.Windows.Forms.Label();
            this.compra_dataView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minusButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.compra_button_additem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CompraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCompraHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisualizarInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EstoqueSaveButton = new System.Windows.Forms.Button();
            this.EstoqueAddButton = new System.Windows.Forms.Button();
            this.EstoqueDataGrid = new System.Windows.Forms.DataGridView();
            this.EstoqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoquePrecoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueRemoveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EstoqueTextbox = new System.Windows.Forms.TextBox();
            this.EstoqueSearchButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.compra_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compra_dataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.Controls.Add(this.label_alerta);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Panel2MinSize = 420;
            this.splitContainer1.Size = new System.Drawing.Size(1315, 728);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_alerta
            // 
            this.label_alerta.AutoSize = true;
            this.label_alerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_alerta.ForeColor = System.Drawing.Color.Yellow;
            this.label_alerta.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label_alerta.Location = new System.Drawing.Point(77, 232);
            this.label_alerta.Name = "label_alerta";
            this.label_alerta.Size = new System.Drawing.Size(13, 13);
            this.label_alerta.TabIndex = 8;
            this.label_alerta.Text = "0";
            this.label_alerta.Visible = false;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button5.Location = new System.Drawing.Point(6, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "Alertas";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.dashboardButton_click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button6.Location = new System.Drawing.Point(6, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "🚪 Sair";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.dashboardButton_click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button4.Location = new System.Drawing.Point(6, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "📦 Estoque";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.dashboardButton_click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button3.Location = new System.Drawing.Point(6, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "📖 Histórico ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.dashboardButton_click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button2.Location = new System.Drawing.Point(6, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "🛒 Compras";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.dashboardButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.dashboardButton_click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.compra_comboBox);
            this.tabPage1.Controls.Add(this.compra_label_returnFinalPrice);
            this.tabPage1.Controls.Add(this.compra_label_finalPrice);
            this.tabPage1.Controls.Add(this.compra_groupBox);
            this.tabPage1.Controls.Add(this.compra_button_endbuy);
            this.tabPage1.Controls.Add(this.compra_button_cancelbuy);
            this.tabPage1.Controls.Add(this.compra_label_idDesc);
            this.tabPage1.Controls.Add(this.compra_dataView);
            this.tabPage1.Controls.Add(this.compra_button_additem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1170, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // compra_comboBox
            // 
            this.compra_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.compra_comboBox.FormattingEnabled = true;
            this.compra_comboBox.Items.AddRange(new object[] {
            ""});
            this.compra_comboBox.Location = new System.Drawing.Point(19, 68);
            this.compra_comboBox.Name = "compra_comboBox";
            this.compra_comboBox.Size = new System.Drawing.Size(278, 32);
            this.compra_comboBox.TabIndex = 17;
            // 
            // compra_label_returnFinalPrice
            // 
            this.compra_label_returnFinalPrice.AutoSize = true;
            this.compra_label_returnFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.compra_label_returnFinalPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_returnFinalPrice.Location = new System.Drawing.Point(159, 589);
            this.compra_label_returnFinalPrice.Name = "compra_label_returnFinalPrice";
            this.compra_label_returnFinalPrice.Size = new System.Drawing.Size(107, 25);
            this.compra_label_returnFinalPrice.TabIndex = 16;
            this.compra_label_returnFinalPrice.Text = "R$: 000.00";
            // 
            // compra_label_finalPrice
            // 
            this.compra_label_finalPrice.AutoSize = true;
            this.compra_label_finalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.compra_label_finalPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_finalPrice.Location = new System.Drawing.Point(14, 589);
            this.compra_label_finalPrice.Name = "compra_label_finalPrice";
            this.compra_label_finalPrice.Size = new System.Drawing.Size(128, 26);
            this.compra_label_finalPrice.TabIndex = 15;
            this.compra_label_finalPrice.Text = "Preço Final:";
            // 
            // compra_groupBox
            // 
            this.compra_groupBox.Controls.Add(this.compra_returnTimeBuy);
            this.compra_groupBox.Controls.Add(this.compra_label_timeBuy);
            this.compra_groupBox.Controls.Add(this.compra_label_returnDayBuy);
            this.compra_groupBox.Controls.Add(this.compra_label_dayBuy);
            this.compra_groupBox.Controls.Add(this.compra_label_returnQuantPreduct);
            this.compra_groupBox.Controls.Add(this.compra_label_quantProduct);
            this.compra_groupBox.Controls.Add(this.compra_label_returnQuantTotal);
            this.compra_groupBox.Controls.Add(this.compra_label_quantTotal);
            this.compra_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.compra_groupBox.Location = new System.Drawing.Point(694, 589);
            this.compra_groupBox.Name = "compra_groupBox";
            this.compra_groupBox.Size = new System.Drawing.Size(414, 93);
            this.compra_groupBox.TabIndex = 14;
            this.compra_groupBox.TabStop = false;
            this.compra_groupBox.Text = "Informações";
            // 
            // compra_returnTimeBuy
            // 
            this.compra_returnTimeBuy.AutoSize = true;
            this.compra_returnTimeBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_returnTimeBuy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_returnTimeBuy.Location = new System.Drawing.Point(365, 66);
            this.compra_returnTimeBuy.Name = "compra_returnTimeBuy";
            this.compra_returnTimeBuy.Size = new System.Drawing.Size(45, 20);
            this.compra_returnTimeBuy.TabIndex = 7;
            this.compra_returnTimeBuy.Text = "0000";
            // 
            // compra_label_timeBuy
            // 
            this.compra_label_timeBuy.AutoSize = true;
            this.compra_label_timeBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_timeBuy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_timeBuy.Location = new System.Drawing.Point(217, 66);
            this.compra_label_timeBuy.Name = "compra_label_timeBuy";
            this.compra_label_timeBuy.Size = new System.Drawing.Size(143, 20);
            this.compra_label_timeBuy.TabIndex = 6;
            this.compra_label_timeBuy.Text = "Horário da Compra";
            // 
            // compra_label_returnDayBuy
            // 
            this.compra_label_returnDayBuy.AutoSize = true;
            this.compra_label_returnDayBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_returnDayBuy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_returnDayBuy.Location = new System.Drawing.Point(363, 32);
            this.compra_label_returnDayBuy.Name = "compra_label_returnDayBuy";
            this.compra_label_returnDayBuy.Size = new System.Drawing.Size(45, 20);
            this.compra_label_returnDayBuy.TabIndex = 5;
            this.compra_label_returnDayBuy.Text = "0000";
            // 
            // compra_label_dayBuy
            // 
            this.compra_label_dayBuy.AutoSize = true;
            this.compra_label_dayBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_dayBuy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_dayBuy.Location = new System.Drawing.Point(217, 32);
            this.compra_label_dayBuy.Name = "compra_label_dayBuy";
            this.compra_label_dayBuy.Size = new System.Drawing.Size(119, 20);
            this.compra_label_dayBuy.TabIndex = 4;
            this.compra_label_dayBuy.Text = "Dia da Compra:";
            // 
            // compra_label_returnQuantPreduct
            // 
            this.compra_label_returnQuantPreduct.AutoSize = true;
            this.compra_label_returnQuantPreduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_returnQuantPreduct.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_returnQuantPreduct.Location = new System.Drawing.Point(166, 66);
            this.compra_label_returnQuantPreduct.Name = "compra_label_returnQuantPreduct";
            this.compra_label_returnQuantPreduct.Size = new System.Drawing.Size(45, 20);
            this.compra_label_returnQuantPreduct.TabIndex = 3;
            this.compra_label_returnQuantPreduct.Text = "0000";
            // 
            // compra_label_quantProduct
            // 
            this.compra_label_quantProduct.AutoSize = true;
            this.compra_label_quantProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_quantProduct.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_quantProduct.Location = new System.Drawing.Point(9, 66);
            this.compra_label_quantProduct.Name = "compra_label_quantProduct";
            this.compra_label_quantProduct.Size = new System.Drawing.Size(151, 20);
            this.compra_label_quantProduct.TabIndex = 2;
            this.compra_label_quantProduct.Text = "Quant. de Produtos:";
            // 
            // compra_label_returnQuantTotal
            // 
            this.compra_label_returnQuantTotal.AutoSize = true;
            this.compra_label_returnQuantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_returnQuantTotal.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_returnQuantTotal.Location = new System.Drawing.Point(166, 32);
            this.compra_label_returnQuantTotal.Name = "compra_label_returnQuantTotal";
            this.compra_label_returnQuantTotal.Size = new System.Drawing.Size(45, 20);
            this.compra_label_returnQuantTotal.TabIndex = 1;
            this.compra_label_returnQuantTotal.Text = "0000";
            // 
            // compra_label_quantTotal
            // 
            this.compra_label_quantTotal.AutoSize = true;
            this.compra_label_quantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_quantTotal.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_quantTotal.Location = new System.Drawing.Point(9, 32);
            this.compra_label_quantTotal.Name = "compra_label_quantTotal";
            this.compra_label_quantTotal.Size = new System.Drawing.Size(135, 20);
            this.compra_label_quantTotal.TabIndex = 0;
            this.compra_label_quantTotal.Text = "Quantidade Total:";
            // 
            // compra_button_endbuy
            // 
            this.compra_button_endbuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compra_button_endbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compra_button_endbuy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_button_endbuy.Location = new System.Drawing.Point(19, 640);
            this.compra_button_endbuy.Name = "compra_button_endbuy";
            this.compra_button_endbuy.Size = new System.Drawing.Size(247, 42);
            this.compra_button_endbuy.TabIndex = 13;
            this.compra_button_endbuy.Text = "Finalizar Compra";
            this.compra_button_endbuy.UseVisualStyleBackColor = true;
            // 
            // compra_button_cancelbuy
            // 
            this.compra_button_cancelbuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compra_button_cancelbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compra_button_cancelbuy.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_button_cancelbuy.Location = new System.Drawing.Point(933, 68);
            this.compra_button_cancelbuy.Name = "compra_button_cancelbuy";
            this.compra_button_cancelbuy.Size = new System.Drawing.Size(175, 33);
            this.compra_button_cancelbuy.TabIndex = 12;
            this.compra_button_cancelbuy.Text = "Calcelar Compra";
            this.compra_button_cancelbuy.UseVisualStyleBackColor = true;
            // 
            // compra_label_idDesc
            // 
            this.compra_label_idDesc.AutoSize = true;
            this.compra_label_idDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compra_label_idDesc.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_label_idDesc.Location = new System.Drawing.Point(15, 31);
            this.compra_label_idDesc.Name = "compra_label_idDesc";
            this.compra_label_idDesc.Size = new System.Drawing.Size(271, 20);
            this.compra_label_idDesc.TabIndex = 7;
            this.compra_label_idDesc.Text = "Digite o ID ou Nome do produto aqui:";
            // 
            // compra_dataView
            // 
            this.compra_dataView.AllowUserToAddRows = false;
            this.compra_dataView.AllowUserToDeleteRows = false;
            this.compra_dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compra_dataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.compra_dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.compra_dataView.ColumnHeadersHeight = 20;
            this.compra_dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Categoria,
            this.Setor,
            this.Quantidade,
            this.PrecoUni,
            this.Desc,
            this.minusButton,
            this.removeButton});
            this.compra_dataView.Location = new System.Drawing.Point(19, 130);
            this.compra_dataView.Name = "compra_dataView";
            this.compra_dataView.ReadOnly = true;
            this.compra_dataView.Size = new System.Drawing.Size(1089, 453);
            this.compra_dataView.TabIndex = 3;
            this.compra_dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compra_dataView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Setor
            // 
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            this.Setor.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PrecoUni
            // 
            this.PrecoUni.HeaderText = "Preço Uni.";
            this.PrecoUni.Name = "PrecoUni";
            this.PrecoUni.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descrição";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // minusButton
            // 
            this.minusButton.HeaderText = "";
            this.minusButton.Name = "minusButton";
            this.minusButton.ReadOnly = true;
            this.minusButton.Text = "-1";
            this.minusButton.UseColumnTextForButtonValue = true;
            // 
            // removeButton
            // 
            this.removeButton.HeaderText = "";
            this.removeButton.Name = "removeButton";
            this.removeButton.ReadOnly = true;
            this.removeButton.Text = "Remover";
            this.removeButton.UseColumnTextForButtonValue = true;
            // 
            // compra_button_additem
            // 
            this.compra_button_additem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compra_button_additem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compra_button_additem.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.compra_button_additem.Location = new System.Drawing.Point(324, 69);
            this.compra_button_additem.Name = "compra_button_additem";
            this.compra_button_additem.Size = new System.Drawing.Size(176, 32);
            this.compra_button_additem.TabIndex = 2;
            this.compra_button_additem.Text = "Adicionar";
            this.compra_button_additem.UseVisualStyleBackColor = true;
            this.compra_button_additem.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1176, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompraID,
            this.DataCompra,
            this.HorarioCompra,
            this.PrecoCompraHist,
            this.VisualizarInfo});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1161, 696);
            this.dataGridView1.TabIndex = 0;
            // 
            // CompraID
            // 
            this.CompraID.HeaderText = "ID de Compra";
            this.CompraID.Name = "CompraID";
            // 
            // DataCompra
            // 
            this.DataCompra.HeaderText = "Data da Compra";
            this.DataCompra.Name = "DataCompra";
            // 
            // HorarioCompra
            // 
            this.HorarioCompra.HeaderText = "Horário da Compra";
            this.HorarioCompra.Name = "HorarioCompra";
            // 
            // PrecoCompraHist
            // 
            this.PrecoCompraHist.HeaderText = "Preço da Compra";
            this.PrecoCompraHist.Name = "PrecoCompraHist";
            // 
            // VisualizarInfo
            // 
            this.VisualizarInfo.HeaderText = "Visualizar Informações";
            this.VisualizarInfo.Name = "VisualizarInfo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EstoqueSaveButton);
            this.tabPage3.Controls.Add(this.EstoqueAddButton);
            this.tabPage3.Controls.Add(this.EstoqueDataGrid);
            this.tabPage3.Controls.Add(this.EstoqueTextbox);
            this.tabPage3.Controls.Add(this.EstoqueSearchButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1176, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estoque";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EstoqueSaveButton
            // 
            this.EstoqueSaveButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EstoqueSaveButton.Location = new System.Drawing.Point(628, 21);
            this.EstoqueSaveButton.Name = "EstoqueSaveButton";
            this.EstoqueSaveButton.Size = new System.Drawing.Size(116, 30);
            this.EstoqueSaveButton.TabIndex = 11;
            this.EstoqueSaveButton.Text = "Salvar";
            this.EstoqueSaveButton.UseVisualStyleBackColor = true;
            this.EstoqueSaveButton.Click += new System.EventHandler(this.EstoqueSaveButtonFunc);
            // 
            // EstoqueAddButton
            // 
            this.EstoqueAddButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EstoqueAddButton.Location = new System.Drawing.Point(750, 22);
            this.EstoqueAddButton.Name = "EstoqueAddButton";
            this.EstoqueAddButton.Size = new System.Drawing.Size(116, 29);
            this.EstoqueAddButton.TabIndex = 10;
            this.EstoqueAddButton.Text = "Adicionar";
            this.EstoqueAddButton.UseVisualStyleBackColor = true;
            this.EstoqueAddButton.Click += new System.EventHandler(this.EstoqueAddButon);
            // 
            // EstoqueDataGrid
            // 
            this.EstoqueDataGrid.AllowUserToAddRows = false;
            this.EstoqueDataGrid.AllowUserToDeleteRows = false;
            this.EstoqueDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstoqueDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstoqueID,
            this.EstoqueNome,
            this.CategoriaEstoque,
            this.SetorEstoque,
            this.EstoqueQuantidade,
            this.EstoquePrecoUni,
            this.EstoqueDesc,
            this.EstoqueRemoveButton});
            this.EstoqueDataGrid.Location = new System.Drawing.Point(21, 57);
            this.EstoqueDataGrid.Name = "EstoqueDataGrid";
            this.EstoqueDataGrid.Size = new System.Drawing.Size(845, 474);
            this.EstoqueDataGrid.TabIndex = 9;
            this.EstoqueDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueButton_CellContentClick);
            // 
            // EstoqueID
            // 
            this.EstoqueID.HeaderText = "ID";
            this.EstoqueID.Name = "EstoqueID";
            // 
            // EstoqueNome
            // 
            this.EstoqueNome.HeaderText = "Nome";
            this.EstoqueNome.Name = "EstoqueNome";
            // 
            // CategoriaEstoque
            // 
            this.CategoriaEstoque.HeaderText = "Categoria";
            this.CategoriaEstoque.Name = "CategoriaEstoque";
            // 
            // SetorEstoque
            // 
            this.SetorEstoque.HeaderText = "Setor";
            this.SetorEstoque.Name = "SetorEstoque";
            // 
            // EstoqueQuantidade
            // 
            this.EstoqueQuantidade.HeaderText = "Quant. Em Estoque";
            this.EstoqueQuantidade.Name = "EstoqueQuantidade";
            // 
            // EstoquePrecoUni
            // 
            this.EstoquePrecoUni.HeaderText = "Preço Uni.";
            this.EstoquePrecoUni.Name = "EstoquePrecoUni";
            // 
            // EstoqueDesc
            // 
            this.EstoqueDesc.HeaderText = "Descrição";
            this.EstoqueDesc.Name = "EstoqueDesc";
            // 
            // EstoqueRemoveButton
            // 
            this.EstoqueRemoveButton.HeaderText = "";
            this.EstoqueRemoveButton.Name = "EstoqueRemoveButton";
            this.EstoqueRemoveButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EstoqueRemoveButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EstoqueRemoveButton.Text = "Remover";
            this.EstoqueRemoveButton.ToolTipText = "Remover";
            this.EstoqueRemoveButton.UseColumnTextForButtonValue = true;
            // 
            // EstoqueTextbox
            // 
            this.EstoqueTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EstoqueTextbox.Location = new System.Drawing.Point(21, 22);
            this.EstoqueTextbox.MaximumSize = new System.Drawing.Size(1000, 40);
            this.EstoqueTextbox.Name = "EstoqueTextbox";
            this.EstoqueTextbox.Size = new System.Drawing.Size(273, 29);
            this.EstoqueTextbox.TabIndex = 8;
            // 
            // EstoqueSearchButton
            // 
            this.EstoqueSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EstoqueSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EstoqueSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.EstoqueSearchButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EstoqueSearchButton.Location = new System.Drawing.Point(292, 21);
            this.EstoqueSearchButton.Margin = new System.Windows.Forms.Padding(1);
            this.EstoqueSearchButton.Name = "EstoqueSearchButton";
            this.EstoqueSearchButton.Size = new System.Drawing.Size(41, 31);
            this.EstoqueSearchButton.TabIndex = 7;
            this.EstoqueSearchButton.Text = "🔎";
            this.EstoqueSearchButton.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1170, 701);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Alerta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1315, 728);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de SuperMecado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.compra_groupBox.ResumeLayout(false);
            this.compra_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compra_dataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_alerta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button compra_button_additem;
        private System.Windows.Forms.DataGridView compra_dataView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button compra_button_cancelbuy;
        private System.Windows.Forms.Label compra_label_idDesc;
        private System.Windows.Forms.GroupBox compra_groupBox;
        private System.Windows.Forms.Button compra_button_endbuy;
        private System.Windows.Forms.Label compra_label_returnQuantTotal;
        private System.Windows.Forms.Label compra_label_quantTotal;
        private System.Windows.Forms.Label compra_label_returnFinalPrice;
        private System.Windows.Forms.Label compra_label_finalPrice;
        private System.Windows.Forms.Label compra_returnTimeBuy;
        private System.Windows.Forms.Label compra_label_timeBuy;
        private System.Windows.Forms.Label compra_label_returnDayBuy;
        private System.Windows.Forms.Label compra_label_dayBuy;
        private System.Windows.Forms.Label compra_label_returnQuantPreduct;
        private System.Windows.Forms.Label compra_label_quantProduct;
        private System.Windows.Forms.ComboBox compra_comboBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox EstoqueTextbox;
        private System.Windows.Forms.Button EstoqueSearchButton;
        private System.Windows.Forms.DataGridView EstoqueDataGrid;
        private System.Windows.Forms.Button EstoqueAddButton;
        private System.Windows.Forms.Button EstoqueSaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewButtonColumn minusButton;
        private System.Windows.Forms.DataGridViewButtonColumn removeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoquePrecoUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueDesc;
        private System.Windows.Forms.DataGridViewButtonColumn EstoqueRemoveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCompraHist;
        private System.Windows.Forms.DataGridViewButtonColumn VisualizarInfo;
    }
}

