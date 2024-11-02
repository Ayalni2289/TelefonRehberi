class Menu {

    public void Baslat(){
        while(true)
        {
            Console.WriteLine("1. Telefon Numarası Kaydet");
            Console.WriteLine("2. Telefon Numarası Sil");
            Console.WriteLine("3. Telefon Numarası Güncelle");
            Console.WriteLine("4. Rehber Listeleme (A-Z, Z-A seçimli)");
            Console.WriteLine("5. Rehberde Arama");
            Console.WriteLine("6. Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();
            switch(secim)
            {
                case "1":
                    // Telefon Numarası Kaydet
                    break;
                case "2":
                    // Telefon Numarası Sil
                    break;
                case "3":
                    // Telefon Numarası Güncelle
                    break;
                case "4":
                    // Rehber Listeleme
                    break;
                case "5":
                    // Rehberde Arama
                    break;
                case "6":
                    // Çıkış
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    break;
            }
        }
    }
}