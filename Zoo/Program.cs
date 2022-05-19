using Zoo.Classes;
using Zoo.Classes.Exceptions;

namespace Zoo
{
    class Program
    {
        public static void Main(string[] args)
        {
            var coleira = new Acessorios(Classes.Enum.TipoAcessorio.Coleira, Classes.Enum.Cores.Azul);
            var hachi = new Cachorro("Hachi", "caramelo", coleira);
            var snow = new Gato("Snow", "branco");
            coleira.ToString();

            Console.WriteLine(hachi);
            hachi.Nascer();
            Console.WriteLine(hachi.Falar());
            hachi.Andar();

            Console.WriteLine();
            Console.WriteLine(snow);
            snow.Nascer();
            Console.WriteLine(snow.Falar());
            snow.Andar();


            Console.WriteLine();

            try
            {
                var Pobi = new Cachorro("Pobi", "cinza");
                Pobi.Nascer();
                Console.WriteLine(Pobi.Falar());
                Pobi.Andar();
                Pobi.Morrer();
                Console.WriteLine(Pobi.Falar());
            }
            catch (AnimalMortoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deu erro: {ex.Message}. Entre em contato com o suporte.");
            }
            finally
            {
                Console.WriteLine("Byeee!");
            }
        }
    }
}
