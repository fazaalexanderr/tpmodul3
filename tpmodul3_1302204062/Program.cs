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
            Console.WriteLine(kode1.GetKodePos(KodePos.Kode.Samoja));

            DoorMachine door1 = new DoorMachine();
            Console.WriteLine(door1.StateSaatIni);
            door1.activateTrigger(DoorMachine.Aksi.BukaPintu);
            door1.activateTrigger(DoorMachine.Aksi.KunciPintu);
        }
    }
}