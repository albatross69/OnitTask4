using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnitTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> someData = new Dictionary<string, List<string>>();
            someData["Петр Иванович"] = new List<string>();
            someData["Петр Иванович"].Add("Анна Ивановна");
            someData["Петр Иванович"].Add("Максим Иванович");
            someData["Максим Иванович"] = new List<string>();
            someData["Максим Иванович"].Add("Коля");
            someData["Максим Иванович"].Add("Миша");
            someData["Максим Иванович"].Add("Николай Максимович");
            someData["Анна Ивановна"] = new List<string>();
            someData["Анна Ивановна"].Add("Артем");
            someData["Николай Максимович"] = new List<string>();
            someData["Николай Максимович"].Add("Катя");
            someData["Николай Максимович"].Add("Маша");
            someData["Анна Ивановна"].Add("Саша");
            foreach (string child in someData["Петр Иванович"])
            {
                if (HasAChile(child, someData))
                {
                    foreach (string anotherchild in someData[child])
                    {
                        if (HasAChile(anotherchild, someData))
                        {
                            foreach (string lastchild in someData[anotherchild])
                            {
                                Console.WriteLine(lastchild);
                            }
                        }
                        else
                        {
                            Console.WriteLine(anotherchild);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
        private static bool HasAChile(string name, Dictionary<string, List<string>> someData)
        {
            if (someData.ContainsKey(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

