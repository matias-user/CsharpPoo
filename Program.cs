using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Siames gatoS = new Siames("Blanco","bkn","Verdes" );
            Persa gatoP = new Persa("Negro", "Nice", "cafes");

            Console.WriteLine(Gatos.contador);
            Console.ReadKey();
        }
        //public class A
        //{
        //    public virtual void Hola()
        //    {
        //        Console.WriteLine("Hola soy A");
        //    }
        //}
        //public class B : A
        //{
        //    public sealed override void Hola()
        //    {
        //        Console.WriteLine("Hola soy B");
        //        base.Hola();
        //    }
        //}
        //public class C : B
        //{
        //    public new void Hola()
        //    {
        //        Console.WriteLine("Hola soy C");
        //        base.Hola();
        //    }
        }
    }
