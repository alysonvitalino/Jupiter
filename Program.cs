//1 - COLOCAR O ID DO PRODUTO E DIMINUIR A QUANTIDADE, SE O ID NÃO EXISTE, MOSTRAR UMA MENSAGEM DE ERRO
//2 - LISTAR OS PRODUTOS COM A QUANTIDADE ATUALIZADA
//3 - ALTERAR A SENHA, PARA ALTERAR DEVE PEDIR A SENHA ANTIGA, SE ESTIVER INCORRETO DAR UM AVISO
//4 - PARA FECHAR O CAIXA DEVE SER INSERIDO A SENHA ATUAL, MOSTRAR A LISTA DE PRODUTOS
// COM A QUANTIDADE ATUALZIADA E DEPOIS DE 20 SEGUNDOS FINALIZAR O PROGRAMA

using System.Collections.Generic;
using System.Threading;
using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class JUPITER
{
    static List<Produto> listaProdutos = new List<Produto>();

    public static void Main()
    {
        string senha = "";
        bool produtos = false;
        while (true)
        {

            Console.WriteLine("--------------------------BEM-VINDO AO--------------------------");
            Console.WriteLine("");
            Console.WriteLine(Logo());

            if (senha == "")
            {
                Console.WriteLine("INFORME A SUA SENHA DE ADMINISTRADOR!");
                senha = Console.ReadLine();
                Console.Clear();
            }
            else if (!produtos)
            {
                produtos = true;
                Console.WriteLine("----------------------ADICIONANDO OS PRODUTOS----------------------");
                Console.WriteLine(".");
                Thread.Sleep(100);
                Console.WriteLine("..");
                Thread.Sleep(100);
                Console.WriteLine("...");
                Thread.Sleep(100);
                AdicionarProduto(1, "Caixa de Bolete", 10);
                AdicionarProduto(2, "Pirulitos un.", 30);
                AdicionarProduto(3, "Heineken", 6);
                AdicionarProduto(4, "Doce de leite", 20);
                AdicionarProduto(5, "Cigarro", 3);
                AdicionarProduto(6, "Paçoca", 15);
                AdicionarProduto(7, "Água 500ml", 10);
                AdicionarProduto(8, "Coca-cola 2Lt", 4);
                Console.Clear();
                Console.WriteLine("PRODUTOS ADICIONADOS!");
                Thread.Sleep(100);
                Console.WriteLine("Vamos começar......");
                Thread.Sleep(100);
                Console.WriteLine("Vamos começar.....");
                Thread.Sleep(100);
                Console.WriteLine("Vamos começar....");
                Thread.Sleep(100);
                Console.WriteLine("Vamos começar...");
                Thread.Sleep(100);
                Console.WriteLine("Vamos começar..");
                Thread.Sleep(100);
                Console.WriteLine("Vamos começar.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------PAINEL DE CONTROLE-----------");
                Console.WriteLine("");
                Console.WriteLine("[1] - Vender Produto");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Alterar Senha");
                Console.WriteLine("[4] - Fechar Caixa");

                int decisao = Convert.ToInt32(Console.ReadLine());

                switch (decisao)
                {
                    case 1:
                        VenderProduto();
                        break;

                    case 2:
                        ListarProduto();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;

                    case 3:
                        string senhanova = AlterarSenha(senha);
                        senha = senhanova;
                        break;

                    case 4:

                        FecharCaixa(senha);
                        break;

                    default:
                        Console.WriteLine("Opção não encontrada.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public static string Logo()
    {
        string logo = "   JJJJJJJJ  U     U  PPPPPPP   II  TTTTTTTT  EEEEEEE  RRRRRRR\n";
        logo += "      JJ     U     U  PP   PP   II     TT     EE       RR   RR\n";
        logo += "      JJ     U     U  PP   PP   II     TT     EE       RR   RR\n";
        logo += "      JJ     U     U  PPPPPPP   II     TT     EEEEE    RRRRRRR\n";
        logo += "JJ    JJ     U     U  PP        II     TT     EE       RR RR\n";
        logo += "JJ    JJ     U     U  PP        II     TT     EE       RR   RR\n";
        logo += " JJJJJJ       UUUUU   PP        II     TT     EEEEEEE  RR    RR\n";
        logo += "\n";
        logo += "          3333333   00000000  00000000 00000000  !!!\n";
        logo += "          33    33  00    00  00    00 00    00  !!!\n";
        logo += "                33  00    00  00    00 00    00  !!!\n";
        logo += "          3333333   00    00  00    00 00    00  !!!\n";
        logo += "                33  00    00  00    00 00    00  !!!\n";
        logo += "          33    33  00    00  00    00 00    00  !!!\n";
        logo += "          3333333   00000000  00000000 00000000  !!!\n";

        return logo;
    }

    static void FecharCaixa(string senha)
    {
        Console.WriteLine("Digite a senha de Administrador: ");
        string senhaFecharCaixa = Console.ReadLine();
        if (senhaFecharCaixa == senha)
        {
            for (int t = 20; t > 0; t--)
            {
                Console.Clear();
                Console.WriteLine("Acesso Autorizado! ");
                ListarProduto();
                Console.WriteLine("Fechando o caixa em ...");
                Console.WriteLine($"{t} Segundos.");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Caixa Fechado.");
            return;
        }
        else
        {

            Console.WriteLine("Senha Incorreta!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }

    static string AlterarSenha(string senha)
    {
        Console.WriteLine("Para alterar a senha digite a senha padrão: ");
        string lerSenha = Console.ReadLine();
        if (lerSenha != senha)
        {
            Console.WriteLine("Senha Incorreta.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return senha;
        }
        else
        {
            Console.WriteLine("Digite a senha nova:");
            string senhaNova1 = Console.ReadLine();
            Console.WriteLine("Digite novamente a senha nova:");
            string senhaNova2 = Console.ReadLine();

            if (senhaNova1 != senhaNova2)
            {
                Console.WriteLine("Senhas não coincidem.");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();

                return senha;


            }
            else
            {
                Console.WriteLine("Senha redefinida com sucesso!");

                string senhanova = senhaNova2;
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return senhanova;
            }
        }
    }

    static void AdicionarProduto(int id, string nome, int quantidade)
    {
        Produto produto = new Produto(id, nome, quantidade);
        listaProdutos.Add(produto);
    }
    static void VenderProduto()
    {
        Console.WriteLine("Digite o ID do produto a ser vendido: ");
        int idProduto = int.Parse(Console.ReadLine());
        Produto produto = listaProdutos.Find(x => x.Id == idProduto);

        if (produto == null)
        {
            Console.WriteLine("Produto Não Encontrado.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
        else
        {

            Console.WriteLine($"Produto encontrado: {produto.Nome}. Quantidade Disponível: {produto.Quantidade}.");

            Console.WriteLine("Informe a quantidade a ser vendida: ");
            int quantidadeVenda = int.Parse(Console.ReadLine());

            if (quantidadeVenda > produto.Quantidade)
            {
                Console.WriteLine("Quantidade insuficiente no estoque.");
            }
            else
            {
                Console.Clear();
                produto.Quantidade -= quantidadeVenda;
                Console.WriteLine($"Venda realizada com sucesso! {quantidadeVenda} unidade(s) de {produto.Nome} vendidas.");
                Console.WriteLine($"Quantidade restante em estoque: {produto.Quantidade}.");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
    static void ListarProduto()
    {
        Console.WriteLine("Produtos em estoque: ");

        if (listaProdutos.Count == 0)
            Console.WriteLine("Estoque vazio.");

        foreach (var produto in listaProdutos)
        {
            Console.WriteLine($"ID: {produto.Id}. Nome: {produto.Nome}. Quantidade: {produto.Quantidade}. ");
        }
    }
}
class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Produto(int id, string nome, int quantidade)
    {
        Id = id;
        Nome = nome;
        Quantidade = quantidade;
    }
}
