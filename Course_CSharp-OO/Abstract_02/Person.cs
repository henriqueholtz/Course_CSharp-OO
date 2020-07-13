namespace Abstract_02
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
        public Person(string name, double anualIncome)
        {
            Name = Name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
        public abstract string ToString();
    }
}
