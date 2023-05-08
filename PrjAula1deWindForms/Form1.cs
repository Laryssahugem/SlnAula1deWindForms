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
            //  código quando o botao logar for clicado// 
            if (txtLogin.Text == "12345678901" && txtSenha.Text == "123456")
            {
                lblMensagem.Text = "Usuário autentificado!";
            }
            else
            {
                lblMensagem.Text = "Usuário autentificado!";
            }
        } 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblsenha_Click(object sender, EventArgs e)
        {

        }
    }
}