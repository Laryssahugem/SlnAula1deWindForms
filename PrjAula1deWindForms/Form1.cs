namespace PrjAula1deWindForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  c�digo quando o botao logar for clicado 
            //string.Empty -> string vazia
            string mensagem;
            if (txtLogin.TextLength < 11 || txtLogin.Text == String.Empty)
            {
                mensagem = "Preecha a caixa login com um valor v�lido!";
            }
            else if (txtSenha.TextLength < 6 || txtSenha.Text == String.Empty)
            {
                mensagem = "Preecha a caixa senha com um valor v�lido!";
            }
            else
            {
                if (txtLogin.Text != "12345678901")
                {
                    mensagem = "Login inv�lido!";
                }
                else if (txtSenha.Text != "123456")
                {
                    mensagem = "Senha inv�lida!";
                }
                else
                {
                    mensagem = "Usu�rio autentificado!";
                }
            }

            // lblMensagem.Text = mensagem; //mensagem em um label
           
            
            MessageBox.Show(mensagem, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblsenha_Click(object sender, EventArgs e)
        {

        }
    }
}