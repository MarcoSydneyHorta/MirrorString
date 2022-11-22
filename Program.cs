using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string ent = Console.ReadLine();
            string mirr = Mirror(ent);
            Console.WriteLine("The mirror string is: " + mirr);
        }
        static public string Mirror(string ent)
        {

            int tam = ent.Length;
            string[] outp = new string[tam];
            for (int i = 0; i < tam; i++)
            {
                if (ent[i] >= 'a' && ent[i] <= 'z' || ent[i] >= 'A' && ent[i] <= 'Z')
                {
                    outp[i] = ent[tam - i - 1].ToString();  // Change to opposite position
                }
                else
                {
                    outp[i] = ent[i].ToString();    // Maintain the same position
                }
            }
            return string.Join("", outp);
        }
    }
}
