using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            Lol cl1 = new Lol();
            Console.WriteLine(cl1.Func1());
            Console.WriteLine(cl1.Func2());
            Console.WriteLine(cl1.Func3());
            Console.ReadLine();
        }
    }
}

class Lol
{
    int x = 5;
    const long y = 10;
    float[] arr = { 0, 1, 2 };
    enum lol
    {
        one = 1,
        two = 2,
        three = 3
    }

    public int Func1()
    {
        return x + (int)y;
    }

    public double Func2()
    {
        return x / (int)y;
    }

    public float Func3()
    {
        return arr[2];
    }
}