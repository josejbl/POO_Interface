using System;
using POO_Iterface.Classes;

namespace POO_Iterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinhos carrinhos = new Carrinhos();

            Produto p1 = new Produto();
            Produto p2 = new Produto();
            Produto p3 = new Produto();
            Produto p4 = new Produto();
            Produto p5 = new Produto();

           // Console.WriteLine("Escolha um Produto");

            p1.Nome = "geladeira";
            p1.Preco = 2985f;
            p1.Codigo = 243;

            p2.Nome = "Fogão";
            p2.Preco = 1685f;
            p2.Codigo = 253;

            p3.Nome = "Guarda-Roupa";
            p3.Preco = 2000f;
            p3.Codigo = 343;

            p4.Nome = "Mesa de Jantar";
            p4.Preco = 955f;
            p4.Codigo = 743;

            p5.Nome = "Estante";
            p5.Preco = 500f;
            p5.Codigo = 164;

          //  Console.WriteLine("Cadastrar Produto");

            carrinhos.Cadastrar(p1);
            carrinhos.Cadastrar(p5);

            carrinhos.Listar();



            

            
            
        }
    }
}
