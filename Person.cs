namespace ClassLibraryLab1TIMP
{
    public class Person
    {
        string name;
        int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.age = age;
        }
        public void Print() => Console.WriteLine($"Name: {name}, Age is {age}");
    }
}