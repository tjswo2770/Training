using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR3_조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 95;

            //if문

            if (score >= 90)
            {
                if (score == 100)
                {
                    Console.WriteLine("만점");
                }
                else
                {
                    Console.WriteLine("수");
                }
            }
            else if (score >= 80)
            {
                Console.WriteLine("우");
            }
            else if (score >= 70)
            {
                Console.WriteLine("미");
            }
            else if (score >= 60)
            {
                Console.WriteLine("양");
            }
            else
            {
                Console.WriteLine("가");
            }

            int a = -1;
            //int b;
            //if ( a > 0)
            //{
            //    b = a;
            //}
            //else
            //{
            //    b = 0;
            //}

            int b = (a > 0) ? a : 0;    //조건연산자    ---> a 가 0 보다 크면a를 리턴하고 그렇지 않으면 0이다. 
                                        //   '?' --> 참일경우    ':'  -->그렇지 않을 경우

            //if (score >=90)
            //{
            //    Console.WriteLine("합격");
            //}
            //else
            //{
            //    Console.WriteLine("불합격");
            //}

            //switch문
            string option = args[0];
            //string option = "/s";
            switch (option)
            {
                case "/p":
                    Console.WriteLine("Phone");
                    break;
                case "/s":
                    Console.WriteLine("SMS");
                    break;
                case "/k":
                    Console.WriteLine("Kakao");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;
            }

            Console.ReadKey();
        }
    }
}
