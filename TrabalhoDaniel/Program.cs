using System;
using System.Collections.Generic;

namespace TrabalhoDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            int escolha = 0, xRA = 0;
            string xNome = "", encontrado = "";


            while (escolha != 4)
            {

                Console.WriteLine(" 1 - Incluir");
                Console.WriteLine(" 2 - Excluir");
                Console.WriteLine(" 3 - Consultar");
                Console.WriteLine(" 4 - Sair");
                Console.Write("Escolha a ação: ");
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (escolha == 1)
                {
                    var dados = new Aluno();

                    Console.Write("Digite o número de RA do aluno: ");
                    dados.RA = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o nome do aluno: ");
                    dados.Nome = Console.ReadLine();

                    Console.Write("Digite o e-mail do aluno: ");
                    dados.Email = Console.ReadLine();

                    Console.Write("Digite a data de nascimento do aluno (DD/MM/AAAA): ");
                    dados.DataNasc = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Digite o curso do aluno: ");
                    dados.Curso = Console.ReadLine();
                    alunos.Add(dados);
                }
                else if (escolha == 2)
                {
                    Console.Write("Informe o nome do aluno que será excluido: ");
                    xNome = Console.ReadLine();
                    encontrado = "N";
                    var excluir = new Aluno();
                    foreach (var item in alunos)
                    {
                        if (item.Nome == xNome)
                        {
                            excluir = item;
                            encontrado = "S";
                        }
                    }
                    if (encontrado == "N")
                    {
                        Console.WriteLine("O aluno não foi encontrado");
                    }
                    else
                    {
                        Console.WriteLine("O aluno foi excluido com sucesso");
                        alunos.Remove(excluir);
                    }
                }
                else if (escolha == 3)
                {
                    Console.WriteLine(" 1 - RA");
                    Console.WriteLine(" 2 - NOME");
                    Console.Write("Deseja consultar por: ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                    if (escolha == 1)
                    {
                        Console.Write("Digite o RA do aluno que será consultado: ");
                        xRA = Convert.ToInt32(Console.ReadLine());
                        encontrado = "N";
                        foreach (var item in alunos)
                        {
                            if (item.RA == xRA)
                            {
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("E-Mail " + item.Email);
                                Console.WriteLine("Data de nascimento: " + item.DataNasc.ToShortDateString());
                                Console.WriteLine("Curso: " + item.Curso);
                                encontrado = "S";
                            }
                        }
                        if (encontrado == "N")
                        {
                            Console.WriteLine("Aluno não encontrado");
                        }
                    }
                    else if (escolha == 2)
                    {
                        Console.Write("Digite o nome do aluno que será consultado: ");
                        xNome = Console.ReadLine();
                        encontrado = "N";
                        foreach (var item in alunos)
                        {
                            if (item.Nome == xNome)
                            {
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("E-Mail " + item.Email);
                                Console.WriteLine("Data de nascimento: " + item.DataNasc.ToShortDateString());
                                Console.WriteLine("Curso: " + item.Curso);
                                encontrado = "S";
                            }
                        }
                        if (encontrado == "N")
                        {
                            Console.WriteLine("O aluno não foi encontrado");
                        }
                    }
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Fim da Execução");
                }

            }
        }
    }
}
