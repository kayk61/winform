namespace petforms;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Animal
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    protected Animal(string nome, int idade)
    {
        if (string.IsNullOrWhiteSpace(nome))

            throw new ArgumentException("O nome do animal é obrigatorio");

        if (idade < 0)

            throw new ArgumentException("A idade do cachorro não pode ser negativa");

        Nome = nome;
        Idade = idade;

    }

    public abstract string FazerSom();

    public void Comer() => Console.WriteLine($"{Nome} está comendo");
    public override string ToString() => $"{Nome} ({Idade} anos) - {GetType().Name}";

    public class Cachorro : Animal
    {

        public Cachorro(string nome, int idade) : base(nome, idade) { }

        public override string FazerSom() => "Au au";



    }
    public class Gato : Animal
    {

        public Gato(string nome, int idade) : base(nome, idade) { }

        public override string FazerSom() => "miau miau";


    }

    public class Passaro : Animal
    {
        public Passaro(string nome, int idade) : base(nome, idade) { }

        public override string FazerSom() => "piu piu";

    }



    class Program
    {
        public static void Main(string[] args)
        {

            List<Animal> animais = new List<Animal>
    {
        new Cachorro ("pex",5),
        new Gato ("jujuba", 5),
        new Passaro("tobias",10)
    };
            foreach (Animal animal in animais)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.FazerSom());
                animal.Comer();
                Console.WriteLine();

            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            try
            {
                Animal animalinvalido = new Cachorro("", -5);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Erro ao criar animal ");
            }
            Console.ReadKey();

        }
    }


}
