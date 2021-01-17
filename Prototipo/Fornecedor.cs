using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.Prototipo
{
    public class Fatura
    {
        public string Fornecedor { get; set; }
        [DataType(DataType.Url)]
        public string Endpoint { get; set; }
        public string Descricao { get; set; }
        public string formatoArquivo { get; set; }
        public Interpreter Interpreter { get; set; }
    }
}
