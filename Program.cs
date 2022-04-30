// See https://aka.ms/new-console-template for more information
// EKrandan girilen sayiya kadar olan tek sayılarını ekrana yazdır.
Console.WriteLine("Lütfen Bi Sayi Giriniz:");
int sayac = int.Parse(Console.ReadLine());

for (int i = 0; i <= sayac; i++)
{
if (i%2 == 1)
Console.WriteLine(i);
}

// 1 ile 1000 arasındaki tek ve çift sayilarin kendi içlerinde toplamlarini ekrana yazdir.
int TekToplam = 0;
int CiftToplam =  0;
for (int i = 1; i <= 1000; i++)
{
    if(i%2 == 1)
    TekToplam += i; // TekToplam = TekToplam + i;
    else
    CiftToplam += i;
}
Console.WriteLine("Tek Toplam" + TekToplam);
Console.WriteLine("Çift Toplam" + CiftToplam);

for (int i = 1; i <10; i++)
{
 if (i ==4)
 break;
 Console.WriteLine(i);
}
for (int i = 1; i < 10; i++)
{
    if(i==4)
    continue;
    Console.WriteLine(i);
}
 
