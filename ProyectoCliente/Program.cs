namespace ProyectoCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            // customer.CompleteName = "Ainhoa";
            // Console.WriteLine(customer.CompleteName);
            Console.WriteLine(customer.Name);
            Customer customer2 = new Customer("Ainhoa", "Ortega", "Lopez", 165, 45);
            customer2.CompleteName = "Pepe Ortega Urbano";
            customer.Name = "Olga";
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer2.Name);
            Console.WriteLine(customer2.CalculateIMC);
            Console.WriteLine(customer2.CompleteName);
            Console.WriteLine(customer2.CalculateIMC);
            Console.WriteLine(customer2.Level);
            
            Console.WriteLine(customer2);

            Console.WriteLine(customer2 == customer ? "Son iguales" : "Son distintos");

            Console.WriteLine(customer2 == 16.5f ? "Son iguales" : "Distintos");
        }
    }
}