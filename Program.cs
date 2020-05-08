using System;

namespace env_for_kube
{
    class Program
    {
        static void Main(string[] args)
        {
            string envvar = "";
            int numToInsert;
            string spaces = "";
            int end=1;
            do
            {
                Console.Write("Enter Enviroment variable: ");
                envvar = Console.ReadLine();
                Console.Write("Enter the space count: ");
                numToInsert = int.Parse(Console.ReadLine());


                string[] spacer = envvar.Split(' ');

                for (int i = 0; i < numToInsert; i++)
                {
                    spaces += " ";
                }

                foreach (var temp in spacer)
                {
                    string[] eaualr = temp.Split('=');
                    Console.WriteLine(spaces + "- name: " + eaualr[0]);
                    if (eaualr.Length == 2)
                    {
                        Console.WriteLine(spaces + "  value: " + eaualr[1]);
                    }
                    else
                    {
                        Console.WriteLine(spaces + "  value: ");
                    }

                }
                Console.WriteLine("Enter 5 for Exit");
                end = int.Parse(Console.ReadLine());
            } while (end != 5);
        }
    }
}
