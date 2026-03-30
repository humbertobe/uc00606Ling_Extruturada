namespace ExerciciosAula03
{
    /// <summary>
    /// 📋 EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS
    /// =======================================
    ///
    /// Exercício 1: Classificação de números
    /// Exercício 2: Par ou Ímpar (Operador Ternário)
    /// Exercício 3: Dias da semana (Switch/Case)
    /// Exercício 4: Sistema de Autenticação
    /// </summary>
    public class Aula03
    {
        public void ExecutarAula()
        {
            Console.WriteLine("\n📋 1. EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS");
            Console.WriteLine("===========================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Classificação de números (if/else if/else)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário que digite um número
            // 2. Usar if/else if/else para classificar:
            //    - Se número > 0 → POSITIVO
            //    - Se número < 0 → NEGATIVO
            //    - Se número = 0 → ZERO
            // 3. Exibir o resultado
            //
            // 💡 Dica: Use Console.ReadLine() e Convert.ToInt32()
 
            Console.WriteLine("📝 Exercício 1: Classificação de números\n");
            Console.Write("Digite um número: ");
 
            // ESCREVA SEU CÓDIGO AQUI
            int num = -7;

            if (num >= 0)
            {
            Console.WriteLine($"O Numumero {num} é Positivo");
            }
            else
            {
            Console.WriteLine($"O Numumero {num} é Negativo");
            }
 
            Console.WriteLine(); // Linha em branco
 
            // ===================================================
            // EXERCÍCIO 2: Par ou Ímpar (Operador Ternário)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário que digite um número
            // 2. Usar o operador ternário para verificar se é par ou ímpar
            //    Fórmula: número % 2 == 0 → "PAR", senão "ÍMPAR"
            // 3. Exibir o resultado
            //
            // 💡 Sintaxe do ternário: condição ? valor_se_true : valor_se_false
 
            Console.WriteLine("📝 Exercício 2: Par ou Ímpar (Ternário)\n");
            Console.Write("Digite um número: ");
 
            // ESCREVA SEU CÓDIGO AQUI

            string veri = (num % 2 == 0) ? "Par" : "Impar";
            Console.Write($"O Numumero {num} é {veri}");
 
            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 3: Dias da semana (Switch/Case)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário um número de 1 a 7
            // 2. Usar switch/case para exibir o dia correspondente:
            //    1 - Segunda-feira
            //    2 - Terça-feira
            //    3 - Quarta-feira
            //    4 - Quinta-feira
            //    5 - Sexta-feira
            //    6 - Sábado
            //    7 - Domingo
            // 3. Usar default para valores inválidos
            //
            // 💡 Cada case deve terminar com break
 
            Console.WriteLine("\n📝 Exercício 3: Dias da semana (Switch)\n");
            Console.Write("Digite um número de 1 a 7: ");
 
            // ESCREVA SEU CÓDIGO AQUI

            switch (num)
            {
                case 1:
                    Console.Write("Segunda");
                    break;
                case 2:
                    Console.Write("Terça");
                    break;
                case 3:
                    Console.Write("Quarta");
                    break;
                case 4:
                    Console.Write("Quinta");
                    break;
                case 5:
                    Console.Write("Sexta");
                    break;
                case 6:
                    Console.Write("Sabado");
                    break;
                default:
                    Console.Write("Domingo");
                    break;
            }
 
            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 4: Sistema de Autenticação
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Definir username e password corretos (admin/1234)
            // 2. Solicitar ao usuário que digite username e password
            // 3. Verificar se ambos estão corretos usando && (AND)
            // 4. Exibir "ACESSO PERMITIDO" ou "ACESSO NEGADO"
            //
            // 💡 Use == para comparar strings
 
            Console.WriteLine("\n📝 Exercício 4: Sistema de Autenticação\n");
            Console.Write("Username: ");
 
            // ESCREVA SEU CÓDIGO AQUI
            string nome = "admin";
            int pass = 1234;

            if (nome == "admin" && pass == 1234)
            {
                Console.Write("ACESSO PERMITIDO");
            }
            else
            {
                Console.Write("ACESSO NEGADO");
            }

            Console.WriteLine();
 
            // ===================================================
            // RESUMO FINAL
            // ===================================================
            Console.WriteLine("\n📌 Resumo das estruturas condicionais:");
            Console.WriteLine("if/else      → para decisões simples e complexas");
            Console.WriteLine("ternário ?:  → para atribuições simples");
            Console.WriteLine("switch/case  → para múltiplas opções de um valor");
            Console.WriteLine("&& (AND)     → todas condições devem ser verdadeiras");
        }
    }
}