using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR1_Enum      //Enum 가독성을 위해서 사용
{
    class Program
    {
        enum Item
        {
            Coffee =1, //default는 0부터 시작
            Tea,
            Icecream,
            Bread,
        }

        [Flags]
        enum Border
        {
            None = 0,   
            Top = 1,    // 0000 0001
            Right = 2,  // 0000 0010
            Bottom = 4, // 0000 0100
            Left = 8,   // 0000 1000
        }

        static void Main(string[] args)
        {
            Order(Item.Tea, 3);
            //Order(2, 3); //Tea 3 잔 주문
            
            Border b = Border.Top | Border.Bottom;  //or 다중 플래그 할당

            //if ( (b & Border.Top) ! = 0)       //Border에 Top을 가지고 있는가? 0이 아니면 Top을 가지고 있는것
            //{
            //    nullable 참조 형식은 C# version 8부터 사용할 수 있음
            //}

            if ( b.HasFlag(Border.Top | Border.Bottom))
            {
                Console.WriteLine(b.ToString());
            }

            //Console.WriteLine(b);
            Console.ReadKey();
        }

        static void Order( Item item,int qty )
        {
            switch(item)
            {
                case Item.Coffee:
                    break;
                case Item.Tea:
                    break;
                case Item.Icecream:
                    break;
                case Item.Bread:
                    break;
                default:
                    break;
            }
        }


        //static void Order(int item, int qty)
        //{
        //    switch( item )
        //    {
        //        case 1:
        //            //make coffee
        //            break;
        //        case 2:
        //            //make Tea
        //            break;
        //        case 3:
        //            //Scoop Icecream
        //            break;
        //        case 4:
        //            //Bake bread & Serve
        //            break;
        //        default:
        //            break;
        //    }
        }

    }
