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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EstoqueDataGrid = new System.Windows.Forms.DataGridView();
            this.EstoqueTextbox = new System.Windows.Forms.TextBox();
            this.EstoqueSearchButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.EstoqueAddButton = new System.Windows.Forms.Button();
            this.EstoqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoquePrecoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueRemoveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1315, 728);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_alerta
            // 
            this.label_alerta.AutoSize = true;
            this.label_alerta.Location = new System.Drawing.Point(86, 232);
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
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(910, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compras";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(19, 22);
            this.textBox2.MaximumSize = new System.Drawing.Size(1000, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 29);
            this.textBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Categoria,
            this.Setor,
            this.Quantidade,
            this.PrecoUni,
            this.Desc});
            this.dataGridView1.Location = new System.Drawing.Point(19, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 393);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Setor
            // 
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // PrecoUni
            // 
            this.PrecoUni.HeaderText = "Preço Uni.";
            this.PrecoUni.Name = "PrecoUni";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descrição";
            this.Desc.Name = "Desc";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.button8.Location = new System.Drawing.Point(294, 21);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 31);
            this.button8.TabIndex = 5;
            this.button8.Text = "🔎";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(653, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "Adicionar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(910, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EstoqueAddButton);
            this.tabPage3.Controls.Add(this.EstoqueDataGrid);
            this.tabPage3.Controls.Add(this.EstoqueTextbox);
            this.tabPage3.Controls.Add(this.EstoqueSearchButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(910, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estoque";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // EstoqueDataGrid
            // 
            this.EstoqueDataGrid.AllowUserToAddRows = false;
            this.EstoqueDataGrid.AllowUserToDeleteRows = false;
            this.EstoqueDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstoqueDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstoqueID,
            this.TipoEstoque,
            this.SetorEstoque,
            this.EstoqueQuantidade,
            this.EstoquePrecoUni,
            this.EstoqueDesc,
            this.EstoqueNome,
            this.EstoqueRemoveButton});
            this.EstoqueDataGrid.Location = new System.Drawing.Point(21, 57);
            this.EstoqueDataGrid.Name = "EstoqueDataGrid";
            this.EstoqueDataGrid.Size = new System.Drawing.Size(845, 474);
            this.EstoqueDataGrid.TabIndex = 9;
            this.EstoqueDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueButton_CellContentClick);
            // 
            // EstoqueTextbox
            // 
            this.EstoqueTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPage4.Size = new System.Drawing.Size(910, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Alerta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // EstoqueAddButton
            // 
            this.EstoqueAddButton.Location = new System.Drawing.Point(750, 22);
            this.EstoqueAddButton.Name = "EstoqueAddButton";
            this.EstoqueAddButton.Size = new System.Drawing.Size(116, 29);
            this.EstoqueAddButton.TabIndex = 10;
            this.EstoqueAddButton.Text = "Adicionar";
            this.EstoqueAddButton.UseVisualStyleBackColor = true;
            this.EstoqueAddButton.Click += new System.EventHandler(this.EstoqueAddButon);
            // 
            // EstoqueID
            // 
            this.EstoqueID.HeaderText = "ID";
            this.EstoqueID.Name = "EstoqueID";
            // 
            // TipoEstoque
            // 
            this.TipoEstoque.HeaderText = "Tipo";
            this.TipoEstoque.Name = "TipoEstoque";
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
            // EstoqueNome
            // 
            this.EstoqueNome.HeaderText = "Nome";
            this.EstoqueNome.Name = "EstoqueNome";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 728);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Gerenciador de SuperMecado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_alerta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox EstoqueTextbox;
        private System.Windows.Forms.Button EstoqueSearchButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView EstoqueDataGrid;
        private System.Windows.Forms.Button EstoqueAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoquePrecoUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueNome;
        private System.Windows.Forms.DataGridViewButtonColumn EstoqueRemoveButton;
    }
}

