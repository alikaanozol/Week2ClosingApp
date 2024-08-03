//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?
//Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

//2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

//string text = "abc";
//int number = 2;
//Console.WriteLine(text);
//Console.WriteLine(number);

////3 - Rastgele bir sayı üretip , ekrana yazdırınız.

//Random random = new Random();
//int rndNumber = random.Next();
//Console.WriteLine(rndNumber);

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

//Random random = new Random();
//int rndNumber = random.Next();
//Console.WriteLine("Rastgele üretilen sayı ---> "+ rndNumber);
//Console.WriteLine("Rastgele üretilen sayının 3'e bölümünden kalan "+ (rndNumber%3));

//5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

//Console.Write("Yaşınızı giriniz: ");                                                      //Convert  ile
//int yas = Convert.ToInt32(Console.ReadLine());
//if (yas >18)
//    Console.WriteLine("+");
//else
//    Console.WriteLine("-");

//int yas;

//bool uygunMu= int.TryParse(Console.ReadLine(), out yas);                                    // TryParse ile

//if (!uygunMu)
//    Console.WriteLine("Yanlış formatta değer giriniz");
//else
//{
//    Console.WriteLine("Uygun formatta veri girildi");
//    if (yas > 18)
//        Console.WriteLine("+");
//    else
//        Console.WriteLine("-");
//}


//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

//for (int i = 1; i <= 10 ; i++)
//{
//    Console.WriteLine($"{i}- Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
//string value1 = "Gülse Birsel";
//string value2 = "Demet Evgar";
//Console.WriteLine($"İlk değer {value1}");
//Console.WriteLine($"İkinci değer {value2}");
//string temp = value1;
//value1 = value2;
//value2 = temp;
//Console.WriteLine($"Değiştikten sonra ilk değer {value1}");
//Console.WriteLine($"Değiştikten sonra ikinci değer {value2}");


//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
//static void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

//int Total(int a,int b)
//{
//    return a + b;
//}
//Console.WriteLine(Total(2, 4)); 

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

//string Honest(bool answer1)
//{
//    return "geri dönüş mesajı";
//}

//Console.WriteLine(Honest(true)); 

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
//int Ageof3People(int age1,int age2,int age3)
//{
//    int maxAge = age1;

//    if (maxAge > age2)
//        maxAge = age2;           
//    if (age3 > maxAge)
//        maxAge = age3;
//    return maxAge;

//}
//int maxAge = Ageof3People(25, 82, 212);// yaşların küçükten büyüğe doğru iletildiğini varsayarsak.
//Console.WriteLine(maxAge);

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

//void Returning()
//{
//    int number;
//    int max = int.MinValue;

//    while (true)
//    {
//        Console.Write("Bir sayı giriniz --> ");
//        bool isAvailable = int.TryParse(Console.ReadLine(), out number);
//        if (isAvailable)
//        {
//            if (number > max)
//                max = number;
//        }
        
//        else
//            Console.WriteLine("Yanlış formatta veri girişi yaptınız.");

//        if (max == int.MinValue)
//            Console.WriteLine("Henüz geçerli bir sayı değeri girilmedi.");
//        else
//            Console.WriteLine("En büyük sayı -----> " + max);

//    }

//}

//Returning();

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
//void ChangeNames(ref string x, ref string y)
//{
//    string temp = x;
//    x = y;
//    y = temp;
//}

//string name1 = "Aslı";
//string name2 = "Mehmet";

//Console.WriteLine($"Alınan değerler 1- {name1} ve 2- {name2}");
//ChangeNames(ref name1, ref name2);
//Console.WriteLine("Değişim yapılıyor");
//Console.WriteLine($"Alınan değerler 1- {name1} ve 2- {name2}");

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
//bool OddEven(int x) 
//{
//    int even = x % 2;
//    if (even == 0)
//        return true;
//    else 
//        return false;
//}
//Console.WriteLine(OddEven(5)); 

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
//double Way(double speed,double time)
//{
//    double way = speed * time;
//    return way;
//}
//double speed=Convert.ToSingle(Console.ReadLine());
//double time = Convert.ToSingle(Console.ReadLine());
//Console.WriteLine(Way(speed, time)); 

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
//void Area(double radius)
//{
//    double area = Math.PI*Math.Pow(radius, 2);
//    Console.WriteLine("Dairenin alanı -> "+ area);
//}

//Area(4);

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//string text = "Zaman bir GeRi SayIm";

//string upperCaseText = text.ToUpper();
//string lowerCaseText = text.ToLower();
//Console.WriteLine("Cümlemiz ---> " + text);

//Console.WriteLine("Cümlenin hepsi büyük harf olarak hali ---> "+ upperCaseText);
//Console.WriteLine("Cümlenin hepsi küçük harf olarak hali ---> " + lowerCaseText);

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

//string text = "    Selamlar   ";
//text = text.Trim();
//Console.WriteLine(text);