using System;

namespace _DEMO_VHVBTPM
{
    class Program
    {
        public static void nhap(int[] a, int n
            )
        {


            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void hienthi(int[] a, int n)
        {
            Console.Write(" mang vua nhap :\n");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t ", a[i]);
        }
        public static void ptduong(int[] a, int n)
        {
            Console.WriteLine(" \nphan tu dung nam o vi tri le la: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0 && i % 2 != 0)
                {

                    Console.Write("{0} \n", a[i]);
                }
            }
        }
        public static void ktraso(int[] a, int n)
        {
            Console.WriteLine("Nhap so kiem tra : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (x == a[i])
                {
                    dem++;
                }


            }
            Console.WriteLine(" so lan xuat hien la:" + dem);


        }
        static bool nguyento(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;

                }
            }
            return true;

        }
        public static void snto(int[] a, int n)
        {
            Console.WriteLine(" so nguen to trong mang la: ");
            for (int i = 1; i < n; i++)
            {
                if (nguyento(a[i]))
                {
                    Console.WriteLine("{0} ", a[i]);
                }
            }
        }
        static bool cp(int n)

        {

            if (n == Math.Sqrt(n) * Math.Sqrt(n))

                return true;

            else

                return false;

        }
        static void incp(int[] a, int n)

        {
            int i;
            Console.WriteLine("so chinh phuog trong mang la : \n");
            for (i = 1; i < n; i++)
            {
                if (cp(a[i]))
                {
                    Console.WriteLine("{0} ", a[i]);
                }

            }
        }
        static bool hoanhao(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n)
                return true;
            else
                return false;
        }
        static void inshh(int[] a, int n)

        {
            int i;
            Console.WriteLine("so hoan hao trong mang la : \n");
            for (i = 0; i < n; i++)
            {
                if (hoanhao(a[i]))
                {
                    Console.WriteLine("{0} ", a[i]);
                }

            }
        }
        static void ktrann(int[] a, int n)
        {

            int max = a[0];
            for (int i = 1; i < n; i++)
                if (max < a[i])
                    max = a[i];

            Console.WriteLine(" so lon nhat " + max);

        }
        static void ktramin(int[] a, int n)
        {

            int min = a[0];
            for (int i = 1; i < n; i++)
                if (min > a[i])
                    min = a[i];

            Console.WriteLine(" so nho nhat " + min);

        }
        static void xoa(int[] a, int n)
        {
            Console.Write("\nNhap vi tri can xoa: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i != k - 1)
                i++;
            while (i < n)
            {
                a[i] = a[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("Nhap so phan tu trong mang : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Program.nhap(a, n);
            Program.hienthi(a, n);
            Program.ptduong(a, n);
            Program.ktraso(a, n);
            Program.snto(a, n);
            Program.incp(a, n);
            Program.inshh(a, n);
            Program.ktrann(a, n);
            Program.ktramin(a, n);
            Program.xoa(a, n);
            Console.ReadKey();




        }
    }

}
