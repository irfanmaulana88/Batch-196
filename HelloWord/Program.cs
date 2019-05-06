using System; // name space adalah tempat kumpulan system //

namespace HelloWord
{
    //identifier adalah nama yang digunakan pada tipe data  dll //
    class Program //class,struct , interface, enumerations, and delegates termasuk type data //
        //tipe data ada yg primitif dan reference //
        //class adalah  //
    {
        static void Main(string[] args) 
            //Main = Nama method , method adalah tempat dimana logic itu ditulis (urutan perintah) //
            
        {
            Console.WriteLine("Hello Batch 196"); //output, dalam tanda "" disebut string //
            Console.WriteLine();
            Example01();
            Example02();
            Example03();
            Example04();
            Example05();
            Console.ReadKey(); /*comment lebih dari 1 baris menggunakan tanda (*)
                                */
            
        }

        // makanan , tempat, film  favorit , teman setia , tokoh favorit  7 //
        static void Example01()
        {
            Console.WriteLine("Makanan Favoritku :");
            Console.WriteLine("Nasi Goreng");
            Console.WriteLine("Ayam Bakar");
            Console.WriteLine("Rendang");
            Console.WriteLine("Sate");
            Console.WriteLine("Tahu");
            Console.WriteLine("tempe");
            Console.WriteLine("Kebuli");
            Console.WriteLine();
        }
        static void Example02()
        {
            Console.WriteLine("Tempat Favoritku :");
            Console.WriteLine("Taman");
            Console.WriteLine("Cafe");
            Console.WriteLine("Bioskop");
            Console.WriteLine("Mall");
            Console.WriteLine("Rumah");
            Console.WriteLine("Masjid");
            Console.WriteLine("Kamar");
            Console.WriteLine();
        }

        static void Example03()
        {
            Console.WriteLine("Film Favoritku :");
            Console.WriteLine("Avengers");
            Console.WriteLine("Iron Man");
            Console.WriteLine("Transformers");
            Console.WriteLine("Fast And Furious");
            Console.WriteLine("The Conjuring");
            Console.WriteLine("Mission Imposible");
            Console.WriteLine();
        }

        static void Example04()
        {
            Console.WriteLine("Teman Setiaku :");
            Console.WriteLine("Titi Jaidai");
            Console.WriteLine("Dinda Ayunindia Putri");
            Console.WriteLine("Istiana Pratiwi");
            Console.WriteLine("Harsan Febrianto");
            Console.WriteLine("Zulkarnain");
            Console.WriteLine("Asrul");
            Console.WriteLine("Ilham");
            Console.WriteLine();
        }

        static void Example05()
        {
            Console.WriteLine("Tokoh Favoritku :");
            Console.WriteLine("Bung Karno");
            Console.WriteLine("Bung Hatta");
            Console.WriteLine("Sudirman");
            Console.WriteLine("Budi Utomo");
            Console.WriteLine("Tuanku Imam Bonjol");
            Console.WriteLine("Mark Zuckenberg");
            Console.WriteLine("Bill Gates");
            Console.WriteLine();
        }
    }
}
// a = 10 nilai a sama dengan 10 //
// a == 10 apakah nilai a sama dengan 10 ? //
// API = aplication program interface//