int [] sayilar = new int[6];
int [] kasaSayiları = new int[6];
int tahmin = 0;

Console.WriteLine("Lütfen 6 adet sayı giriniz");
Random rnd = new Random();

for (int i = 0; i < 6; i++)
{
    kasaSayiları[i] = rnd.Next(1,60);
    Console.Write("{0} , Sayıyı Giriniz :", (i + i));
    sayilar[i] = int.Parse(Console.ReadLine()!);
}
foreach (var sayi in sayilar)
{
    foreach (var kasasayi in kasaSayiları)
    {
        tahmin = sayi == kasasayi ? tahmin++ : tahmin;
    }
}
Console.WriteLine("{0} adet doğru tahminde bulundunuz!", tahmin);
Console.WriteLine("Random Sayılar:");
for (int i = 0; i < kasaSayiları.Length; i++)
{
    Console.Write("{0} ", kasaSayiları[i]);
}
    

