namespace PrjAula1deWindForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            buttonLogar = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            lblMensagem = new Label();
            txtSenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(328, 124);
            txtLogin.MaxLength = 11;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(266, 36);
            txtLogin.TabIndex = 0;
            // 
            // buttonLogar
            // 
            buttonLogar.BackColor = Color.Violet;
            buttonLogar.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogar.Location = new Point(401, 294);
            buttonLogar.Name = "buttonLogar";
            buttonLogar.Size = new Size(134, 45);
            buttonLogar.TabIndex = 2;
            buttonLogar.Text = "Logar";
            buttonLogar.UseVisualStyleBackColor = false;
            buttonLogar.Click += button1_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Old English Text MT", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.Location = new Point(158, 126);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(93, 34);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            lblLogin.Click += label1_Click_1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Old English Text MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(158, 203);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(97, 34);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            lblSenha.Click += Lblsenha_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AccessibleRole = AccessibleRole.Text;
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("ScriptC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagem.ForeColor = SystemColors.ControlText;
            lblMensagem.Location = new Point(109, 376);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 47);
            lblMensagem.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(328, 201);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(266, 36);
            txtSenha.TabIndex = 9;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ScriptC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 78);
            label1.TabIndex = 10;
            label1.Text = "Fazer Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(lblMensagem);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(buttonLogar);
            Controls.Add(txtLogin);
            Name = "Form1";
            Text = "JucasBank-Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Button buttonLogar;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblMensagem;
        private TextBox txtSenha;
        private Label label1;
    }
}