using Week10Lab.Models.Entities;

namespace Week10Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MMABooksContext context = new MMABooksContext();
            foreach (var customer in context.Customers.ToList())
            {
                Console.WriteLine($"{customer.Name}");
            }
        }
    }
}
