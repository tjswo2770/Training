using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TR5_상속_Inheritance_
{
    //class MessageBase
    //{
    //    protected Guid id = Guid.NewGuid();
    //    public string ToWhom { get; set; }      //누구에게 보내는지
    //    public string Message { get; set; }     //메세지


    //    public abstract void Send();            //추상메서드 파생클래스에서 메서드 구현해야함 ---> 하나이상의 추상메서드를 가지고 있으면 추상클래스


    //    //public virtual void Send()
    //    //{
    //    //    Console.WriteLine($"Send Message to {ToWhom}:");
    //    //    Console.WriteLine($"{Message}");
    //    //}

    //    protected void DebugMessageInfo()
    //    {
    //        Debug.WriteLine("Message Id: {0}", id);
    //        Debug.WriteLine("To: {0}", ToWhom);
    //        Debug.WriteLine("Message:{0}", Message);
    //    }
    //}

    //class EmailMessage : MessageBase        //파생클래스 : 기반클래스(baseclass)
    //{
    //    public string Email { get; set; }

    //    public EmailMessage(string email)
    //    {
    //        Email = email;
    //    }

    //    public override void Send()
    //    {
    //        MailMessage msg = new MailMessage("sender@ajou.ac.kr", this.Email, "제목", this.Message);//(보내는사람, 받는사람, 제목, 메세지)
    //        SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
    //        smtp.EnableSsl = true;
    //        smtp.Credentials = new NetworkCredential("sender@ajou.ac.kr", "password");
    //        smtp.Send(msg);

    //    }
    //}

    //class SMSMessage : MessageBase
    //{
    //    public string PhoneNumber { get; set; }

    //    public override void Send()
    //    {
    //        //...
    //    }
    //}

    //●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●

    abstract class MessageBase                  //추상클래스, sealed를 작성하면 파생클래스를 만들 수 없다.
    {
        protected Guid id = Guid.NewGuid();
        public string ToWhom { get; set; }      //누구에게 보내는지
        public string Message { get; set; }     //메세지


        public abstract void Send();            //추상메서드 파생클래스에서 메서드 구현해야함 ---> 하나이상의 추상메서드를 가지고 있으면 추상클래스


        //public virtual void Send()
        //{
        //    Console.WriteLine($"Send Message to {ToWhom}:");
        //    Console.WriteLine($"{Message}");
        //}

        protected void DebugMessageInfo()
        {
            Debug.WriteLine("Message Id: {0}", id);
            Debug.WriteLine("To: {0}", ToWhom);
            Debug.WriteLine("Message:{0}", Message);
        }
    }

    class EmailMessage : MessageBase        //파생클래스 : 기반클래스(baseclass)
    {
        public string Email { get; set; }

        public EmailMessage(string email)
        {
            Email = email;
        }

        public override void Send()
        {
            MailMessage msg = new MailMessage("sender@ajou.ac.kr", this.Email, "제목", this.Message);//(보내는사람, 받는사람, 제목, 메세지)
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("sender@ajou.ac.kr", "password");
            smtp.Send(msg);

        }
    }

    class CompanyEmail : EmailMessage
    {
        public CompanyEmail(string email) : base(email)
        {
        }
    }

    class SMSMessage : MessageBase
    {
        public string PhoneNumber { get; set; }

        public override void Send()
        {
            //...
        }
    }
}
