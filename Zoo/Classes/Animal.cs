using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Classes.Exceptions;
using Zoo.Classes.Interface;

namespace Zoo.Classes
{
    abstract public class Animal : IAnimal
    {
        //acessórios é uma agregação
        public Acessorios _acessorio;
        private string nome;
        private string cor;
        public bool Viver { get; private set; }

        public Animal(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        //Sobrecarga
        //Construtor que chama a agregação acessórios
        public Animal (string nome, string cor, Acessorios acessorio)
        {
            _acessorio = acessorio;
            this.nome = nome;
            this.cor = cor;
        }

        public void Andar()
        {
            Console.WriteLine($"{nome} andou!");
        }

        public string Falar()
        {
            if (Viver)
            {
                return Falando();
            }

            throw new AnimalMortoException($"{nome} não pode falar, pois está morto!");
        }

        //usando abstract você obriga as classes filhas a implementarem o método
        protected abstract string Falando();

        public void Morrer()
        {
            if (Viver)
            {
                Viver = false;
                Console.WriteLine($"{nome} morreu!");
            }
            else
            {
                throw new AnimalMortoException($"{nome} já está morto!");
            }
        }

        public void Nascer()
        {
            Viver = true;
            Console.WriteLine($"{nome} nasceu!");
        }

        //Verificando se os objetos são iguais
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (Object.ReferenceEquals(obj, this))
            {
                return true;
            }

            if (obj is Animal)
            {
                Animal animalDois = obj as Animal;
                return this.nome == animalDois.nome && this.cor == animalDois.cor;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return $"Nome: {nome}, cor: {cor}. {_acessorio}";
        }
    }
}
