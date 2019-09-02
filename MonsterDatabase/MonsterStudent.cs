using System;

namespace MonsterDatabase
{

    class MonsterStudent
    {
        private int Id;
        private string name;
        private string eyes;
        private string hair;
        private int scarylevel;
        private string specialablitiy;

        public MonsterStudent (int idAttribute, string nameAttribute, string eyeAttribute, string hairAttribute, 
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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Eye
        {
            get { return eyes; }
            set { eyes = value; }
        }
        public string Hair
        {
            get { return hair; }
            set { hair = value; }
        }
        public int ScaryLevel
        {
            get { return scarylevel; }
            set { scarylevel = value; }
        }
        public String SpecialAblitiy
        {
            get { return specialablitiy; }
            set { specialablitiy = value; }
        }
    }
}

