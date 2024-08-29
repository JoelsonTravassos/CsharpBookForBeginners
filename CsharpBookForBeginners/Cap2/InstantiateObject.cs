using static System.Console;

namespace BankingSystem
{
    public class InstantiateObject
    {
        public static void Main(string[] args)
        {
            var objectManager = new Manager();

            objectManager.Name = "Jhon";
            objectManager.Age = 25;
            objectManager.Cpf = "123.456.789-10";

            WriteLine("His/Her name is: " + objectManager.Name);
            WriteLine("His/Her age is: " + objectManager.Age);
            WriteLine("His/Her cpf is: " + objectManager.Cpf);
        }
    }
}