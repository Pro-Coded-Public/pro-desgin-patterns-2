using Singleton;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Singleton Desing Pattern Example\n\n");

        //CallPrintSpooler();
        CallPrintSpoolerThreadSafe();
    }


    private static void CallPrintSpooler()
    {
        // Attempt to create multiple instances of PrintSpoolerBad
        var spooler1 = PrintSpooler.GetInstance();
        var spooler2 = PrintSpooler.GetInstance();

        spooler1.Print("Document 1");
        spooler2.Print("Document 2");

        if (spooler1 == spooler2)
        {
            Console.WriteLine("Both spooler1 and spooler2 are the same instance.");
        }
        else
        {
            Console.WriteLine("spooler1 and spooler2 are different instances.");
        }

        Console.ReadLine();
    }

    private static void CallPrintSpoolerThreadSafe()
    {
        Task.Run(() => PrintWithThreadSafeSpooler("Document 1"));
        Task.Run(() => PrintWithThreadSafeSpooler("Document 2"));

        Console.ReadLine();
    }

    private static void PrintWithThreadSafeSpooler(string document)
    {
        var spooler = PrintSpoolerThreadSafe.GetInstance();

        spooler.Print(document);
    }
}