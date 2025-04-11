// See https://aka.ms/new-console-template for more information
using Desafio3;

class Program
{
    static void Main()
    {
        var herois = new List<Heroi>
        {
            new Heroi("Gandalf", 150, "mago"),
            new Heroi("Aragorn", 87, "guerreiro"),
            new Heroi("Lee", 40, "monge"),
            new Heroi("Hanzo", 29, "ninja")
        };

        foreach (var heroi in herois)
        {
            heroi.Atacar();
        }
    }
}
