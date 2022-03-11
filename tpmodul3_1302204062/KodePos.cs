using System;

namespace tpmodul3_1302204062
{
    public class KodePos
    {
        public enum Kode {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja};

        public KodePos()
        {
        }
        
        public int GetKodePos(Kode inputKodePos)
        {
            int[] arrayKodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            int indexJawaban = (int)inputKodePos;
            return arrayKodePos[indexJawaban];
        }
    }
}
