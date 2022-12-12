// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;

namespace menu;
class Armazem
{
    public static List<List<String>> Produtos;
    public static void Main(string[] args)
    {
        Armazem.Produtos = new List<List<String>>();
        Armazem.AparecerMenu();
    }
    private static void AparecerMenu()
    {
        Console.WriteLine("1 - Cadastrar produto");
        Console.WriteLine("2 - Listar produtos cadastrados");
        Console.WriteLine("3 - Quantidade total de itens no estoque");
        Console.WriteLine("0 - Sair");
        string menu= Console.ReadLine();
        if (menu == "")
        {
            Console.Clear();
            Console.WriteLine("Digite um valor válido!!!!!!!");
            Armazem.AparecerMenu();
        }
        int op = Int32.Parse(menu);
        switch(op)
        {
            case 1:
                Armazem.cadastrar();
                Console.Clear();
                Armazem.AparecerMenu();
                break;
            case 2:
                Armazem.listar();
                Console.Clear();
                Armazem.AparecerMenu();
                break;
            case 3:
                Armazem.quantidadeEstoque();
                Console.Clear();
                Armazem.AparecerMenu();
                break;
            default:
                break;
        }
    }

    private static void listar()
    {
        Console.WriteLine("Id|Nome|Quantidade");
        foreach (var produto in Armazem.Produtos)
        {
            Console.WriteLine(produto[0] + "|" + produto[1] + "|" + produto[2]);
        }
        Console.WriteLine("Enter para voltar");
        string nada = Console.ReadLine();
    }
    private static string cadastrarCampo(string nomeCampo)
    {
        Console.WriteLine("Digite o "+nomeCampo+" do produto");
        string campo = Console.ReadLine();
        if (campo == "")
        {
            Console.Clear();
            Console.WriteLine("Digite um "+nomeCampo+" válido!!!!!!");
            campo = Armazem.cadastrarCampo(campo);
        }
        return campo;
    }
    private static void cadastrar()
    {
        List<String> produto = new List<String>();
        string id = cadastrarCampo("Id");
        string nome = cadastrarCampo("Nome");
        string quantidade = cadastrarCampo("Quantidade");
        produto.Add(id);
        produto.Add(nome);
        produto.Add(quantidade);
        Armazem.Produtos.Add(produto);
        Console.WriteLine("Enter para voltar");
        string nada = Console.ReadLine();
    }
    private static void quantidadeEstoque()
    {
        int total = 0;
        foreach (var produto in Armazem.Produtos)
        {
            total += Int32.Parse(produto[2]);
        }
        Console.WriteLine("Total de Produtos igual a: " + total);
        Console.WriteLine("Enter para voltar");
        string nada = Console.ReadLine();
    }
}
