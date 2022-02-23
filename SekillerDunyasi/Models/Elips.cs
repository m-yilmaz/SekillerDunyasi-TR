using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi.Models
{
    public class Elips : Sekil
    {
        public override string Tur => "Elips";


        public Elips() // : base() default olarak var.
        {

        }
        public Elips(int x, int y, int genislik, int yukseklik, Color renk) : base(x, y, genislik, yukseklik, renk)
        {
        }
        public double R1 => Genislik / 2.0;
        public double R2 => Yukseklik / 2.0;
        public override double Alan()
        {
            return Math.PI * R1 * R2;
        }

        public override double Cevre()
        {
            return 2 * Math.PI * Math.Sqrt((R1 * R1 + R2 * R2) / 2);
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillEllipse(firca, X, Y, Genislik, Yukseklik);
            
        }
    }
}
