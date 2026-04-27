using System.Data.Common;

class Program
{
    
    //static int age = 20;

    //static int Age = 30;
    public static void Main(string[] args)
    {
        //LessonOne();
        //VariablesOperationExamples();
        //Console.WriteLine("Hello, World!");
        //ifExample();
        //Console.WriteLine("age: " + age);
        //Console.WriteLine("Age: " + Age);
        EserciziIf();
    }
    public static void LessonOne()
    {
        //Console.Write("Ciao, inserisci il tuo nome: ");
        //string? name = Console.ReadLine();
        //Console.WriteLine($"Il tuo nome è {name}? che brutto nome.");

        //Console.Write("inserisci n1: ");
        //string? n1 =Console.ReadLine();

        //Console.Write("inserisci n2: ");
        //string? n2 = Console.ReadLine();

        //int number1 = int.Parse(n1);
        //int number2 = int.Parse(n2);

        //Console.WriteLine($"Somma number1 + number2= {number1 + number2}");
    }

    public static void VariablesOperationExamples()

    {
        //Console.WriteLine($"Inserisci due numeri: ");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine($"\n-----Operazioni Aritmetiche\n");
        //int sum = a + b;
        //Console.WriteLine($"Somma di a e b = {sum}");
        //int diff = a - b;
        //Console.WriteLine($"Sottrazione di a e b = {diff}");
        //double div = a / b;
        //Console.WriteLine($"Divisione di a e b = {div}");
        //int prod = a * b;
        //Console.WriteLine($"Prodotto di a e b = {prod}");
        //int resto = a % b;
        //Console.WriteLine($"resto di a e b = {resto}");
    }

    //public static void ifExample()
    /*{
        Console.Write($"Inserisci primo numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write($"Inserisci secondo numero: ");
        int b = int.Parse(Console.ReadLine());

        if(a < b && a < 15)
        {
            Console.Write($"{a} è minore di {b}");
            
        }
        
        if(a > b || a > 40)
        {
            Console.Write($"{a} è maggiore di {b}");
            
        }

        if(!(a == b))
        {
            Console.Write($" no. tiè. ");
            
        }
    }*/

    public static void EserciziIf()
    {
       // Console.Write($"Per favore inserisci la tuà Età: ");
        //int Age = int.Parse(Console.ReadLine());
        
        //if(Age >= 18 && Age <= 29)
       // {
       //     Console.Write($"l'utente è maggiorenne ");
        //}

        //else if(Age < 18)
       // {
        //    Console.Write($"l'utente è minorenne ");
        //}

        //if(Age >= 30 )
        //{
       //     Console.Write($"l'utente è molto vecchio. Vuoi del Voltaren? ");
        //}
    
    Console.Write($"Mi scusi questo quanto viene?");
    float Prezzo = float.Parse(Console.ReadLine());
    int Sconto = 10;
    
    if(Prezzo >= 100)
        {
            
            Console.WriteLine($"Oh è sopra i 100$! allora ha diritto allo sconto, questo è il resto {Prezzo - (Prezzo * Sconto / 100)}");
            
        } 
    

    }
}