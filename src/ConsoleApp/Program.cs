using System.Diagnostics;

Stopwatch stopwatch = new();

stopwatch.Start();

const string filePath = "./largeFile.txt";

const char character = 'A';

int frequency = CharacterFrequencyUseCase.Execute(filePath, character);

stopwatch.Stop();

Console.WriteLine($"Total de vezes que se registrou o caractere {character}: {frequency}");

Console.WriteLine($"Arquivo processado em: {stopwatch.ElapsedMilliseconds} ms");