using System;
using System.Collections.Generic;
using Uppertools.Prototipo;
using Uppertools.Prototipo.Leitores;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCSV()
        {
            Conta esperado = new Conta
            {
                NumeroFatura = "08723139933190900187",
                DataVencimento = Convert.ToDateTime("2020-04-15"),
                Valor = 684.97M,
                Referente = "CmGbkUEsjcdDtlE"
            };
            IInterpreter csvInterpreter = new InterpreterCSV() {
                CampoConfigDataVencimento = "Vencimento",
                CampoConfigNumeroFatura = "Fatura",
                CampoConfigValor = "Valor Total",
                CampoConfigReferente = "Referente"
            };
            LeitorCSV leitor = new LeitorCSV(csvInterpreter);
            IList<Conta> result = leitor.Traduzir("../../../../file.csv");
            Assert.Equal(esperado,result[0]);
            Assert.True(result.Count == 5);
        }
    }
}
