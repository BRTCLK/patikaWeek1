Console.Write("Lütfen bir tam sayı giriniz: ");

int num = Convert.ToInt32(Console.ReadLine());
// 10 ile karşılaştırma
if (num > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}

else if (num == 10)
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}

else
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
// Çift / Tek kontrolü
if (num % 2 == 0)
{
    Console.WriteLine( "Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tekttir.");
}