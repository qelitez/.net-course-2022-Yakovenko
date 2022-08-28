namespace Models
{
    public class Person
    {
        
        private string name = "Введите имя";
        private DateTime birthDate;
        private int passNumber;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int PassNumber
        {
            get { return passNumber; }
            set { passNumber = value; }
        }

    }
}