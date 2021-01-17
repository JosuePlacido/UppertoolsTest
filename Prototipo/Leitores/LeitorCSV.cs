using System;
using System.Collections.Generic;
using System.IO;

namespace Uppertools.Prototipo
{
    public class LeitorCSV : IConversor
    {
        private IInterpreter Interpreter { get; set; }
        public LeitorCSV(IInterpreter model)
        {
            Interpreter = model;
        }

        public IList<Conta> Traduzir(string filePath)
        {
            IList<Conta> list = new List<Conta>(); ;
            using (var reader = new StreamReader(filePath))
            {
                if (!reader.EndOfStream)
                {
                    string[] cabecalho = reader.ReadLine().Split(",");
                    Interpreter.Config(cabecalho);

                }
                while (!reader.EndOfStream)
                {
                    var values = reader.ReadLine().Split(',');
                    //RegistrarConta(Interpreter.GenerateConta(values));
                    list.Add(Interpreter.GenerateConta(values));
                }
            }
            return list;
        }

        private void RegistrarConta(Conta conta)
        {
            //Salvar a conta gerada para alglum lugar
        }
    }
}
