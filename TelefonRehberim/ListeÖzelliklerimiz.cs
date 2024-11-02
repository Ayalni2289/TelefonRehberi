class ListeÖzellikleri{

    List<Kisi> Kisilerim = new List<Kisi>();
    
    //Başlangıçta 5 kişi ekledik.
    public ListeÖzellikleri(){
        Kisilerim.AddRange(new List<Kisi>{
            new Kisi("Ali", "Veli", "1234567890"),
            new Kisi("Ayşe", "Fatma", "0987654321"),
            new Kisi("Mehmet", "Ahmet", "5432167890"),
            new Kisi("Zeynep", "Kamil", "0987654321"),
            new Kisi("Kerem", "Can", "1234567890")
            });
}

public void Ekle(){
    Console.WriteLine("Lütfen isim giriniz: ");
    string ad = Console.ReadLine();
    ad = ad.ToLower();
    Console.WriteLine("Lütfen soyisim giriniz: ");
    string soyad = Console.ReadLine();
    soyad = soyad.ToLower();
    Console.WriteLine("Lütfen telefon numarası giriniz: ");
    string numara = Console.ReadLine();

    Kisilerim.Add(new Kisi(ad, soyad, numara));
    Console.WriteLine(ad +"Kişisi başarıyla eklendi.");
}

public void Sil(){
    Console.WriteLine("Lütfen silmek istediğiniz kişinin adını veya soyadını giriniz: ");
    string silinecek = Console.ReadLine().ToLower();
    bool silindiMi = false;

    
        Kisi silinecekKisi = Kisilerim.FirstOrDefault(kisi =>
        kisi.Ad.ToLower() == silinecek || kisi.Soyad.ToLower() == silinecek);
        if(silinecekKisi != null){
            Console.WriteLine("{0} kişisi silinecektir. Onaylıyor musunuz? (y/n)", silinecekKisi.Ad + " " + silinecekKisi.Soyad);
            if(Console.ReadLine().ToLower() != "y"){
                Console.WriteLine("İşlem iptal edildi.");
                return;
            }else{
            Kisilerim.Remove(silinecekKisi);
            silindiMi = true;
            }
        }
    if(silindiMi){
        Console.WriteLine(silinecek + " kişisi başarıyla silindi.");
    }
    else{
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("1. Menuye geri dön");
        Console.WriteLine("2. Yeniden deneyin");
        switch(Console.ReadLine()){
            case "1":
                break;
            case "2":
                Sil();
                break;
            default:
                Console.WriteLine("Hatalı seçim yaptınız.");
                break;
        }
    }
}

public void Guncelle(){
    Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz: ");
    string guncellenecek = Console.ReadLine().ToLower();
    bool guncellendiMi = false;
    Kisi güncellenecekKisi = Kisilerim.FirstOrDefault(kisi =>
        kisi.Ad.ToLower() == guncellenecek || kisi.Soyad.ToLower() == guncellenecek);
    
    if(güncellenecekKisi != null)
    {
        Console.WriteLine("Lütfen güncellemek istediğiniz bilgiyi seçiniz: ");
        Console.WriteLine("1. İsim");
        Console.WriteLine("2. Soyisim");
        Console.WriteLine("3. Telefon Numarası");

        int value = int.Parse(Console.ReadLine());

           switch(value){
            case 1:
                Console.WriteLine("Lütfen yeni isim giriniz: ");
                string yeniAd = Console.ReadLine().ToLower();
                güncellenecekKisi.Ad = yeniAd;
                guncellendiMi = true;
                break;
            case 2:
                Console.WriteLine("Lütfen yeni soyisim giriniz: ");
                string yeniSoyad = Console.ReadLine().ToLower();
                güncellenecekKisi.Soyad = yeniSoyad;
                guncellendiMi = true;
                break;
            case 3:
                Console.WriteLine("Lütfen yeni telefon numarası giriniz: ");
                string yeniNumara = Console.ReadLine();
                güncellenecekKisi.Numara = yeniNumara;
                guncellendiMi = true;
                break;
            default:
                Console.WriteLine("Hatalı seçim yaptınız.");
                break;
           }
    }
    if(guncellendiMi){
        Console.WriteLine(guncellenecek + " kişisi başarıyla güncellendi.");
    }
    else{
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("1. Menuye geri dön");
        Console.WriteLine("2. Yeniden deneyin");
        switch(Console.ReadLine()){
            case "1":
                break;
            case "2":
                Guncelle();
                break;
            default:
                Console.WriteLine("Hatalı seçim yaptınız.");
                break;
        }
    }
}

public void Listele(){
    Console.WriteLine("Listeleme türünü seçiniz: ");
    Console.WriteLine("1. A-Z");
    Console.WriteLine("2. Z-A");
    int value = int.Parse(Console.ReadLine());
    switch(value){
        case 1:
            Kisilerim = Kisilerim.OrderBy(kisi => kisi.Ad).ToList();
            break;
        case 2:
            Kisilerim = Kisilerim.OrderByDescending(kisi => kisi.Ad).ToList();
            break;
        default:
            Console.WriteLine("Hatalı seçim yaptınız.");
            break;
    }
    foreach(Kisi kisi in Kisilerim){
        Console.WriteLine("Ad: {0}, Soyad: {1}, Numara: {2}", kisi.Ad, kisi.Soyad, kisi.Numara);
    }
}

public void RehberdeAra(){
    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını veya soyadını giriniz: ");
    string arananAdSoyad = Console.ReadLine().ToLower();
    bool bulunduMu = false;
    foreach(Kisi kisi in Kisilerim){
        if(kisi.Ad.ToLower().Contains(arananAdSoyad) || kisi.Soyad.ToLower().Contains(arananAdSoyad)){
            Console.WriteLine("Ad: {0}, Soyad: {1}, Numara: {2}", kisi.Ad, kisi.Soyad, kisi.Numara);
            bulunduMu = true;
        }
    }
    if(!bulunduMu){
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("1. Menuye geri dön");
        Console.WriteLine("2. Yeniden deneyin");
        switch(Console.ReadLine()){
            case "1":
                break;
            case "2":
                RehberdeAra();
                break;
            default:
                Console.WriteLine("Hatalı seçim yaptınız.");
                break;
        }
}
}
}