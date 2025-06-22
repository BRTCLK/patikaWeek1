using System.Text;

Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz: ");

Console.Write("T.C. Kimlik Numarası: ");
string id = Console.ReadLine();

Console.Write("Adı: ");
string name = Console.ReadLine();

Console.Write("Soyadı: ");
string lastname = Console.ReadLine();

Console.Write("Telefon Numrası: ");
string phoneNum = Console.ReadLine();
// Telefon numarası string veri tipi ile saklanmıştır çünkü başında sıfır olabilir ve matematiksel işlem yapılmaz.

Console.Write("Yaş: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk Aldığı Ürün Fiyatı: ");
double firstProduct = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci Aldığı Ürün Fiyatı: ");
double secondProduct = Convert.ToDouble(Console.ReadLine());
// Son aldığı ürün fiyatı double veri tipi ile saklanmıştır çünkü fiyatlar küsuratlı olabilir.

Console.WriteLine("-----------------------------------------------");

// Kullanıcı kaydı oluşturuldu mesajı
Console.WriteLine($"{id} Tc numaralı {name} {lastname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{phoneNum} telefon numarasına bildirim mesajı gönderilmiştir.");

// Toplam harcama ve patika puan hesaplama
double totalSpending = firstProduct + secondProduct;
double patikaPoint = totalSpending * 0.10;

Console.WriteLine($"{totalSpending} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {patikaPoint:F2} TL'dir.");