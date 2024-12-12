// See https://aka.ms/new-console-template for more information
/* 
implementare un ciclo infinito 
-acquisisci dal terminale  un input
-se l'input  e uguale a "no" esci dal loop
-visualizza una serie di n righe  e per ogni riga un numero crescente di * 
 */
int loop;

while (true)
{
    Console.Write("Inserisci un Numero di righe 0ppure un valore diverso da un intero se vuoi fare terminare il loop:");

    string input = Console.ReadLine();

    try
    {
        loop = Convert.ToInt32(input);

        for (int i = 0; i <= loop; i++)
        {
            for (int e = 1; e <= i; e++)
            {
                Console.Write("* ");
            }
            //tiene conto di ogni riga che va a capo
            Console.Write("\n");
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Loop terminato");
        break;

    }

}

