using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonsterDatabase
{
    class MonsterChort
    {
        string subject;
        DateTime startdate;

        public void addStudent()
        {

        }

        public void ListStudent()
        {

        }


        public void ExternalStudent()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("monsterdatabase.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
