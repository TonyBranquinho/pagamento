using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            double valorHora1, valorHora2, horaTrab1, horaTrab2, total1, total2;

            Console.WriteLine("Exemplo 1:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valorHora1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            horaTrab1 = double.Parse(Console.ReadLine(), CI);

            total1 = valorHora1 * horaTrab1;

            Console.WriteLine("O pagamento para " +nome1 +" deve ser " + 
                total1.ToString("F2", CI));

            Console.WriteLine("Exemplo 2:");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valorHora2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            horaTrab2 = double.Parse(Console.ReadLine(), CI);

            total2 = valorHora2 * horaTrab2;

            Console.WriteLine("O pagamento para "+nome2+" deve ser " +
                total2.ToString("F2", CI));
        }
    }
}
