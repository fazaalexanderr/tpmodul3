using System;

namespace tpmodul3_1302204062
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kode1 = new KodePos();
            KodePos.Kode inputKode = KodePos.Kode.Jatisari;
            Console.WriteLine(kode1.GetKodePos(inputKode));
        }
    }
}