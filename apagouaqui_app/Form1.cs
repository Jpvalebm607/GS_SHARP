namespace apagouaqui_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrarFalha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataFalha = dateTimePickerDataFalha.Value;
                string descricao = textBoxDescricaoFalha.Text;

                if (string.IsNullOrWhiteSpace(descricao))
                    throw new Exception("A descri��o da falha n�o pode estar vazia.");

                RegistroFalha falha = new RegistroFalha(dataFalha, descricao);

                // Adiciona no DataGridView
                dataGridViewHistorico.Rows.Add(falha.Resumo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar falha: " + ex.Message);
            }
        }

        private void buttonRegistrarPrejuizo_Click(object sender, EventArgs e)
        {
            try
            {
                string item = textBoxItemPrejuizo.Text;
                decimal valor = decimal.Parse(textBoxValorPrejuizo.Text);

                if (string.IsNullOrWhiteSpace(item))
                    throw new Exception("O item n�o pode estar vazio.");

                if (valor < 0)
                    throw new Exception("O valor n�o pode ser negativo.");

                Prejuizo prejuizo = new Prejuizo(item, valor);

                // Adiciona no DataGridView
                dataGridViewHistorico.Rows.Add(prejuizo.Resumo());
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um valor num�rico v�lido para o preju�zo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar preju�zo: " + ex.Message);
            }
        }

        private void buttonGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Relat�rio gerado com sucesso! (Simula��o)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relat�rio: " + ex.Message);
            }
        }

        private void buttonExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Exporta��o em PDF conclu�da! (Simula��o)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar PDF: " + ex.Message);
            }
        }

        private void dataGridViewHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
