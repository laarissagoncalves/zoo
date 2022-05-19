using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Classes.Enum;

namespace Zoo.Classes
{
    public class Acessorios
    {
        public TipoAcessorio TipoAcessorio { get; set; }
        public Cores Cores { get; set; }

        public Acessorios(TipoAcessorio tipoAcessorio, Cores cores)
        {
            TipoAcessorio = tipoAcessorio;
            Cores = cores;
        }

        public override string ToString()
        {
            return $"Acessório: {TipoAcessorio} da cor {Cores}";
        }

    }
}
