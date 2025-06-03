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
                    throw new Exception("A descrição da falha não pode estar vazia.");

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
                    throw new Exception("O item não pode estar vazio.");

                if (valor < 0)
                    throw new Exception("O valor não pode ser negativo.");

                Prejuizo prejuizo = new Prejuizo(item, valor);

                // Adiciona no DataGridView
                dataGridViewHistorico.Rows.Add(prejuizo.Resumo());
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um valor numérico válido para o prejuízo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar prejuízo: " + ex.Message);
            }
        }

        private void buttonGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Relatório gerado com sucesso! (Simulação)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
            }
        }

        private void buttonExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Exportação em PDF concluída! (Simulação)");
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
