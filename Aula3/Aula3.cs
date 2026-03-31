using System.Dynamic;

namespace ExerciciosAula03
{
   
    public class Aula03
    {
        public void ExecutarAula()
        {
            Console.WriteLine("\n📘 EXERCÍCIOS GERAIS DE REVISÃO");
            Console.WriteLine("===========================================\n");
 
            // EXERCÍCIO 1: Verificar número positivo
            // ===================================================
            // 👉 O QUE FAZER:
            // Criar uma variável número
            // Usar IF para verificar se é positivo ou negativo
            // Mostrar o resultado
 
            //SAIDA
            /**� Exercício 1
            Número negativo ou zero*/
 
            Console.WriteLine("📝 Exercício 1\n");
            Console.WriteLine("Digite um número: ");
 
            int num = 2;

            if (num > 0)
            {
            Console.WriteLine($"O Numumero {num} é Positivo");
            }
            else
            {
            Console.WriteLine($"O Numumero {num} é Negativo ou Zero");
            }
 
            Console.WriteLine(); // Linha em branco
 
            // ===================================================
            // EXERCÍCIO 2: Maior de dois números
            // ===================================================
            // 👉 O QUE FAZER:
            // Criar duas variáveis
            // Usar operador de comparação
            // Mostrar qual é maior
 
            //SAIDA
            /**� Exercício 2
            10 é maior que 7*/
 
            Console.WriteLine("📝 Exercício 2\n");
            Console.WriteLine("Digite dois números: ");
            int valor = 7;
            int valor2 = 5;    

            if (valor > valor2)
            {
            Console.WriteLine($"O 1º numero {valor} é maior que o 2º numero {valor2}");
            }
            else
            {
            Console.WriteLine($"O 2º numero {valor2} é maior que o 1º numero {valor}");
            }
 
            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 3: Sistema de desconto (operador ternário)
            // ===================================================
            // 👉 O QUE FAZER:
            // Se o valor da compra for maior que 100
            // aplicar desconto de 10%
            // Usar operador ternário
 
            //SAIDA
            /**� Exercício 3
            Desconto: 10%*/

            Console.WriteLine("📝 Exercício 3\n");

            double compra = 99;

            double status = (compra >= 100) ?  compra - compra * 0.1 : compra;
            Console.WriteLine($"O valor final é {status}");

            Console.WriteLine("\n");

            // ===================================================
            // EXERCÍCIO 4: Classificação de idade
            // ===================================================
            // 👉 O QUE FAZER:
            // Criar variável idade
            // Usar IF/ELSE IF/ELSE:
            // < 12 → Criança
            // < 18 → Adolescente
            // >= 18 → Adulto

            //SAIDA
            /**� Exercício 4
            Adolescente*/

            Console.WriteLine("📝 Exercício 4\n");

            int idade = 10;

            if (idade >=18)
            {
            Console.WriteLine($"Tem {idade} anos é Adulto");
            }
            if  (idade <18 && idade > 12)
            {
            Console.WriteLine($"Tem {idade} anos é Adolescente");
            }
            if (idade <=12)
            {
            Console.WriteLine($"Tem {idade} anos é Criança");
            }

            Console.WriteLine("\n");

            // ===================================================
            // EXERCÍCIO 5: Menu com SWITCH
            // ===================================================
            // 👉 O QUE FAZER:
            // Criar variável opção (int)
            // Usar SWITCH:
            // 1 → "Novo jogo"
            // 2 → "Carregar jogo"
            // 3 → "Sair"

            Console.WriteLine("📝 Exercício 5");
            //SAIDA
            /**� Exercício 5
            Carregar jogo*/
 
            int jog = 3;

            switch (jog)
            {
                case 1:
                    Console.WriteLine("Novo Jogo");
                    break;
                case 2:
                    Console.WriteLine("Carregar Jogo");
                    break;
                case 3:
                    Console.WriteLine("Sair");
                    break;
            }
 
            Console.WriteLine("\n");
 
            // ===================================================
            // EXERCÍCIO 6: Validação de acesso
            // ===================================================
            // 👉 O QUE FAZER:
            // Criar:
            // idade >= 18
            // temConvite = true/false
            // Usar operadores lógicos
            // Mostrar se pode entrar

            //SAIDA
            /**� Exercício 6
            pode entrar? True*/

            Console.WriteLine("📝 Exercício 6");
  
            int idades = 17;

            string auto = "convite";

            if (idades >= 18)
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                if (auto == "convite")
                {
                    Console.WriteLine("ACESSO PERMITIDO-2");
                }
                else
                {
                    Console.WriteLine("ACESSO NEGADO");
                }
            }

            Console.WriteLine("\n");

            /*  Exercícios de FOR
            
            Console.WriteLine("Contagem progressiva de 1 a 5");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{i}\n");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Gerar números pares em sequência até 10");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{i * 2}\n");
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Calcular e exibir tabuada do 7");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * 7 = {i * 7}\n");
            }

            //  Exercícios de WHILE

            Console.WriteLine("\n");
            Console.WriteLine("Contagem regressiva de 5 a 1");
        
            int numero = 5;
            while (numero >= 1)
            {
                Console.WriteLine($"{numero}\n");
                numero--;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Acumular valores até atingir um limite de 100");
            
            int vale = 1;
            int som = 0;
            while (som < 100)
            {
                Console.Write($"{som+vale},");
                som += vale;
            }
             
            Console.WriteLine("\n");
            Console.WriteLine("Validar senha com número limitado de tentativas");*/
 
        }
    }
}