namespace Aula13CadastroUsuarios
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        void atualizarPessoas()
        {
            listView1.Clear();
            for (int i = 0; i < pessoas.Count; i++)
            {
                listView1.Items.Add(pessoas[i].nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string rua = txtRua.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, rua, cidade);
            pessoas.Add(pessoa);
            atualizarPessoas();
        }
    }
}