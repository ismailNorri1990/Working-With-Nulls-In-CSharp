using System;
using System.Dynamic;

namespace CS8NullBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message {
                Text = "This is a text",
                From = null 
            };

            Console.WriteLine(message.From ?? "No From Here");
            Console.WriteLine(message.Text);
            Console.WriteLine(message.ToUpperFrom());

            Console.ReadLine();
        }
    }
}

