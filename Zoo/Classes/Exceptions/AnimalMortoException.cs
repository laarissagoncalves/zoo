using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes.Exceptions
{
    public class AnimalMortoException : Exception
    {
        public AnimalMortoException()
        {

        }

        public AnimalMortoException(string mensagem) : base(mensagem)
        {

        }

        public AnimalMortoException(string mensagem, Exception innerException) : base (mensagem, innerException)
        {

        }
    }
}
