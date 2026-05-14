namespace Input_og_Output;

class Program
{
    static private void Main(string[] args)
    {
        
        Console.WriteLine("Test av WriteLine!");       // - Printer ut tekst på en linje
        Console.WriteLine(3 + 3);                      // - Co.Wr kan også rekne sammen tall 
        
        Console.Write("Test av Write! ");                           // - Printer ut tekst etter hverandre
        Console.Write("Dette kommer på samme linje pga 'Write'.\n");// - \n Gjør at neste kommando kommer på neste linje. 
        
        // - Eksempel:
        Console.WriteLine("Enter username:");        
        string userName = Console.ReadLine();           // - Her lager vi en variabel 'userName', og lagrer input fra bruker.
        Console.WriteLine("Username is: " + userName);  // - her printes verdien av 'userName'.
        
        // - Eksempel:
        int number = 500;
        Console.WriteLine($"Tallet er: {number}"); // - Hvis det er en variabel eller en metode du skal
                                                   // printe ut i konsollen, minnes det litt som det vi skrev i JS:
        
       Console.ReadLine();  // - leser teksten (string) som du skriver inn i konsollen,
                            // det kan være alt fra en bokstav til flere linjer med tekst.

       Console.ReadKey();   // - venter på at du trykker på en tast. Denne er ofte brukt til å fungere
                            // som en kort pause før man får opp ny informasjon i konsollen. 
       
       Console.Read();      // - leser den neste karakteren du trykker,
                            // og returnerer dens "ascii value" - a.k.a. et tall.
        
       int numberUserInput = Console.Read(); // - Variabel for å lagre input (tall)
       
       var somthingUserInput = Console.ReadLine(); // - Her bruker vi var siden vi ikke vet om det er et tall
                                                          // eller en string som kommer inn
       
       Convert.ToInt32(numberUserInput); // - Konverterer dataen i userInput til å bli et heltall.
        
        
        
    }
}