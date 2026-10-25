sstring sayi; 
int b = 0;
do
{
    Console.WriteLine("bir sayı giriniz:");
    sayi = Console.ReadLine();
    if (!int.TryParse(sayi, out b))
    {
        Console.WriteLine("lütfen rakamla sayı giriniz");
    }
    else

        if (int.Parse(sayi) > 100 || int.Parse(sayi) < 1)
        {
            Console.WriteLine("100 ile 1 arasında sayılar giriniz");
        }
    
} while (!int.TryParse(sayi, out b) || int.Parse(sayi) > 100 || int.Parse(sayi) < 1);




int adet = 10;
int[] sayilar = new int[adet];  
Random a = new Random();
Console.WriteLine("rastgele verilen sayılar:");
for (int i = 0; i < adet; i++)
{
    sayilar[i] = a.Next(1, 100);
  
    Console.WriteLine(sayilar[i]);
    
}
int enb = sayilar[0];
int enk = sayilar[0];
int enksira = 1;
int enbsira = 1;

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] > enb)
    { 
        enb = sayilar[i];
        enbsira = i + 1;
    }
    if (sayilar[i] < enk)
    {
        enk = sayilar[i];
        enksira = i + 1;
    }
}
Console.WriteLine("Rastgele verilen sayıların en büyüğü:" + enb.ToString());
Console.WriteLine("sayının sırası:" + enbsira.ToString());
Console.WriteLine("Rastgele verilen sayıların en küçüğü:" + enk.ToString());
Console.WriteLine("sayının sırası:" + enksira.ToString());
int ciftler = 0;
int tekler = 0;
for (int i = 1; i < sayilar.Length; i++)
{ 
    if ((sayilar[i] % 2) < 1) 
    {
        
        ciftler++;
        

    }
    if ((sayilar[i] % 2) == 1)
    {
       
        tekler++;
       
    }
}
Console.WriteLine("tek sayılar:" + tekler.ToString());
Console.WriteLine("çift sayılar:" + ciftler.ToString());
int kucukler = 0;
int buyukler = 0;
Console.WriteLine("girilen sayıdan büyükler:");
foreach (int i in sayilar)
{
    
    if (i > b)
    {
        Console.WriteLine(i); 
        buyukler++;
    }
}
Console.WriteLine("girilen sayıdan küçükler:");
foreach (int i in sayilar)
{
    if (i < b)
    {
        Console.WriteLine(i);
        kucukler++;
    }
}