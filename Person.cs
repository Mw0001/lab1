namespace ClassLibraryLab1TIMP
{
    public class Person
    {
        string name;
        int age;
        string rase;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.rase = rase;
        }
        public void Print() => Console.WriteLine($"Name: {name}, Age is {age}, He is {rase}");
    }
}