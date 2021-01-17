using System;
using System.Collections.Generic;

namespace Uppertools.Prototipo
{
    public interface IConversor
    {
        IList<Conta> Traduzir(string file);
    }
}
