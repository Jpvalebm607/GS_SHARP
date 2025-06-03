using System;

namespace apagouaqui_app
{
    public class RegistroFalha
    {
        public DateTime DataFalha { get; set; }
        public string Descricao { get; set; }

        public RegistroFalha(DateTime dataFalha, string descricao)
        {
            DataFalha = dataFalha;
            Descricao = descricao;
        }

        public string Resumo()
        {
            return $"[FALHA] {DataFalha.ToShortDateString()} - {Descricao}";
        }
    }
}
