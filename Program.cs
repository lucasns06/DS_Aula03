﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;
namespace Aula03Colecoes // Note: actual namespace depends on the project name.
{
    class Program
    {
        static List<Funcionario> lista = new List<Funcionario>();
        static void Main(string[] args)
        {
            ExemplosListasColecoes();
        }
        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Neymar";
            f1.Cpf = "12345678910";
            f1.DataAdmissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f1);
            
            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "Cristiano Ronaldo";
            f2.Cpf = "01987654321";
            f2.DataAdmissao = DateTime.Parse("30/06/2002");
            f2.Salario = 150.000M;
            f2.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "Messi";
            f3.Cpf = "135792468";
            f3.DataAdmissao = DateTime.Parse("01/11/2003");
            f3.Salario = 70.000M;
            f3.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "Mbappe";
            f4.Cpf = "246813579";
            f4.DataAdmissao = DateTime.Parse("15/09/2005");
            f4.Salario = 80.000M;
            f4.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f4);

            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "Lewa";
            f5.Cpf = "246813579";
            f5.DataAdmissao = DateTime.Parse("20/10/1998");
            f5.Salario = 90.000M;
            f5.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            lista.Add(f5);

            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Rodrigo Garro";
            f6.Cpf = "246813579";
            f6.DataAdmissao = DateTime.Parse("13/12/1997");
            f6.Salario = 300.000M;
            f6.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f6);
        }
        public static void ExibirLista()
        {
            string dados = "";
            for (int i = 0; i < lista.Count; i++)
            {
                dados += "======================================\n";
                dados += string.Format("Id: {0} \n", lista[i].Id);
                dados += string.Format("Nome: {0} \n", lista[i].Nome);
                dados += string.Format("CPF: {0} \n", lista[i].Cpf);
                dados += string.Format("Admissão: {0} \n", lista[i].DataAdmissao);
                dados += string.Format("Salário: {0} \n", lista[i].Salario);
                dados += string.Format("Tipo: {0} \n", lista[i].TipoFuncionario);
                dados += "======================================\n";
            }
            Console.WriteLine(dados);
        }
        public static void ObterPorId()
        {
            lista = lista.FindAll(x => x.Id == 1);
            ExibirLista();
        }
        public static void ObterPorId(int id)
        {
            Funcionario fBusca = lista.Find(x => x.Id == id);

            Console.WriteLine($"Personagem encontrado: {fBusca.Nome}");
        }
        public static void ExemplosListasColecoes()
        {
        Console.WriteLine("==================================================");
        Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******");
        Console.WriteLine("==================================================");
        CriarLista();
        int opcaoEscolhida = 0;
        do
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("---Digite o número referente a opção desejada: ---");
            Console.WriteLine("1 - Obter Por Id");
            Console.WriteLine("2 - Adicionar Funcionário");
            Console.WriteLine("3 - Obter Por Id digitado");
            Console.WriteLine("4 - Obter Por Salário digitado");
            Console.WriteLine("5 - Ordenar por critério (nome)");
            Console.WriteLine("6 - Contar Funcionários");
            Console.WriteLine("7 - Somar salários");
            Console.WriteLine("8 - Exibir Aprendizes");
            Console.WriteLine("9 - Buscar por nome");
            Console.WriteLine("10 - Remover funcionarios com id menor que 4");  
            Console.WriteLine("!!!!!!!!!!!!!!!!!ATIVIDADE AQUI!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("!!!!!!!!!!!!!!!!!ATIVIDADE AQUI!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("11 - Obter por nome");
            Console.WriteLine("12 - Obter Funcionarios recentes");
            Console.WriteLine("13 - Obter estatisticas");
            Console.WriteLine("14 - Validar salario admissão");
            Console.WriteLine("15 - Validar nome");
            Console.WriteLine("16 - Obter por tipo");
            Console.WriteLine("==================================================");
            Console.WriteLine("-----Ou tecle qualquer outro número para sair-----");
            Console.WriteLine("==================================================");
            Console.Write("Digite: ");
            opcaoEscolhida = int.Parse(Console.ReadLine());
            string mensagem = string.Empty;
            switch (opcaoEscolhida)
            {
                case 1:
                    ObterPorId();
                    break;
                case 2:
                    AdicionarFuncionario();
                    break;
                case 3:
                    Console.WriteLine("Digite o Id do funconário que você deseja buscar");
                    int id = int.Parse(Console.ReadLine());
                    ObterPorId(id);
                    break;
                case 4:
                    Console.WriteLine("Digite o salário para obter todos acima do valor indicado: ");
                    decimal salario = decimal.Parse(Console.ReadLine());
                    ObterPorSalario(salario);
                    break;
                case 5:
                    Console.WriteLine("Ordem pelo nome:");                   
                    Ordenar();
                    break;
                case 6:
                    Console.WriteLine("Contagem de funcionarios: ");                   
                    ContarFuncionarios();
                    break;
                case 7:
                    Console.WriteLine("Soma dos salários: ");                   
                    SomarSalarios();
                    break;
                case 8:
                    Console.WriteLine("Exibindo apenas aprendizes:");
                    ExibirAprendizes();
                    break;
                case 9:
                    Console.WriteLine("Buscando funcionários com nome aproximado:");
                    BuscarPorNomeAproximado();
                    break;
                case 10:
                    Console.WriteLine("Removendo funcionários com Id menor que 4:");
                    RemoverIdMenor4();
                    break;    
                case 11:
                    Console.WriteLine("ObterPorNome");
                    ObterPorNome();
                    break; 
                case 12:
                    Console.WriteLine("Obter funcionarios recentes:");
                    ObterFuncionariosRecentes();
                    break;  
                case 13:
                    Console.WriteLine("ObterEstatisticas:");
                    ObterEstatisticas();
                    break;  
                case 14:
                    Console.WriteLine("Validar Salario Admissao:");
                    ValidarSalarioAdmissao();
                    break;       
                case 15:
                    Console.WriteLine("ValidarNome:");
                    ValidarNome();
                    break;       
                case 16:
                    Console.WriteLine("Obter Por Tipo:");
                    ObterPorTipo();
                    break;              
                case 17:
                    Console.WriteLine("Buscando funcionários pelo nome:");
                    ObterPorNome();
                    break;                    
                default:
                    Console.WriteLine("Saindo do sistema....");
                    break;
            }
        }while (opcaoEscolhida >= 1 && opcaoEscolhida <= 16);

        Console.WriteLine("==================================================");
        Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *");
        Console.WriteLine("==================================================");
        }
        public static void AdicionarFuncionario()
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o nome:  ");
            f.Nome = Console.ReadLine();

            Console.Write("Digite o salário:  ");
            f.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a data de admissão:  ");
            f.DataAdmissao = DateTime.Parse(Console.ReadLine());

            if (string.IsNullOrEmpty(f.Nome))
            {
                Console.WriteLine("O nome deve ser preenchido");
                return;
            }
            else if (f.Salario == 0)
            {
                Console.WriteLine("Valor do salário não pode ser 0");
                return;
            }
            else
            {
                lista.Add(f);
                ExibirLista();
            }
        }
        public static void ObterPorSalario(decimal valor)
        {
            lista = lista.FindAll(x => x.Salario >= valor);
            ExibirLista();
        }
        public static void Ordenar()
        {
            lista = lista.OrderBy(x => x.Nome).ToList();
            ExibirLista();
        }
        public static void ContarFuncionarios()
        {
            int qtd = lista.Count();
            Console.WriteLine($"Existem {qtd} funcionários. ");
        }
        public static void SomarSalarios()
        {
            decimal somatorio = lista.Sum(x=> x.Salario);
            Console.WriteLine(string.Format("A soma dos salários é {0:c2}.", somatorio));
        }
        public static void ExibirAprendizes()
        {
            lista = lista.FindAll( x => x.TipoFuncionario == TipoFuncionarioEnum.Aprendiz);
            ExibirLista();
        }
        public static void BuscarPorNomeAproximado()
        {
            lista = lista.FindAll(x => x.Nome.ToLower().Contains("ronaldo"));   
            ExibirLista();
        }
        public static void BuscarPorCpfRemover()
        {
            Funcionario fBusca = lista.Find( x => x.Cpf == "01987654321");
            lista.Remove(fBusca);
            Console.WriteLine($"Personagem removido: {fBusca.Nome} \nLista Atualizada: \n");

            ExibirLista();
        }
        public static void RemoverIdMenor4()
        {
            lista.RemoveAll(x => x.Id < 4);
            ExibirLista();
        } 
        /*
        Métodos da atividade da aula 03, contendo 6 métodos.
        */
        public static void ObterPorNome()
        {
            Funcionario x = new Funcionario();
            Console.Write("Digite: ");
            string nome = Console.ReadLine();
            lista = lista.FindAll(x => x.Nome.ToLower().Contains(nome));  
            if(lista != null)
            {
                ExibirLista();
            }
            else
            {
            //nao consegui fazer :(
            Console.WriteLine("nome nao encontrado na lista");
            }
        }
        public static void ObterFuncionariosRecentes()
        {
            
            lista.RemoveAll(x => x.Id < 4);
            lista = lista.OrderByDescending(x => x.Salario).ToList();
            ExibirLista();
        }
        public static void ObterEstatisticas()
        {
            int qtd = lista.Count();
            Console.WriteLine($"Existem {qtd} funcionários. ");
            decimal somatorio = lista.Sum(x=> x.Salario);
            Console.WriteLine(string.Format("A soma dos salários é {0:c2}.", somatorio));
        }
        public static void ValidarSalarioAdmissao()
        {
            Funcionario f = new Funcionario();
            Console.Write("Digite o salário:  ");
            f.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a data de admissão:  ");
            f.DataAdmissao = DateTime.Parse(Console.ReadLine());

            if(f.Salario < 0)
            {
                Console.WriteLine("não e possivel adicionar este funcionario, sem salario ele é oq escravo?");
            }
            else
            {
                Console.WriteLine("Salário OK");    
            }
            if(f.DataAdmissao < DateTime.Now)
            {
                Console.WriteLine("Data de admissão anterior a data atual");
            }
            else
            {
                Console.WriteLine("Data OK!");
            }
        }
        public static void ValidarNome()
        {
            Console.Write("Digite: ");
            string nome = Console.ReadLine();
            if(nome.Length <= 2)
            {
                Console.WriteLine("Erro, nome muito pequeno!!");
            }else
            {
                Console.WriteLine("Nome validado! Adicione o funcionário: ");
                AdicionarFuncionario();
            }
        }
        public static void ObterPorTipo()
        {
            //Aprendiz e CLT
            Console.WriteLine("CLT: 1 || APRENDIZ: 2");
            Console.Write("Digite: ");
            int tipo = int.Parse(Console.ReadLine());

            switch(tipo)
            {
                case 1: 
                    lista = lista.FindAll( x => x.TipoFuncionario == TipoFuncionarioEnum.CLT);
                    ExibirLista();
                break;
                case 2:
                    lista = lista.FindAll( x => x.TipoFuncionario == TipoFuncionarioEnum.Aprendiz);
                    ExibirLista();
                break;
            }
        }
    }
}
