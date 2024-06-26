using POO_UN03_01;

string[] emails  = new string[]{"joao@gmail.com","maria@gmail.com","jose@gmail.com"};
Cliente cliente1 = new Cliente(1, "João", 1200, emails);
Cliente cliente2 = new Cliente(2,"Maria",6000, emails); 

Console.WriteLine("Cliente1: " + cliente1.Nome + cliente1.PromoverCliente(6000));
Console.WriteLine("Cliente2: " + cliente2.Nome);
Console.WriteLine("Lista de emails " + cliente1.ListaEmails());
Console.ReadKey();


