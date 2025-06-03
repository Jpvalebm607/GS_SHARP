using System;

namespace apagouaqui_app
{
    public class Prejuizo
    {
        public string Item { get; set; }
        public decimal Valor { get; set; }

        public Prejuizo(string item, decimal valor)
        {
            Item = item;
            Valor = valor;
        }

        public string Resumo()
        {
            return $"[PREJUÍZO] {Item} - R$ {Valor:F2}";
        }
    }
}
