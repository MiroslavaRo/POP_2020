using System;
using System.Runtime.InteropServices.ComTypes;

namespace POP_Class_work_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //task01();
            //task02();
            task03();
            

        }
        static void task01()
          { for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
          
         }
         
         
         static void task02 ()
          {
            int n = 9;
            int c = 9 / 2;
            for (int collumn = 0; collumn <= n; collumn++)
            {
                for (int j = 0; j < n; j++)
                {         //top half
                    if (collumn <= c)
                    {
                        //for the row
                        if(j>=c - collumn && j <= c + collumn)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    //bottom half
                    else
                    {
                        //for the row
                        if (j >= c + collumn - n+1 && j <= c - collumn + n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                   
                }
                Console.WriteLine();

            }


          
         }
        
         static void task03()
          {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            char[] reverse = new char[alphabet.Length];
            string a = new string (alphabet);
            string r = reverse.ToString();
            for(int i=0;i< alphabet.Length; i++)
            {
                reverse[i] = alphabet[alphabet.Length-1-i];
            }
            Console.WriteLine("Please, write a message which you want to be encrypted: ");
            string m = Console.ReadLine();            
            char[] rm =new char[m.Length];
            char[] reversemessage = new char[m.Length];
            char[] message = m.ToCharArray();
            for (int j = 0; j < message.Length; j++)
            { 
                if (char.IsLetter(message[j])) {

                    int index = a.IndexOf(IsUpp(message, j));
                    reversemessage[j] = char.ToUpper(reverse[index]);

                }
                else
                {
                    if (char.IsPunctuation(message[j]))
                    {
                        reversemessage[j] = message[j];
                    }
                    else
                    {
                        continue;
                    }
                }
                         
            }
            Console.WriteLine();
            foreach(char elem in reversemessage)
            {
                Console.Write(elem);
            }           
      
        }
       static char IsUpp(char[] message, int j)
        { char mes = new char();
            if (char.IsUpper(message[j]))
                {
                message[j] = char.ToLower(message[j]);
                mes = message[j];

                }
            else
                {
                mes = message[j];
            }
            
            return mes;
        }
      /* static char UppRev (char []reversemessage, int j, char []reverse, int index, char []message)
        {
            char mes2 = new char();
            if (char.IsUpper(message[j]))
            {                 
                mes2 = char.ToUpper(reverse[index]);
            }
            else
            {
                mes2 = reverse[index];
            }
            return mes2;
        }*/
    
         
         
        
    }
}
