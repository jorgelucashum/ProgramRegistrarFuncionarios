using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRegistrarFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionarios vão ser registrados?");
            int quantFuncionario = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            for (int i = 1; i <= quantFuncionario; i++)
            {
                Console.WriteLine("Funcionario #" + i);
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                listaFuncionarios.Add(new Funcionario(id, nome, salario));

            }

            Console.WriteLine("\nDigite o ID da pessoa para aumentar o salário");
            int buscarId = int.Parse(Console.ReadLine());

            Funcionario listaBuscar = listaFuncionarios.Find(x => x.Id == buscarId);

            if (listaBuscar != null)
            {
                Console.Write("Digite a porcentagem a ser aumentada no salário: ");
                double porcentagem = double.Parse(Console.ReadLine());

                listaBuscar.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não existe");
            }

            Console.WriteLine("\nLista atualizada: ");

            foreach (Funcionario obj in listaFuncionarios)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
