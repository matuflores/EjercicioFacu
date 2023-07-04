using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacu.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //obtener generatriz con la altura y radio: generatriz.pow2=altura.pow2+radio.pow2
            double altura, radio, generatriz;
            double area, volumen;


            Console.Write("Ingrese la altura: ");
            altura= Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el radio: ");
            radio= Convert.ToDouble(Console.ReadLine());

            generatriz =Math.Sqrt( Math.Pow(altura, 2)+Math.Pow(radio,2));
            Console.WriteLine($"Generatiz: {generatriz}");

            area = Math.PI * radio * (radio + generatriz);
            volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;

            Console.WriteLine($"Dada la altura y el radio, el area es: {area}");
            Console.WriteLine($"Dada la altura y el radio, el volumen es: {volumen}");

            Console.ReadLine();
        }
    }
}
