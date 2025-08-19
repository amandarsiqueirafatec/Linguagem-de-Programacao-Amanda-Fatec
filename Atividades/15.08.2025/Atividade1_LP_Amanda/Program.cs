/*
Escreva um programa em modo console C# para:
 a) Calcular a área de um triangulo
 b) Calcular a área de um trapézio
 c) Calcular o número de Reynolds, sendo que: NR = (velocidade*diametro*viscosidade)/densidade 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atividade1_LP_Amanda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false; // Variável de controle para o loop do menu principal

            while (!sair) // Loop que mantém o menu até o usuário escolher sair
            {
                
                // Menu principal
                
                Console.Clear(); // Limpa a tela a cada repetição do menu
                Console.WriteLine(" Menu Principal "); // Título do menu
                Console.WriteLine("1 - Calcular área do Triângulo");
                Console.WriteLine("2 - Calcular área do Trapézio");
                Console.WriteLine("3 - Calcular o Número de Reynolds");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: "); 
              

                string opcao = Console.ReadLine(); // Lê a opção digitada 

                switch (opcao)
                {
                    case "1":// Cálculo da Área do Triângulo
                     
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" Cálculo da Área do Triângulo "); 
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Fórmula: Área = (base × altura) / 2\n"); 
                        Console.ResetColor();

                        Console.Write("Digite a base do triângulo: ");
                        double baseTri = Convert.ToDouble(Console.ReadLine()); // Converte texto para número, Double porque pode ser numero quebrado.

                        Console.Write("Digite a altura do triângulo: ");
                        double alturaTri = Convert.ToDouble(Console.ReadLine());

                        double areaTri = (baseTri * alturaTri) / 2; // Calcula a área

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nÁrea do triângulo: " + areaTri+ "\n"); // Mostra o resultado
                        Console.ResetColor();
                        break; //quebrar, sair desse loop "case 1"

                    case "2":// Cálculo da Área do Trapézio
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(" Cálculo da Área do Trapézio ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Fórmula: Área = ((base maior + base menor) × altura) / 2\n");
                        Console.ResetColor();


                        Console.Write("Digite a base maior do trapézio: ");
                        double baseMaior = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite a base menor do trapézio: ");
                        double baseMenor = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite a altura do trapézio: ");
                        double alturaTrap = Convert.ToDouble(Console.ReadLine());

                        double areaTrap = ((baseMaior + baseMenor) * alturaTrap) / 2; // Calcula a área

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nÁrea do trapézio: " + areaTrap + "\n"); 
                        Console.ResetColor();
                        break;

                    case "3":// Cálculo do Número de Reynolds
                       
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" Cálculo do Número de Reynolds ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Fórmula: RE = (velocidade × diâmetro × densidade) / viscosidade\n");
                        Console.ResetColor();

                        
                        Console.Write("Digite a velocidade do fluido (m/s): ");
                        double velocidade = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o diâmetro do tubo (m): ");
                        double diametro = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite a viscosidade do fluido (Pa.s): ");
                        double viscosidade = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite a densidade do fluido (kg/m³): ");
                        double densidade = Convert.ToDouble(Console.ReadLine());

                        double reynolds = (velocidade * diametro * densidade) / viscosidade; // Calcula o número de Reynolds

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nNúmero de Reynolds: " + reynolds.ToString("F2") + "\n"); //, ToString sendo usado para limitar o numero de casas decimais
                        Console.ResetColor();
                        // Verificando o tipo de fluxo
                        if (reynolds < 2000)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Fluxo Laminar → suave, organizado");
                        }
                        else if (reynolds > 4000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fluxo Turbulento → bagunçado, mistura");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Região de transição → entre laminar e turbulento");
                        }

                        Console.ResetColor();
                        break;

                    case "0":
                        sair = true; // Sai do loop e termina o programa
                        continue;

                    default: //caso selecione uma opção fora do case

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida! Pressione Enter para continuar...");
                        Console.ResetColor();
                        Console.ReadLine(); // Aguarda o usuário antes de voltar ao menu
                        continue;
                }

               
                // Mini-menu após cada cálculo
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n1 - Voltar ao Menu Principal");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha: ");
                Console.ResetColor();
                string miniOpcao = Console.ReadLine();

                if (miniOpcao == "2")
                    sair = true; // Se escolher 2, encerra o programa
            }

            Console.Read(); // trava a tela 
        }
    }
}
