Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");
Console.WriteLine();

Console.Write("Hangi meyveyi satın almak istiyorsunuz? (Elma/Armut/Çilek/Muz/Diğer): ");
string fruit = Console.ReadLine().ToLower(); // Büyük-küçük harf farkını kaldırdık
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



//if (fruit == "elma")
//{
//    price = 2;
//}
//else if (fruit == "armut")
//{
//    price = 3;
//}
//else if (fruit == "çilek")
//{
//    price = 2;
//}
//else if (fruit == "muz")
//{
//    price = 3;
//}

//else
//{
//    price = 4; // Bilinmeyen tüm meyveler için diğer fiyatı
//}

//Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {price} TL");



// Bu tür bir problemde switch-case kullanmak daha doğrudur.
// Çünkü:
//  => Her meyve bir sabit değer ile kontrol ediliyor (ör: elma, armut gibi).
//  => switch-case yapısı, çok sayıda sabit değeri kontrol ederken if-else yapısına göre daha okunabilir ve bakımı kolaydır.
//  => Derleyiciler switch yapısını daha verimli (bazı durumlarda hızlı) çalıştırabilir.
// if-else daha esnektir, ama sabit karşılaştırmalarda switch daha uygundur.
