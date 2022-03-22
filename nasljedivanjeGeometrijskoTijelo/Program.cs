using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanjeGeometrijskoTijelo
{
    public class GeometrijskoTijelo
    {
        double volumen, oplosje;
        public static int brojacTijela = 0;

        public GeometrijskoTijelo()
        {
            brojacTijela++;
        }

    }

    public class Kugla : GeometrijskoTijelo
    {
        
    }

    public class Kvadar : GeometrijskoTijelo
    {

    }

    public class Kocka : Kvadar
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Console.WriteLine(GeometrijskoTijelo.brojacTijela);
            Kvadar y = new Kvadar();
            Console.WriteLine(GeometrijskoTijelo.brojacTijela);
            Kocka z = new Kocka();
            Console.WriteLine(GeometrijskoTijelo.brojacTijela);


            Console.ReadKey();

        }
    }
}
