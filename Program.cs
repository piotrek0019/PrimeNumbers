namespace PrimeNumbers
{
    public class Prime
    {

        public bool ifPrime(int prime)
        {
            if (prime < 2)
                return false;

                for (int i = 2; i * i <= prime; i++)
                {
                    if (prime % i == 0)
                        return false;
                }
                return true;
        }
    }

    public class bulkPrimes
    {
        Prime pri = new Prime();

        public void Primes()
        {
            for(int i = 1; i <= 200; i++)
            {
                if (pri.ifPrime(i))
                    Console.Write(i + ", ");
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            bulkPrimes bPri = new bulkPrimes();

            bPri.Primes();
            

            Console.ReadLine();

        }
    }
}
