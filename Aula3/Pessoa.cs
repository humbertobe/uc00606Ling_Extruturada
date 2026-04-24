namespace ExerciciosAula03;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string Nome = "Humberto", int Idade = 47)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }

    public void Apresentar() => Console.WriteLine($"Nome: {this.Nome}, Idade: {this.Idade}");

    public bool EmaiorDeIdade() => this.Idade >= 18;

    public int CalcularAnoNascimento() => DateTime.Now.Year - this.Idade;

}