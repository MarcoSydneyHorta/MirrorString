using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string ent = Console.ReadLine();
            string mirr = Mirror(ent);
            Console.WriteLine("The mirror string is: " + mirr);
        }
        static public string Mirror(string ent)
        {

            int tam = ent.Length;
            int ini = 0;
            string[] outp = new string[tam];
            int taal = tam; // if is not a valid string

            if (!(ent[0] >= 'a' && ent[0] <= 'z' || ent[0] >= 'A' && ent[0] <= 'Z'))
            {
                outp[0] = ent[0].ToString();
                ini = 1;
                taal--;
            }
            if (!(ent[tam - 1] >= 'a' && ent[tam - 1] <= 'z' || ent[tam - 1] >= 'A' && ent[tam - 1] <= 'Z'))
            {
                outp[tam - 1] = ent[tam - 1].ToString();
                taal--;
            }

            for (int i = ini; i < tam; i++)
            {
                if (ent[i] >= 'a' && ent[i] <= 'z' || ent[i] >= 'A' && ent[i] <= 'Z')
                {
                    if (tam != taal)
                    {
                        outp[i] = ent[taal - i - 1].ToString();  // Change to opposite position                
                    }
                    else
                    {
                        outp[i] = ent[tam - i - 1].ToString();  // Change to opposite position
                    }
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
