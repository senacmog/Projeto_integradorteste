namespace ProjetoSiscola
{
    partial class frm_Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.pcb_login = new System.Windows.Forms.PictureBox();
            this.tm_login = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Location = new System.Drawing.Point(347, 164);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(55, 17);
            this.LABEL2.TabIndex = 1;
            this.LABEL2.Text = "SENHA";
            // 
            // txt_login
            // 
            this.txt_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_login.Location = new System.Drawing.Point(350, 129);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 22);
            this.txt_login.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(350, 184);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(100, 22);
            this.txt_senha.TabIndex = 1;
            // 
            // btn_acessar
            // 
            this.btn_acessar.Location = new System.Drawing.Point(350, 226);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(100, 22);
            this.btn_acessar.TabIndex = 4;
            this.btn_acessar.Text = "ACESSAR";
            this.btn_acessar.UseVisualStyleBackColor = true;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // pcb_login
            // 
            this.pcb_login.Image = global::ProjetoSiscola.Properties.Resources.load;
            this.pcb_login.Location = new System.Drawing.Point(286, 93);
            this.pcb_login.Name = "pcb_login";
            this.pcb_login.Size = new System.Drawing.Size(206, 207);
            this.pcb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_login.TabIndex = 5;
            this.pcb_login.TabStop = false;
            this.pcb_login.Visible = false;
            // 
            // tm_login
            // 
            this.tm_login.Interval = 1000;
            this.tm_login.Tick += new System.EventHandler(this.tm_login_Tick);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcb_login);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.PictureBox pcb_login;
        private System.Windows.Forms.Timer tm_login;
    }
}

