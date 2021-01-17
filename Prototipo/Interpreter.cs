using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.Prototipo
{
    public abstract class Interpreter : IInterpreter
    {
        public string CampoConfigDataVencimento { get; set; }
        public string CampoConfigNumeroFatura { get; set; }
        public string CampoConfigReferente { get; set; }
        public string CampoConfigValor { get; set; }

        public virtual void Config(string[] configs) { }

        public abstract DateTime EncontrarDataVencimento(string[] expressao);
        public abstract string EncontrarNumeroFatura(string[] expressao);
        public abstract string EncontrarReferente(string[] expressao);
        public abstract decimal EncontrarValor(string[] expressao);
        public abstract Conta GenerateConta(string[] values);

    }
}
