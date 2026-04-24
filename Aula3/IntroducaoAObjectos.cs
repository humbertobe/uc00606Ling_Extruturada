namespace ExerciciosAula03;

public class introducaoAObjectos
{
    public void Executar()
    {
        Console.WriteLine("Introdção a instâncias ou objectos\n");

        Pessoa pessoa = new Pessoa("Santos", 40);
        Pessoa pessoa1 = new Pessoa(); // Pk em Pessoa.cs já esta defenido as variáveis 

        //Usando o Objecto ou Instância
        Console.WriteLine("Nosso Objecto\n");
        pessoa.Apresentar();
        pessoa1.Apresentar();

        //Modificar valores
        Console.WriteLine("\nMoificando valores sem o Get e o Set\n");
        pessoa.Nome = " josé";
        pessoa.Apresentar();

        //Usando metodos com retorno
        Console.WriteLine("Metodos com retorno\n");
        Console.WriteLine($"{pessoa1.Nome} é maior de idade ? {pessoa1.EmaiorDeIdade()}");
        Console.WriteLine($"Ano de nascimento aproximado: {pessoa1.CalcularAnoNascimento()}");

        //Nossa Lista
        Console.WriteLine("\nNossa Lista de objectos\n");
        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(pessoa);
        pessoas.Add(pessoa1);
        pessoas.Add(new Pessoa());
        pessoas.Add(new Pessoa("Luis", 55));

        List<object> minhaString = new List<object>();
        minhaString.Add(1);
        minhaString.Add("Alfredo");
        minhaString.Add(true);
        minhaString.Add(new Pessoa());

        minhaString.ForEach(vera =>
        {
            Console.WriteLine($"Minha variavel Vera: {vera.ToString()}");
        });

        pessoas.ForEach(p =>
        {
            p.Apresentar();
        });

        Console.WriteLine("\nNova Lista de objectos\n");

        foreach (var item in pessoas)
        {
            item.Apresentar();
        }
    }
}