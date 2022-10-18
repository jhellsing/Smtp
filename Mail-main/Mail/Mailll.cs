using System;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace Mail
{
    public class Mailll
    {
        int code;
        public void Pochta()
        {
            Console.WriteLine("Отправка кода...");
            Thread.Sleep(5000);
            Otpravit();
            Proverka();
        }
        private void Otpravit()
        {
            Console.Clear();
            Random random = new Random();
            MailAddress from = new MailAddress("Test18102022@yandex.ru", "Военкомат");
            MailAddress to = new MailAddress("Test18102022@yandex.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Код доступа";
            code = random.Next(100000000, 999999999);
            m.Body = "Привет дружище, держи твой код, введи его в консоль и будешь молодец &#128658;" + code.ToString();
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("Test18102022@yandex.ru", "pewgaiebzowxgxja");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
        private void Proverka()
        {
            while (true)
            {
                Console.Write("Введите код: ");
                if (Console.ReadLine() == code.ToString())
                {
                    Console.WriteLine("Авторизация успешна");
                    Lucky();
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный код");
                    Otpravit();
                }
            }
            Console.Read();
        }
        private void Lucky()
        {
            Random random = new Random();
            MailAddress from = new MailAddress("Test18102022@yandex.ru", "Военкомат");
            MailAddress to = new MailAddress("Test18102022@yandex.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Вы прошли проверку";
            m.Body = "Ты молодец!!! &#128526;";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("Test18102022@yandex.ru", "pewgaiebzowxgxja");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
