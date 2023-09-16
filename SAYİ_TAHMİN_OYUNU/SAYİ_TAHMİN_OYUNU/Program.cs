namespace SAYİ_TAHMİN_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin=1;
            int hafiza;
            int sayac=0;
            Random rastgele=new Random();
            hafiza=rastgele.Next(1,100);
            while(tahmin!=hafiza)
            {
                sayac++;
                Console.WriteLine("Sayı girin:");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if(tahmin>hafiza)
                {
                    Console.WriteLine("Daha küçük sayı girin:");
                }
                else if(tahmin<hafiza)
                {
                    Console.WriteLine("Daha büyük sayı girin:");
                }
            }
            Console.WriteLine("Tebrikler sayıyı buldunuz");
            Console.WriteLine("{0}. denemede doğru sayıyı buldunuz." , sayac);
            Console.Read();
        }

    }
}