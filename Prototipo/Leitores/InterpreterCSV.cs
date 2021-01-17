using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.Prototipo.Leitores
{
    public class InterpreterCSV : Interpreter
    {
        private int IndexDataVencimento;
        private int IndexNumeroFatura;
        private int IndexReferente;
        private int IndexValor;

        public override Conta GenerateConta(string[] values)
        {
            return new Conta
            {
                DataVencimento = EncontrarDataVencimento(values),
                Referente = EncontrarReferente(values),
                NumeroFatura = EncontrarNumeroFatura(values),
                Valor = EncontrarValor(values),
            };
        }

         public override void Config(string[] colunas)
        {
            IndexDataVencimento = Array.IndexOf(colunas, CampoConfigDataVencimento[0]);
            IndexNumeroFatura = Array.IndexOf(colunas, CampoConfigNumeroFatura[0]);
            IndexReferente = Array.IndexOf(colunas, CampoConfigReferente[0]);
            IndexValor = Array.IndexOf(colunas, CampoConfigValor[0]);
        }

         public override DateTime EncontrarDataVencimento(string[] values)
        {
            return Convert.ToDateTime(values[IndexDataVencimento]);
        }

         public override string EncontrarNumeroFatura(string[] values)
        {
            return values[IndexNumeroFatura];
        }

         public override string EncontrarReferente(string[] values)
        {
            return values[IndexReferente];
        }

         public override decimal EncontrarValor(string[] values)
        {
            return Convert.ToDecimal(values[IndexValor], new CultureInfo("en-US"));
        }
    }
}
