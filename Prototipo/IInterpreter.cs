using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.Prototipo
{
    public interface IInterpreter
    {
        DateTime EncontrarDataVencimento(string[] expressao);
        string EncontrarNumeroFatura(string[] expressao);
        decimal EncontrarValor(string[] expressao);
        string EncontrarReferente(string[] expressao);
        void Config(string[] configs);
        Conta GenerateConta(string[] values);
    }
}
