using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Gato : Animal
    {
        public Gato(string nome, string cor) : base(nome, cor)
        {
        }

        public Gato(string nome, string cor, Acessorios acessorio) : base(nome, cor, acessorio)
        {
        }

        protected override string Falando()
        {
            return "Miaau";
        }
    }
}
