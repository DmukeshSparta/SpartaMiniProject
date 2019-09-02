using System;

namespace MonsterDatabase
{
    class MonsterStudent
    {
        private int Id;
        private string eyes;
        private string hair;
        private int scarylevel;
        private string specialablitiy;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
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

