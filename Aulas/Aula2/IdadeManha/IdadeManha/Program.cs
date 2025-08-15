using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeManha
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;

            int idade, atual, nasc, testeAno = agora.Year;

            // ou atual = DateTime.Now.Year (de maneira direta)

            /*

            Console.Write("Digite o ano atual: "); //usado para "perguta", mensagem que aparece na tela
            atual = Convert.ToInt32(Console.ReadLine()); //comando que permite que a pessoa digite algo.. pega o que a pessoa escreveu e guarda na variavel.. ele recebe como texto (caracteres) e precisa converter para numerico.. smepre convertemos para o tipo de variavel que recebemos. Na duvida usa o de 64.. 

            */
       

            Console.Write("Digite o ano do nascimento: ");  
            nasc = Convert.ToInt32(Console.ReadLine());

            //idade = atual - nasc;

            idade = testeAno - nasc;

            Console.WriteLine("\nA idade é: " + idade + " anos \n");

            Console.WriteLine("A idade é {0} anos \n", idade); //pode usar o write.

            Console.WriteLine("Nascendo em {0} e estando em {1} você tem {2} anos \n", nasc,testeAno,idade); //pode usar o write.

            if (idade >=18)
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você pode dirigir");
}
            else
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não pode dirigir");
}




            Console.Read(); //trava a tela, quase que "obrigatorio"

        }
    }
}
