namespace Sterk_Typing_og_Verdityper;

class Program
{
    static void Main(string[] args)
    {
        // - I C# må alle variabler spesifiseres med en startverdi som sier noe om verditypen.
        //   Vi kan deklarere en variabel med var i C#, men det er nødt til
        //   å følges opp med et likhetstegn og noe som gjør at kompilatoren forstår verditypen på egenhånd.
    
        // - Oppgave 1: 
        // Lag 8 variabler og gi dem en verdi.
        // Det skal være en variabel per hver type: int, long, float, decimal, double, string, char og bool.

        // int number = 0;
        // long longNumber = 7500000;
        // float numberFloat = 3.14f;
        // decimal numberDecimal = 3.14M;
        // double numberDouble = 3.14D;
        // string myText = "Hello World";
        // char userInput = ' ';
        // bool userInputBool = true;
        
        
        // - Oppgave 2: 

        // Lag en konsoll-applikasjon som lager 3 variabler. De kan hete a, b og sum. 
        // - a skal være en int. 
        // - b skal være en decimal. 
        // 
        // Verdiene variablene skal ha er: 
        // 
        // - a = 5;
        // - b = 3;
        // - sum = a + b;
        // Hva slags type variabel må sum være?
        
        // int a = 5;
        // decimal b = 10.5M;
        // decimal sum = a + b;     // Sum må være decimal pga når du legger sammen en int og en decimal,
                                    // blir resultatet automatisk behandlet som decimal for å bevare desimalpresisjon
        // Console.WriteLine(sum);




    }
}