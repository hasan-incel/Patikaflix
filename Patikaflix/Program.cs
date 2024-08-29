using Patikaflix;
class Program
{
    static void Main(string[] args)
    {
        List<Dizi> diziler = new List<Dizi>();
        string devamMi;

        do
        {
            Console.WriteLine("Dizi Adı:");
            string diziAdi = Console.ReadLine();

            Console.WriteLine("Dizi Türü:");
            string diziTuru = Console.ReadLine();

            Console.WriteLine("Yönetmen:");
            string yonetmen = Console.ReadLine();

            Console.WriteLine("Yıl:");
            int yil = int.Parse(Console.ReadLine());

            diziler.Add(new Dizi(diziAdi, diziTuru, yonetmen, yil));

            Console.WriteLine("Başka bir dizi eklemek istiyor musunuz? (E/H):");
            devamMi = Console.ReadLine().ToUpper();
        }
        while (devamMi == "E");

        // Komedi dizilerini filtreleme
        List<KomediDizi> komediDizileri = diziler
            .Where(d => d.DiziTuru.ToLower() == "komedi")
            .Select(d => new KomediDizi(d.DiziAdi, d.DiziTuru, d.Yonetmen))
            .ToList();

        // Yeni listeyi sıralama (önce dizi isimlerine göre, sonra yönetmen isimlerine göre)
        var siraliKomediDizileri = komediDizileri
            .OrderBy(k => k.DiziAdi)
            .ThenBy(k => k.Yonetmen)
            .ToList();

        // Komedi dizilerini ekrana yazdırma
        if (siraliKomediDizileri.Any())
        {
            Console.WriteLine("\nKomedi dizileri:");
            foreach (var dizi in siraliKomediDizileri)
            {
                Console.WriteLine($"Dizi Adı: {dizi.DiziAdi}, Türü: {dizi.DiziTuru}, Yönetmen: {dizi.Yonetmen}");
            }
        }
        else
        {
            Console.WriteLine("\nKomedi dizisi bulunmamaktadır.");
        }

    }
}