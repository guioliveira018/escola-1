using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace escola_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[20];
            int[] idade = new int[20];
            string[] sexo = new string[20];


            int num = 0;
            while (num != 3)
            {
                if (num == 0)
                {
                    Console.WriteLine("1°Adicionar");
                    Console.WriteLine("2° Lista");
                    Console.WriteLine("3° sair");
                    int.TryParse(Console.ReadLine(), out num);
                }

                // Adicionar nome do aluno,idade,sexo.

                if (num == 1)
                {
                    for (int reposta = 0; reposta < alunos.Length; reposta++) ;
                    {

                        Console.WriteLine("Nome do aluno");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Idade do Aluno");
                        int Idade = Console.ReadLine().Length;
                        Console.WriteLine("sexo");
                        string sex = Console.ReadLine();

                        Console.Clear();
                    }
                }if (num ==2)
                {

                }
            }
        }
    }
}
