// See https://aka.ms/new-console-template for more information
string[] coffeTypes;
float[] coffeValues;
string info;

coffeTypes = new string[] {"Expresso", "Largo"};
coffeValues = new float[] {1.4f, 1.5f};

for(int i = 0;i < coffeTypes.Length; i++)
{
    info = $"Coffe type: {coffeTypes[i]} \nPrice: {coffeValues[i]}";
    Console.WriteLine(info);
}