using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           int sonuc = topla(5,6);

            Methods sınıf = new Methods();
            sınıf.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = sınıf.arttırVeTopla(4,6);
            sınıf.EkranaYazdir(Convert.ToString(sonuc2));


            int a = 5;
            int b = 8;
            int sonuc3 = sınıf.arttırVeToplaRef(ref a,ref b);
            sınıf.EkranaYazdir(Convert.ToString(sonuc3));

            Console.WriteLine(a);
            Console.WriteLine(b);


        }

        public static int topla(int deger1,int deger2){
            return deger1+deger2;
        }

    }//class Program end


    class Methods
    {
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public int arttırVeTopla(int deger1, int deger2){
            deger1++;
            deger2++;
            return deger1+deger2;
        }

        public int arttırVeToplaRef(ref int deger1, ref int deger2){
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}
