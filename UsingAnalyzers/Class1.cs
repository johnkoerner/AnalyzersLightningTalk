namespace UsingAnalyzers
{
    public class Person
    {
        public string Name; 

        public Person(string name)
        {
            Name = name;
        }
        public override bool Equals(object obj)
        {
            var comp = obj as Person;

            return Name.Equals(comp.Name);

        }
        public override int GetHashCode()
        {
                return Name.GetHashCode();
        }
    }
}
