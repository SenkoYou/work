namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 2");
            double[] mass = new double[10];
            Random rand = new Random();

            for (int i = 0; i < mass.Length; i++) {
                mass[i] = rand.Next();
                mass[i] = mass[i] / 100;
            }

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }

            for (int j = 0; j < mass.Length; j++)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (i != mass.Length - 1)
                    {
                        if (mass[i] < mass[i + 1])
                        {
                            double a1 = mass[i];
                            double b2 = mass[i + 1];
                            mass[i] = b2;
                            mass[i + 1] = a1;
                        }
                    }
                    else {
                        continue;
                    }
                    
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i<mass.Length;i++) {
                double all = 0;
                if (mass[i]%2 == 0) {
                    all += mass[i];
                    Console.WriteLine(all);

                }
                if (i == mass.Length - 1) {
                    double arif = all / mass.Length;
                    Console.WriteLine(arif);
                }
            }
        }
    }
}