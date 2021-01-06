using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR_2Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Brick br = new Brick();
            Brick br2 = new Brick(50, 100, 20, Color.Gray);

            int w = br2.Width;
            br2.Width = 10;
            Color c = br2.Color;
            int v = br2.Volumn;

            Console.WriteLine(c);
            Console.WriteLine(v); //10*100*20 = 20000
            
            br2.ProcessStrated += Br2_ProcessStrated;
            br2.ProcessCompleted += Br2_ProcessCompleted;
            br2.MakeBrick();

            Console.ReadKey();

        }
        private static void Br2_ProcessStrated(object sender, EventArgs e)
        {
            Console.WriteLine("작업시작");

        }
        private static void Br2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("작업끝");

        }



        
    }
}
