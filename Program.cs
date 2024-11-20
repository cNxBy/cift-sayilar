namespace çift_sayılar_iki_sayı_arasındaki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int i;
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());

            if (a < b && a % 2 == 0)
            {
                for (i = a; i <= b; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if  (b < a && b % 2 == 0)
            {
                for(i = b; i <= a ; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
                
                

                    Console.ReadLine();
            
        }
    }
}
