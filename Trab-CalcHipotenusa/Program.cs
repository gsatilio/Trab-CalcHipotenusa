//4 - faça um programa que leia dois valores de cateto e calcule a hipotenuza

double cat1 = 0, cat2 = 0, hipotenusa = 0;

while (cat1 <= 0)
{
    Console.WriteLine("Informe o valor do cateto A:");
    cat1 = double.Parse(Console.ReadLine());
}

while (cat2 <= 0)
{
    Console.WriteLine("Informe o valor do cateto B:");
    cat2 = double.Parse(Console.ReadLine());
}

hipotenusa = Math.Sqrt((cat1 * cat1) + (cat2 * cat2));

Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");

Console.ReadKey();

