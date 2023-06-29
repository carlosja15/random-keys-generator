using System.Security.Cryptography;

var keySize = ReadKeySize();
var secretKey = GenerateRandomKey(keySize);

Console.WriteLine(secretKey);

int ReadKeySize()
{
    Console.WriteLine("Ingrese el tamaño de la clave en bytes: ");
    string input = Console.ReadLine();
    int keySize;
    while (!int.TryParse(input, out keySize))
    {
        Console.WriteLine("Tamaño de la clave no válido. Intente nuevamente");Console.Write("Ingrese el tamaño de la clave en bytes: ");
        input = Console.ReadLine();
    }
    
    return keySize;
}

string GenerateRandomKey(int keySize)
{
    byte[] buffer = new byte[keySize];
    using var rng = RandomNumberGenerator.Create();
    rng.GetBytes(buffer);
    return Convert.ToBase64String(buffer);
}