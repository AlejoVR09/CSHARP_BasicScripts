// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> tacosList = new List<string>();

tacosList.Add("Tacos al pastor");
tacosList.Add("Tacos de cochinilla");
tacosList.Add("Tacos solos");

for(int i = 0;i < tacosList.Count; i++)
{
    Console.WriteLine(tacosList[i]);
}