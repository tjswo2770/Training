using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR4_반복문_Repetitive_Statement_
{
    class Program
    {
        static void Main(string[] args)
        {
            //// while 루프
            //int i = 1;
            //while( i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //// for 루프
            //for(int a = 3; a<=13 ; a++ )  //for(초기값을 할당하는 부분, 조건문, 증가하는부분)
            //{
            //    Console.WriteLine(a);
            //}

            //// foreach 루프
            //string[] cities = new string[] { "Seattle", "Paris", "Suwon" };
            //foreach( string s in cities )    //foreach( 변수 in  컬렉션)
            //{
            //    Console.WriteLine(s);
            //}

            //// do ~ while 루프
            //string menu;
            //do
            //{
            //    Console.WriteLine("Select City : (S)uwon (P)aris (L)ondon (Q)uit");
            //    menu = Console.ReadLine();
            //    Console.WriteLine(menu + "를 골랐습니다");
            //    //이블록을 먼저 실행한 후 뒤의 while 조건문을 체크한다. ---> While문은 조건을 먼저 체크한 후 뒤의 블록을 실행하는점에서 차이점있음.
            //} while (menu != "Q");

            // continue , break
            int b = 1;
            int sum = 0;
            while( b <= 100)
            {
                if(b % 11 ==0)
                {
                    b++;
                    continue;
                    //break;
                }
                sum += b;
                b++;
                Console.WriteLine(b);
                Console.WriteLine(sum);
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
