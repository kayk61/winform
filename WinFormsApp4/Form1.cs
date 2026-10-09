namespace WinFormsApp4;



using petforms;

public partial class Form1 : Form
{
    private readonly List<Animal> animais = new List<Animal>();
    public Form1()
    {
        InitializeComponent();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void lblIdade_Click(object sender, EventArgs e)
    {

    }

    private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text;

        if (!int.TryParse(txtIdade.Text, out int idade))
        {
            MessageBox.Show("Digite uma idade válida.", "Erro de validação");
            return;
        }

        Animal novoAnimal;

        try
        {
            if (cmbTipo.SelectedItem?.ToString() == "Cachorro")
                novoAnimal = new Animal.Cachorro(nome, idade);
            else if (cmbTipo.SelectedItem?.ToString() == "Gato")
                novoAnimal = new Animal.Gato(nome, idade);
            else if (cmbTipo.SelectedItem?.ToString() == "Passaro")
                novoAnimal = new Animal.Passaro(nome, idade);
            else
            {
                MessageBox.Show("Selecione o tipo do animal.", "Erro de validação");
                return;
            }
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Erro ao cadastrar");
            return;
        }

        animais.Add(novoAnimal);
        lstAnimais.Items.Add(novoAnimal);

        txtNome.Clear();
        txtIdade.Clear();
        cmbTipo.SelectedIndex = -1;
    }

    private void btnFazerSom_Click(object sender, EventArgs e)
    {
        if (lstAnimais.SelectedItem is Animal animalSelecionado)
        {
            MessageBox.Show(animalSelecionado.FazerSom(), $"{animalSelecionado.Nome} diz:");
        }
        else
        {
            MessageBox.Show("Selecione um animal na lista primeiro.", "Nenhum animal selecionado");
        }
    }
}


