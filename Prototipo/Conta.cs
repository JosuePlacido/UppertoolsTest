using System;
using System.ComponentModel.DataAnnotations;

namespace Uppertools.Prototipo
{
    public class Conta
    {
        public string NumeroFatura { get; set; }
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }
        public string Referente { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Conta conta &&
                   NumeroFatura == conta.NumeroFatura &&
                   Valor == conta.Valor &&
                   DataVencimento == conta.DataVencimento &&
                   Referente == conta.Referente;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NumeroFatura, Valor, DataVencimento, Referente);
        }
    }
}
