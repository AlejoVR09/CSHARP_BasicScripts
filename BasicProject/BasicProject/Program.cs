// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

string[] users = new string[10] {"Ale", "a", "b", "c", "d", "e", "f", "g", "h", ""};
string userName;
string Bandera;
int index;
int indexUser = 9;

Console.WriteLine("Bienvenido al restaurante");
while (indexUser < 10)
{
    Console.WriteLine("Es usted un usuario registrado? Y si, N no");
    Bandera = Console.ReadLine();
    Bandera = Bandera.ToLower();
    switch (Bandera)
    {
        case "y":
            Console.WriteLine("Copie su nombre:");
            userName = Console.ReadLine();
            index = Array.IndexOf(users, userName);
            if (index == -1)
            {
                Console.WriteLine("Registrese");
            }
            else
            {
                Console.WriteLine($"Bienvenido {userName} al restaurante");
            }
            break;
        case "n":
            Console.WriteLine("Registrese");
            Console.WriteLine("Copie su nombre: ");
            userName = Console.ReadLine();
            users[indexUser] = userName;
            indexUser++;
            break;
        default:
            Console.WriteLine("Seleccione una opciona valida");
            break;
    }
}
foreach (string i in users)
{
    Console.WriteLine(i);
}