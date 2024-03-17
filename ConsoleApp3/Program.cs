using System;

public class SendMessage
{
    public delegate void MessageSender(string message);

    public MessageSender Sender { get; set; }

    public void Message(string message)
    {
        Sender?.Invoke(message);
    }
}

class Program
{
    static void MyMessage(string message)
    {
        Console.WriteLine($"gggggggg {message}");
    }

    static void Main(string[] args)
    {
        SendMessage sender = new SendMessage();

        sender.Sender = MyMessage;

        sender.Sender?.Invoke("some text");

        sender.Sender = (message) =>
        {
            Console.WriteLine($"fffffff {message}");
        };

        sender.Message("text2");
        Console.ReadLine();
    }
}