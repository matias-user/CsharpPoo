using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    public class Gatos
    {
        public string color, tipo_pelo, color_ojos;
        public static int contador;
        public Gatos(string color, string tpo_pelo, string color_ojos)
        {
            this.color = color;
            this.tipo_pelo = tpo_pelo;
            this.color_ojos = color_ojos;
            ++contador;
        }
       
        public void Comer()
        {
            Console.WriteLine("Gato comiendo...");
        }
        public void Maullar()
        {
            Console.WriteLine("Gato maullando...");
        }
        public void Dormir()
        {
            Console.WriteLine("Gato Durmiendo...");
        }
    }
    public class Siames : Gatos
    {
        public Siames(string color, string tpo_pelo, string color_ojos) : base(color, tpo_pelo, color_ojos)
        {
            this.color = color;
            this.tipo_pelo = tpo_pelo;
            this.color_ojos = color_ojos;
        }
    }
    public class Maine : Gatos
    {
        public Maine(string color, string tpo_pelo, string color_ojos) : base(color, tpo_pelo, color_ojos)
        {
            this.color = color;
            this.tipo_pelo = tpo_pelo;
            this.color_ojos = color_ojos;
        }
    }
    public class Persa : Gatos
    {
        public Persa(string color, string tpo_pelo, string color_ojos) : base(color, tpo_pelo, color_ojos)
        {
            this.color = color;
            this.tipo_pelo = tpo_pelo;
            this.color_ojos = color_ojos;
        }
    }
}
