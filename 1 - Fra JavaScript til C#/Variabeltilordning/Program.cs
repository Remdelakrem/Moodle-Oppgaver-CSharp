namespace Variabeltilordning;

class Program
{
    static void Main(string[] args)
    {
      // - Når vi skal skrive funksjoner er vi også nødt til å definere hva slags verdier metoden skal ta inn,
      //   og hva slags verdier metoden skal returnere. Det gjøres i metodesignaturen som sett under.
  
      // - Void bruker vi når den ikke skal returnere noe, eller bare kjøre igjennom. 
      //   Eksempel:
      //      public void DenneFunksjonenReturnererIngenting()
      //      {
      //          return;
      //      }
      
      
      // - Hvis det er en spesifikk datatype den skal returnere, så må det defineres slik:
      //   Eksempel:
      //      public int DenneFunksjonenReturnererEtHeltall()
      //      {
      //         int etTall = 5;
      //         return etTall;
      //      }
              
      //      public int DenneFunksjonenTarInnToTall(int input1, int input2)
      //      {	 
      //         return input1 + input2;          //her returneres summen av de to tallene sendt inn i metoden
      //      }

    //----------------------------------------------------------------------------------------------------------// 
      
    // - OPPGAVE 1:
    // - Lag en metode som tar inn og returnerer summen av to tall
    //  
    //   int tall1 = 5; 
    //   int tall2 = 10;
    //   Console.WriteLine($"{tall1} + {tall2} = {SumAvTall(tall1, tall2)}");
    //  }
    //          
    //   static int SumAvTall(int tall1, int tall2)
    //   {
    //       return tall1 + tall2;
    //   }
    //
    // - Svar fra AI, problemet er at jeg prøver å lage metoder inni Main().
    // - I C# kan man ikke definere metoder inni andre metoder.
    // - sumAvTall() og Run() må flyttes ut av Main, men fortsatt være inni Program-klassen.
    
    //----------------------------------------------------------------------------------------------------------//
    
        // - Oppgave 2:
        // Lag en metode som skal printe setningen "Denne metoden returnerer ingenting" til konsollen.
        // Denne metoden skal altså ikke returnere noe verdi ;)

        ReturnerIngenting();
    }
    
    private static void ReturnerIngenting()
    {
        Console.WriteLine("Metoden returnerer ingenting");
    }
    
}