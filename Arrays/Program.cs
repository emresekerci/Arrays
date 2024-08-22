// 1. Adım: 10 adet tam sayı verisi alacak bir dizi tanımlanması
int[] sayilar = new int[10];

// 2. Adım: Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazdırma
Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write("Sayı {0}: ", i + 1);
    sayilar[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nGirdiğiniz sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// 3. Adım: Bu diziye kullanıcıdan alınan yeni bir değeri eklemek (11. eleman olarak)
Console.WriteLine("\nYeni bir tam sayı giriniz (11. eleman):");
int yeniSayi = int.Parse(Console.ReadLine());

int[] yeniSayilar = new int[sayilar.Length + 1];
for (int i = 0; i < sayilar.Length; i++)
{
    yeniSayilar[i] = sayilar[i];
}
yeniSayilar[yeniSayilar.Length - 1] = yeniSayi;

// 4. Adım: Bu diziyi büyükten küçüğe ekrana yazdırma
Array.Sort(yeniSayilar);
Array.Reverse(yeniSayilar);

Console.WriteLine("\nBüyükten küçüğe sıralanmış sayı listesi:");
foreach (int sayi in yeniSayilar)
{
    Console.WriteLine(sayi);
}