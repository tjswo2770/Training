using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR_2Class
{
    class Brick
    {
        //필드(데이타)
        private int width;
        private int height;
        private int depth;
        private Color color;

        //생성자 (Constructor)
        public Brick()
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.Red;
        }
        public Brick(int width, int height, int depth, Color color)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.color = color;
        }

        //속성 (Property)
        public int Width
        {
            get { return this.width; }      //읽기 전용
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                    Console.WriteLine("음수가 될 수 없습니다.");
            }
        }
        public int Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                    Console.WriteLine("음수가 될 수 없습니다.");
            }
        }
        public int Depth
        {
            get { return this.depth; }
            set
            {
                if (value > 0)
                {
                    this.depth = value;
                }
                else
                    Console.WriteLine("음수가 될 수 없습니다.");
            }
        }
        public Color Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
            }
        }

        public int Volumn
        {
            get { return width * height * depth; }
        }

        //메서드 (Method)
        public void MakeBrick()     //return 할게 없으면 void 씀, 벽돌을 3가지 공정을통해 만들어진다고 가정
        {
            if(ProcessStrated !=null)
            {
                ProcessStrated(this, EventArgs.Empty);
            }
            Step1();
            Step2();
            Step3();
            if(ProcessCompleted !=null)
            {
                ProcessCompleted(this, EventArgs.Empty);
            }
        }

        private void Step1()
        {
            Console.WriteLine("Step #1");
        }
        private void Step2()
        {
            Console.WriteLine("Step #2");
        }
        private void Step3()
        {
            Console.WriteLine("Step #3");
        }

        //이벤트
        public event EventHandler ProcessStrated;
        public event EventHandler ProcessCompleted;
    }
}
