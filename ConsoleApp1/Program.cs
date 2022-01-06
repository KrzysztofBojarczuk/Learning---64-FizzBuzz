// See https://aka.ms/new-console-template for more information


while (true)
{

    try
    {


        Console.WriteLine("Wpisz liczbę do której ma być wyliczna lista: ");
        int user = int.Parse(Console.ReadLine());

        for (int i = 0; i < user; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{i} FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i} Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
        Console.WriteLine("===");
        Console.WriteLine("Ciąg Fabicicnaego");
        int firstNumber = 0;
        int secondNumber = 1;
        for (int j = 2; j < user; j++)
        {
            int result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = result;
            Console.WriteLine(result);
        }
        Console.WriteLine("===");
        Console.WriteLine("Czy chesz zakończyć program? Jeśtli tak wpisz Tak/TAK Jesli nie wciśjnie dolwolny przycisk");
        string lol = Console.ReadLine();
        if (lol == "TAK" || lol == "Tak" || lol == "TAk" || lol == "tak")
        {
            break;
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }

}
