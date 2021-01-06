using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR5_상속_Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailMessage em = new EmailMessage("sunjae@naver.com");
            em.ToWhom = "홍길동";
            em.Message = "메일보냅니다.";
            em.Send();
        }
    }
}
