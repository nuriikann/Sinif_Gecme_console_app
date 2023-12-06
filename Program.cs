// See https://aka.ms/new-console-template for more information

//sınıf geçme hesaplama


Console.WriteLine("Lütfen vize notunuzu giriniz: ");
double vize = double.Parse(Console.ReadLine());
Console.WriteLine("Lütfen final notunuzu giriniz: ");
double final = double.Parse(Console.ReadLine());

double vizeYuzde = vize * 0.4;
double finalYuzde = final * 0.6;

double ortalama = vizeYuzde + finalYuzde;

if (ortalama > 60)
{
    Console.WriteLine("Dersi geçtiniz");
    Console.WriteLine($"Ders ortalamanız{ortalama}");
}
else if (ortalama == 60)
{
    Console.WriteLine($"Ders ortalamanız{ortalama}");
    Console.WriteLine("Dersi geçtiniz");
}
else
{
    Console.WriteLine($"Ders ortalamanız{ortalama}");
    Console.WriteLine("Dersi geçemediniz!");
    return;
}
