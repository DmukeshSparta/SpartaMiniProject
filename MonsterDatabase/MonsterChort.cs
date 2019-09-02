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
        List<Monster> listofmonster = new List<Monster>();
        

        public void addStudent()
        {

        }

        public void ListStudent()
        {
            foreach(Monster An in listofmonster)
            {

            }
        }


        public void ExternalStudent()
        {
            string line;
            StreamReader sr = new StreamReader("monsterdatabase.txt");
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    listofmonster.Add(new Monster(words[0], words[1], words[2], words[3], words[4], words[5]));
                }
            sr.Close();
            }
           
        }
    }
}
