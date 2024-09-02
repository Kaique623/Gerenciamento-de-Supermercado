namespace Gerenciamento_de_Supermercado
{
    partial class LoginScreen
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
            this.login_button_confirm = new System.Windows.Forms.Button();
            this.login_button_close = new System.Windows.Forms.Button();
            this.login_radio_func = new System.Windows.Forms.RadioButton();
            this.login_radio_gerent = new System.Windows.Forms.RadioButton();
            this.login_label_tittle = new System.Windows.Forms.Label();
            this.login_label_password = new System.Windows.Forms.Label();
            this.login_textbox_id = new System.Windows.Forms.TextBox();
            this.login_textbox_password = new System.Windows.Forms.TextBox();
            this.login_label_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button_confirm
            // 
            this.login_button_confirm.Location = new System.Drawing.Point(96, 342);
            this.login_button_confirm.Name = "login_button_confirm";
            this.login_button_confirm.Size = new System.Drawing.Size(222, 45);
            this.login_button_confirm.TabIndex = 0;
            this.login_button_confirm.Text = "Confirmar";
            this.login_button_confirm.UseVisualStyleBackColor = true;
            // 
            // login_button_close
            // 
            this.login_button_close.Location = new System.Drawing.Point(96, 406);
            this.login_button_close.Name = "login_button_close";
            this.login_button_close.Size = new System.Drawing.Size(222, 38);
            this.login_button_close.TabIndex = 1;
            this.login_button_close.Text = "Sair";
            this.login_button_close.UseVisualStyleBackColor = true;
            // 
            // login_radio_func
            // 
            this.login_radio_func.AutoSize = true;
            this.login_radio_func.Location = new System.Drawing.Point(96, 284);
            this.login_radio_func.Name = "login_radio_func";
            this.login_radio_func.Size = new System.Drawing.Size(80, 17);
            this.login_radio_func.TabIndex = 2;
            this.login_radio_func.TabStop = true;
            this.login_radio_func.Text = "Funcionario";
            this.login_radio_func.UseVisualStyleBackColor = true;
            // 
            // login_radio_gerent
            // 
            this.login_radio_gerent.AutoSize = true;
            this.login_radio_gerent.Location = new System.Drawing.Point(96, 319);
            this.login_radio_gerent.Name = "login_radio_gerent";
            this.login_radio_gerent.Size = new System.Drawing.Size(63, 17);
            this.login_radio_gerent.TabIndex = 3;
            this.login_radio_gerent.TabStop = true;
            this.login_radio_gerent.Text = "Gerente";
            this.login_radio_gerent.UseVisualStyleBackColor = true;
            // 
            // login_label_tittle
            // 
            this.login_label_tittle.AutoSize = true;
            this.login_label_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label_tittle.Location = new System.Drawing.Point(90, 82);
            this.login_label_tittle.Name = "login_label_tittle";
            this.login_label_tittle.Size = new System.Drawing.Size(80, 31);
            this.login_label_tittle.TabIndex = 4;
            this.login_label_tittle.Text = "Login";
            // 
            // login_label_password
            // 
            this.login_label_password.AutoSize = true;
            this.login_label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label_password.Location = new System.Drawing.Point(92, 214);
            this.login_label_password.Name = "login_label_password";
            this.login_label_password.Size = new System.Drawing.Size(131, 20);
            this.login_label_password.TabIndex = 6;
            this.login_label_password.Text = "Digite sua Senha";
            // 
            // login_textbox_id
            // 
            this.login_textbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textbox_id.Location = new System.Drawing.Point(96, 163);
            this.login_textbox_id.Name = "login_textbox_id";
            this.login_textbox_id.Size = new System.Drawing.Size(222, 32);
            this.login_textbox_id.TabIndex = 7;
            // 
            // login_textbox_password
            // 
            this.login_textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textbox_password.Location = new System.Drawing.Point(96, 246);
            this.login_textbox_password.Name = "login_textbox_password";
            this.login_textbox_password.Size = new System.Drawing.Size(222, 32);
            this.login_textbox_password.TabIndex = 8;
            // 
            // login_label_id
            // 
            this.login_label_id.AutoSize = true;
            this.login_label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label_id.Location = new System.Drawing.Point(92, 129);
            this.login_label_id.Name = "login_label_id";
            this.login_label_id.Size = new System.Drawing.Size(214, 20);
            this.login_label_id.TabIndex = 9;
            this.login_label_id.Text = "Digite o id / Nome do Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.login_label_tittle);
            this.groupBox1.Controls.Add(this.login_label_id);
            this.groupBox1.Controls.Add(this.login_button_confirm);
            this.groupBox1.Controls.Add(this.login_textbox_password);
            this.groupBox1.Controls.Add(this.login_button_close);
            this.groupBox1.Controls.Add(this.login_textbox_id);
            this.groupBox1.Controls.Add(this.login_radio_func);
            this.groupBox1.Controls.Add(this.login_label_password);
            this.groupBox1.Controls.Add(this.login_radio_gerent);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(360, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 587);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 697);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginScreen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button_confirm;
        private System.Windows.Forms.Button login_button_close;
        private System.Windows.Forms.RadioButton login_radio_func;
        private System.Windows.Forms.RadioButton login_radio_gerent;
        private System.Windows.Forms.Label login_label_tittle;
        private System.Windows.Forms.Label login_label_password;
        private System.Windows.Forms.TextBox login_textbox_id;
        private System.Windows.Forms.TextBox login_textbox_password;
        private System.Windows.Forms.Label login_label_id;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}