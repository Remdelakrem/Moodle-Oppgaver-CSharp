namespace Datatyper;

class Program
{
    static void Main(string[] args)
    {
        int myNum = 5;                  // - Integer (whole number)
        
        double myDoubleNum = 5.99D;     // - Floating point number
        
        long myLongNum = 15000000000L;  // - Kan lagre lange tall fra og til
                                        // -9223372036854775808 to 9223372036854775807.
                                        
        char myLetter = 'D';            // - Character
        
        bool myBool = true;             // - Boolean
        
        string myText = "Hello";        // - String
        
        float f1 = 35e3F;               // - A floating point number can also be a scientific
        double d1 = 12E4D;              // number with an "e" to indicate the power of 10:

        var input = Console.ReadLine(); // - Variabel. Med denne "slipper" du å skrive datatypen direkte,
                                               // men variablen vil få datatype i forhold til hvilken verdi du setter.
        
        Console.WriteLine(myNum);
    }
}