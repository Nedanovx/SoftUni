using System.Reflection;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            foreach(var method in type.GetMethods((BindingFlags)60))
            {
                AuthorAttribute[] authorAttribute = method.GetCustomAttributes<AuthorAttribute>().ToArray();
                foreach(var attribute in authorAttribute)
                {
                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}
