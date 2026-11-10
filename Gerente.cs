namespace Heranca
{
    public class Gerente : Funcionario
    {
        public int Codigo { get; set; }

        public Gerente()
        {
            
        }

        public Gerente(string nome, decimal salario, int codigo) : base(nome, salario)
        {
            Codigo = codigo;
        }

        public void GerenciarEquipe()
        {
            Console.WriteLine("Gestor está gerenciando a equipe.");
        }

        public void ExibirSalario()
        {
            Console.WriteLine(Salario);
        }

    }
}