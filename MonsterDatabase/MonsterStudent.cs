using System;

namespace MonsterDatabase
{
    class MonsterStudent
    {
        public int Id;
        public string name;
        public string eyes;
        public string hair;
        public int scarylevel;
        public string specialablitiy;

        public MonsterStudent(int idAttribute, string nameAttribute, string eyeAttribute, string hairAttribute,
           int scarylevelAttribute, string speicalablitiyAttribute)
        {
            this.Id = idAttribute;
            this.name = nameAttribute;
            this.eyes = eyeAttribute;
            this.hair = hairAttribute;
            this.scarylevel = scarylevelAttribute;
            this.specialablitiy = speicalablitiyAttribute;
        }

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public String SpecialAblitiy
        {
            get { return specialablitiy; }
            set { specialablitiy = value; }
        }
    }
}

