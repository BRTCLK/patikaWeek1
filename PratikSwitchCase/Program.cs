Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");
Console.WriteLine();

Console.Write("Hangi meyveyi satın almak istiyorsunuz? (Elma/Armut/Çilek/Muz/Diğer)");
string fruit = Console.ReadLine().ToLower(); // Make comparison case-insensitive

int price;

switch (fruit)
{
    case "apple":
        price = 2;
        break;
    case "pear":
        price = 3;
        break;
    case "strawberry":
        price = 2;
        break;
    case "banana":
        price = 3;
        break;
    default:
        price = 4;
        break;
}

Console.WriteLine($"Seçilen meyvenin fiyatı: {price} TL");

// Bu tür bir problemde switch-case kullanmak daha doğrudur.
// Çünkü:
// 1️⃣ Her meyve bir sabit değer ile kontrol ediliyor (ör: elma, armut gibi).
// 2️⃣ switch-case yapısı, çok sayıda sabit değeri kontrol ederken if-else yapısına göre daha okunabilir ve bakımı kolaydır.
// 3️⃣ Derleyiciler switch yapısını daha verimli (bazı durumlarda hızlı) çalıştırabilir.
// if-else daha esnektir, ama sabit karşılaştırmalarda switch daha uygundur.
