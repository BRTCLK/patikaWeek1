int correctAnswers = 0; // Doğru cevap sayısını tutar

Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("a) Lama   b) Deve");
Console.Write("Cevabınız: ");
string answer1 = Console.ReadLine().ToLower();

if (answer1 == "a")
{
    correctAnswers++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

Console.WriteLine();

Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine("a) Venüs   b) Mars");
Console.Write("Cevabınız: ");
string answer2 = Console.ReadLine().ToLower();

if (answer2 == "b")
{
    correctAnswers++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

Console.WriteLine();

// İlk iki sorudan sonra büyük ödül şansı bitti mi kontrol edelim
if (correctAnswers < 1)
{
    // İlk 2 sorudan hiç doğru yapmadıysa, 3. soruyu sormaya gerek yok
    Console.WriteLine("Büyük ödül kazanma şansınız kalmadı!");
}
else
{
    // Büyük ödül şansı devam ediyor, 3. soruyu soralım
    Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
    Console.WriteLine("a) 7   b) 12");
    Console.Write("Cevabınız: ");
    string answer3 = Console.ReadLine().ToLower();

    if (answer3 == "b")
    {
        correctAnswers++;
        Console.WriteLine("Doğru cevap!");
    }
    else
    {
        Console.WriteLine("Yanlış cevap!");
    }
}

Console.WriteLine();

// Sonuç
if (correctAnswers >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else
{
    Console.WriteLine("Maalesef büyük ödülü kazanamadınız. Daha şanslı bir dahaki sefere!");
}
