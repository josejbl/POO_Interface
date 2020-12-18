namespace POO_Iterface.Classes
{
    public interface ICarrinhos
    {
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int _codigo, Produto produto);
         void Deletar(Produto produto);
          
    }
}