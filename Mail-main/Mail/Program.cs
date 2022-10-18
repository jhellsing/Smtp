using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Mailll mailll = new Mailll();
            mailll.Pochta();
        }
    }
}
