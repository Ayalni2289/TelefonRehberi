class Menu {

    public void Baslat(){

        ListeÖzellikleri listeÖzellikleri = new ListeÖzellikleri();
        Boolean devam = true;

        while(devam)
        {
            Console.WriteLine("1. Telefon Numarası Kaydet");
            Console.WriteLine("2. Telefon Numarası Sil");
            Console.WriteLine("3. Telefon Numarası Güncelle");
            Console.WriteLine("4. Rehber Listeleme (A-Z, Z-A seçimli)");
            Console.WriteLine("5. Rehberde Arama");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");
            string? secim = Console.ReadLine();
            switch(secim)
            {
                case "1":
                    // Telefon Numarası Kaydet
                    listeÖzellikleri.Ekle();
                    break;
                case "2":
                    // Telefon Numarası Sil
                    listeÖzellikleri.Sil();
                    break;
                case "3":
                    // Telefon Numarası Güncelle
                    listeÖzellikleri.Guncelle();
                    break;
                case "4":
                    // Rehber Listeleme
                    listeÖzellikleri.Listele();
                    break;
                case "5":
                    // Rehberde Arama
                    listeÖzellikleri.RehberdeAra();
                    break;
                case "0":
                    devam=false;
                    // Çıkış
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    break;
            }
        }
    }
}