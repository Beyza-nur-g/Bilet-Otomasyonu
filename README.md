# Bilet-Otomasyonu
Admin ,firma ve kullanıcı olarak 3 bölümden oluşan veri yapılarını hazır kütüphane kullanmadan yazılmış bir c# kodudur. 


Projede belirli firmalar ekleyip, sec¸ili firmalar uzerinde rez- ¨
ervasyon yapmaktır. Bu firmalar demiryolu, karayolu, havayolu uzerinden ulas¸ım sa ¨ glamakta ve belirli seferleri bulun- ˘
maktadır. Amac¸ form tasarımı yapıp bu tasarılarda istenilen
classları ve interfaceleri kullanmaktır. Bu sayede nesneye
yonelik programlamaya hakim olmak ana hedeftir. ¨


II. G˙IR˙IS¸
Bu projenin amacı, nesneye yonelik programlama yapısının ¨
anlas¸ılabilmesi ve bu sayede problemlere c¸oz¨ um bula- ¨
bilmeyi hedeflemektedir. Mevcut kodlar Visual Studio ile
yazılmıs¸tır. Bir rezervasyon sistemi yapmayı amac¸layan bu
proje; arayuzden c¸alıs¸acak olup, verilen classların kullanımı ¨
zorunludur. Bahsedilen rezervasyon sistemi kısaca s¸oyledir: ¨
Bir giris¸imci yolcuların farklı ulas¸ım firmalarından ya da
s¸irketlerinden rezervasyon yapabildigi bir sistem kurmak is- ˘
temektedir. Ulas¸ım s¸irketleri demiryolu, karayolu ve havayolu sec¸enekleri ile yolcu tas¸ımaktadır. Bazıları birden fazla
sec¸enekte (havayolu ve karayolu gibi) hizmet verebilir. Sistemde admin, firma ve kullanıcı paneli bulunmalıdır. Admin
panelinde kullanıcı adı ve s¸ifre ile giris¸ yapılmalıdır. Sistemde sadece 1 adet admin bulunmalıdır. Admin panelinde
var olan firmalar gor¨ unt ¨ ulenebilir, yeni bir firma kaydı yapılıp ¨
firma kaydı silinebilir ve hizmet bedeli belirlenebilir. Firma
paneli ise kullanıcı adı ve s¸ifre ile giris¸ yapılmalıdır, her
firma ic¸in kullanıcı adı, s¸ifre ve arac¸ bilgisi kaydedilmelidir.
Firma panelinde arac¸ ekleme ve c¸ıkarma, sefer ekleme ve
c¸ıkarma yapılabilir. Ayrıca gunl ¨ uk kar hesabı yapılmalıdır. ¨
Gunl ¨ uk kar hesabı yolcu ¨ ucretleri, hizmet bedeli, personel ¨
maliyeti ve yakıt maliyeti dikkate alınarak yapılmalıdır. Kullanıcı paneline ”Bilet Ara” s¸eklinde bir buton aracılıgıyla ˘
gec¸is¸ yapılmalıdır. Kullanıcı panelinde istenilen gun ve ulas¸ım ¨
Identify applicable funding agency here. If none, delete this.
yoluna gore seferler listelenebilir, rezervasyon yapılabilir ve ¨
bir kullanıcı aynı anda birden fazla rezervasyon yapabilir.
Kullanıcı panelinde yapılabilecek is¸lemler s¸unlardır: Belirli
bir gundeki ulas¸ım arac¸ların listelenmesi yapılabilir. Rez- ¨
ervasyon yapılabilir. Bir kullanıcı aynı anda birden fazla
rezervasyon yapabilir. Aynı arac¸tan birden fazla rezervasyon
yapması yeterlidir. Bilet aldıktan sonra rezervasyon yapılan
yerlerin doldugu anlas¸ılabilmeli ve aynı yer tekrardan bilet ˘
rezervasyonuna kapatılmalıdır. Kullanıcı, bilet rezervasyonu
is¸lemine bas¸lamadan once kalkıs¸ noktası, varıs¸ noktası ve ¨
yolculuk tarihi sec¸melidir. Sistem, kullanıcıya sadece 4-10
Aralık 2023 arasında bulunan 1 haftalık yolculuk tarihlerini
gosterecektir. Kullanıcı ayrıca seyahat edecek yolcu sayısını ¨
belirlemelidir. Kullanıcının sec¸imlerini yapmasının ardından
”Sefer Bul” butonuna tıklanarak uygun seferler sorgulanır.
Sistem, sec¸ilen tarihte uygun arac¸ları ve bu arac¸ların koltuk
durumlarını gosterecektir. Kullanıcı, seferler arasından gitmek ¨
istedigi firmanın seferini sec¸melidir. Sec¸ilen sefer ile ilgili ˘
bos¸ ve rezerve edilmis¸ koltuk bilgileri gor¨ unt ¨ ulenir. Kullanıcı, ¨
seyahat edecek kis¸i sayısına gore bos¸ koltukları sec¸melidir. ¨
Kullanıcı, yolcu adı, soyadı, T.C. numarası, dogum tarihi ˘
gibi bilgileri girmelidir. Tum yolcu bilgileri giris¸i tamam- ¨
landıktan sonra ”Odeme Yap” butonuna tıklanarak ¨ odeme ¨
is¸lemi yapılacaktır. Odeme is¸lemi bas¸arıyla tamamlandı ¨ gında, ˘
sec¸ilen sefer ve rezervasyon is¸lemi yapılan koltuklar ekranda
gor¨ unt ¨ ulenir. Rezerve edilen koltuklar, rezervasyon is¸lemi ¨
tamamlandıgında g ˘ or¨ un¨ ur. ¨


III. YONTEM ¨
AnaEkran sınıfı, Form sınıfından turetilmis¸ bir sınıftır ve bir ¨
Windows Form’u temsil eder. Rezervasyon is¸lemi ic¸in projenin
ilk adımını olus¸turan bu formun ic¸inde uc¸ adet buton (but- ¨
tonFirmaGiris, buttonTasarimciGiris, buttonKullanici) bulunmaktadır. ”buttonFirmaGiris Click” olay yoneticisi sayesinde ¨
firma giris¸i butonuna tıklandıgında bu olay tetiklenir. Ardından ˘
”GirisEkrani” adında yeni bir form orne ¨ gi (giris) olus¸turulur. ˘
Olus¸turulan giris formu gosterilir (Show). S¸u anki form olan ¨
AnaEkran gizlenir (Hide). Sonuc¸ olarak, kullanıcı firma giris¸i
butonuna tıkladıgında GirisEkrani formu ac¸ılır ve AnaEkran ˘
formu gizlenir. ”buttonTasarimciGiris Click” olay yoneticisi ¨
sayesinde ise tasarımcı giris¸i butonuna tıklandıgında bu olay ˘
tetiklenir. ”GirisEkrani” adında yeni bir form orne ¨ gi (giris) ˘
olus¸turulur. Olus¸turulan giris formu gosterilir (Show). S¸u anki ¨
form olan AnaEkran gizlenir (Hide). Sonuc¸ olarak, kullanıcı
tasarımcı giris¸i butonuna tıkladıgında GirisEkrani formu ac¸ılır ˘
ve AnaEkran formu gizlenir. ”buttonKullanici Click” olay
yoneticisinin amacı ise kullanıcı butonuna tıklandı ¨ gında bu ˘
olay tetiklenir. Hemen arkasından ”kullanici” adında yeni
bir form orne ¨ gi (kullanici) olus¸turulur. Olus¸turulan kullanici ˘
formu gosterilir (Show). S¸u anki form olan AnaEkran gizlenir ¨
(Hide). Sonuc¸ olarak, kullanıcı kullanıcı butonuna tıkladıgında ˘
Kullanici formu ac¸ılır ve AnaEkran formu gizlenir. Bu s¸ekilde,
kullanıcı farklı butonlara tıkladıkc¸a farklı formlara gec¸is¸ yapabilir ve AnaEkran formu her seferinde gizlenir. Bu tip form
gec¸is¸leri genellikle bir uygulamanın farklı bol¨ umleri arasında ¨
gec¸is¸ yapmak ic¸in kullanılır. Hedeflenen; kullanıcının istedigi˘
is¸lem ic¸in (firma ise arac¸ ekleme vb.) bir sonraki uygun panele
gec¸is¸tir.
Giris¸ ekranını yazdıran kod parc¸ası, kullanıcıların giris¸
bilgilerini kontrol ederek farklı formlara yonlendiren bir giris¸ ¨
ekranı tasarlamaktadır. Admin ve firma ic¸in ayrı s¸ifreler mevcuttur, bunların kontrolu ic¸in user classı olus¸turulur, is¸lemleri ¨
saglayabilmek adına ILoginable interface i olus¸turulur. User ˘
classı olus¸turulduktan sonra admin ve firmaya extend edilir.
User classının ic¸erisinde kullanıcı adı ve kullanıcı s¸ifre bulunmaktadır Admin ve firma giris¸inde kullanıcı ve s¸ifreye
gore bir do ¨ gruluma yapılması gerekmektedir. Bunun ic¸in de ˘
kimlik dogrulaması kullanılır. E ˘ ger kullanıcı adı ve s¸ifre ˘
aynı ise 1 degeri d ˘ ond ¨ ur¨ ul¨ ur. Bu durumda ac¸ılmak istenen ¨
form ac¸ılır. Bu formda iki adet buton (buttonAnaEkran, button1) ve iki adet metin kutusu (KullaniciAdiTextBox, SifreTextBox) bulunmaktadır. ”buttonAnaEkran Click” is¸levinde
ana ekrana don butonuna tıklandı ¨ gında bu olay tetiklenir. ˘
AnaEkran adında yeni bir form orne ¨ gi (anaEkran) olus¸turulur ˘
Olus¸turulan anaEkran formu gosterilir ”Show” ile g ¨ osterilir. S¸u ¨
anki form olan GirisEkrani kapatılır. Bu is¸lem, ”this.Close()”
sayesinde gerc¸ekles¸ir. Sonuc¸ olarak, kullanıcı ”Ana Ekran” butonuna tıkladıgında AnaEkran formuna d ˘ on¨ ul¨ ur ve GirisEkrani ¨
formu kapatılır. ”button1 Click” is¸levinde ise, giris¸ butonuna tıklandıgında bu olay tetiklenir. Kullanıcının girdi ˘ gi˘
kullanıcı adı ve s¸ifre alınır (KullaniciAdiTextBox.Text, SifreTextBox.Text). Ornek bir Admin ve bir Company nes- ¨
nesi olus¸turulur. Bu ornek nesnelerin kullanıcı adı ve ¨
s¸ifresi onceden belirlenmis¸tir. Kullanıcının girdi ¨ gi bilgilerin ˘
dogrulu ˘ gu kontrol edilir. E ˘ ger giris¸ bilgileri Admin nesnesinin ˘
bilgileri ile es¸les¸iyorsa, tasarımcı formu olan Tasarimci formu
ac¸ılır ve s¸u anki form olan GirisEkrani kapatılır. Eger giris¸ ˘
bilgileri Admin nesnesi ile es¸les¸miyorsa, kullanıcı adına gore ¨
yeni bir Company nesnesi olus¸turulur ve bu nesnenin bilgileri
kontrol edilir. Eger giris¸ bilgileri do ˘ gruysa, firma formu olan ˘
Firma formu ac¸ılır ve s¸u anki form olan GirisEkrani kapatılır.
Eger giris¸ bilgileri her iki durumda da do ˘ gru de ˘ gilse, kul- ˘
lanıcıya bir hata mesajı gosterilir (MessageBox.Show(”Hatalı ¨
kullanıcı adı veya s¸ifre.”)).
Tasarımcının panelinin kodu ise, bir Windows Forms uygulamasının kullanıcı arayuz¨ u ile etkiles¸imli bir s¸ekilde c¸alıs¸an ¨
bir ”Tasarimci” penceresini temsil eder. Admin sınıfı, firma
ekleme, listeleme ve silme gibi is¸levleri gerc¸ekles¸tiren yonetici ¨
is¸lemleri ic¸in kullanılmaktadır. Bu is¸lemleri yapabilmek ic¸in
olus¸turulan admin classının ic¸erisinde firma eklenmesi gerekmektedir. Firma ekleme fonksiyonunda parametre olarak firma
adı ve hizmet ucreti alınır. ¨ Oncelikle firma adı NULL ¨
degil ise FirmaOlustur classı c¸a ˘ gırılır ve firmalar listesine ˘
firma entegre edilir. FirmaOlustur classı ic¸erisinde firma ic¸in
gerekli olan bilgiler; FirmaAdi ve HizmetUcreti nde tutulur. Daha sonra olus¸turulan her firmayı yazdırabilmek ic¸in
ToString metodu c¸agırılır. Bu classı admin ic¸erisinde Firma ˘
listesini tutmak ic¸in FirmaOlustur classından alınan bilgilerle
firmalar listesi olus¸turulur. Firma silme is¸lemi ise listeler
kısmından RemoveAt kullanılarak yapılır. ”InitializeComponent()” ’Tasarimci’ sınıfının yapılandırıcı metodudur. Windows Forms tasarımı ic¸in gerekli biles¸enleri bas¸latır.
”buttonAnaEkran Click” metodu, ”Ana Ekran” butonuna
tıklandıgında gerc¸ekles¸ir. Bir AnaEkran nesnesi olus¸turur, ˘
onu gosterir (anaEkran.Show()) ve mevcut Tasarimci ¨
penceresini kapatır (this.Close()). Ardından bir admin nesnesi
olus¸turulur. Admin sınıfı, kodda tanımlı diger sınıflara ˘
eris¸im saglamaktadır. Arkasından gelen ”buttonListele Click” ˘
metodunun is¸levi ise ”Listele” butonuna tıklandıgında ˘
gerc¸ekles¸ir. listBox1 adlı bir ListBox kontrolundeki ¨
o¨geleri temizler (listBox1.Items.Clear()) ve ardından admin ˘
nesnesinin firmalar listesinde bulunan her bir o¨geyi foreach ˘
ile listBox1 kontrolune ekler. ”buttonFirmaEkle Click” ¨
metodu, ”Firma Ekle” butonuna tıklandıgında c¸alıs¸ır. ˘
˙Ilk
olarak, textBoxFirmaAdi ve textBoxHizmet adlı TextBox
kontrolunden kullanıcının girdi ¨ gi verileri alır. Daha sonra, ˘
textBoxHizmet ic¸erigini bir decimal t ˘ ur¨ une c¸evirmeye c¸alıs¸ır ¨
(TryParse metodu kullanılır). Eger bas¸arılı olursa, admin ˘
nesnesinin FirmaEkle metodunu c¸agırarak yeni firmayı ˘
ekler. Ardından, listBox1 kontrolundeki ¨ o¨geleri temizler ve ˘
guncel firmaları tekrar ekleyerek listeleyerek kullanıcıya ¨
gosterir. E ¨ ger hizmet bedeli gec¸erli bir sayıya c¸evrilemezse, ˘
kullanıcıya hata mesajı gosterir. ”buttonSil Click” metodu ¨
ise ”Sil” butonuna tıklandıgında c¸alıs¸ır. ˘ Oncelikle, listBox1 ¨
kontrolunden sec¸ilen firmanın indeksini kontrol eder. E ¨ ger ˘
gec¸erli bir sec¸im yapılmıs¸sa, admin nesnesinin FirmaSil
metodunu c¸agırarak sec¸ilen firmayı siler. Kullanıcıya ”Firma ˘
silindi.” mesajını gosterir, listBox1 kontrol ¨ undeki ¨ o¨geleri ˘
temizler ve guncel firmaları tekrar ekleyerek listeleyerek ¨
kullanıcıya gosterir. E ¨ ger ListBox’tan sec¸ili bir firma yoksa, ˘
kullanıcıya hata mesajı gosterir. ”buttonAnaEkran Click ¨
1” metodu, bir onceki ”AnaEkran” butonunun alternatif ¨
bir versiyonudur. Aynı is¸levi gerc¸ekles¸tirir, yani AnaEkran
penceresini olus¸turur, gosterir (anaEkran.Show()) ve mevcut ¨
Tasarimci penceresini kapatır (this.Close()). Tasarımcı
yerine firma paneli ac¸ılırsa oncelikle firma ic¸erisindeki ¨
bilgileri bir bas¸ka formda gosterebilmek ic¸in firma ic¸in ¨
kullandıgımız Company classında static bir tanımlama ˘
yapılır. Bu tanımlamada Instance null oldugunda Company ˘
newlenir. Company classında tutulması gereken bilgiler
s¸unlardır: vehicles, rotalar, seferler, kullananpersoneller,
hizmet veren personeller. Bu bilgileri tutmak ic¸in hepsinde
List kullanılır. Bu listleri s¸u classlar olus¸turur: Vehicle, Route,
Trip, Personel. Listeleri kullanabilmek ic¸in bir constructor
tanımlanır. Daha sonra Vehicle classından sec¸tigimiz ˘
arac¸ tur¨ une g ¨ ore extend etmeler yapılır. Trip classında ¨
ise SeferNo,AracId,Rota,Gun ve fiyat tanımlanır. Route
classında KalkisSehri,VarisSehri,MesafeMatrisi tanımlanır.
Seferlerin rotaları listelerde tutulur. Fiyat matrisinde ise
karayolu, demiryolu ve havayolu fiyat degerleri tutulur. ˘
”buttonAnaEkran Click” metodu, ”Ana Ekran” butonuna
tıklandıgında c¸alıs¸ır. AnaEkran formunu olus¸turur ve g ˘ osterir, ¨
ardından mevcut Firma formunu kapatır.” Company company
= Company.Instance;” satırında, Company sınıfından bir nesne
olus¸turuluyor. Ancak, Instance adlı bir ozelli ¨ gi kullanıyoruz. ˘
Company sınıfının Instance ozelli ¨ gi, Company sınıfından ˘
sadece bir orne ¨ gin olus¸turulmasını sa ˘ glar. Yani, company ˘
nesnesi, uygulama boyunca bir kere olus¸turulur ve her
yerde aynı nesne kullanılır. Bu sayede, sınıfın bir orne ¨ ginin ˘
birden fazla yerde olus¸turulmasının on¨ une gec¸ilir. ”Route ¨
rota = new Route(” ”, ” ”);” satırında, Route sınıfından
bir nesne olus¸turuluyor ve rota adlı degis¸kene atanıyor. Bu ˘
nesne, bir seyahatin guzergahını temsil etmektedir. ”Trip ¨
trip = new Trip();” satırında ise, Trip sınıfından bir nesne
olus¸turuluyor ve trip adlı degis¸kene atanıyor. Bu nesne, bir ˘
seyahatin temel bilgilerini ic¸erir. Yapıcı metodu c¸agrılırken ˘
herhangi bir parametre gec¸ilmiyor, bu nedenle varsayılan
degerlerle bir Trip nesnesi olus¸turuluyor. ”buttonAracEkle ˘
Click” metodu, ”Arac¸ Ekle” butonuna tıklandıgında c¸alıs¸ır. ˘
Oncelikle sec¸ilen arac¸ t ¨ ur¨ une g ¨ ore uygun arac¸ nesnesini ¨
olus¸turur. Ardından kullanıcının girdigi bilgileri is¸leyerek ˘
aracı ekler. Company nesnesinin AracEkle metodu ile
aracı ekler, ardından ListBox’ı temizler ve guncel arac¸ları ¨
ekleyerek listeleyerek kullanıcıya gosterir. ”button2 Click” ¨
Metodu, ”Sil” butonuna tıklandıgında c¸alıs¸ır. ˘ Oncelikle ¨
ListBox’tan sec¸ilen aracın indeksini kontrol eder. Eger gec¸erli ˘
bir sec¸im yapılmıs¸sa, company nesnesinin AracSil metodunu
c¸agırarak sec¸ilen aracı siler. Kullanıcıya ”Arac¸ silindi.” ˘
mesajını gosterir, ListBox’ı temizler ve g ¨ uncel arac¸ları tekrar ¨
ekleyerek listeleyerek kullanıcıya gosterir. E ¨ ger ListBox’tan ˘
sec¸ili bir arac¸ yoksa, kullanıcıya hata mesajı gosterir. ¨
”ComboBoxAracIdGonderme” Metodu, ComboBox’a arac¸ ¨
kimliklerini guncelleyen bir yardımcı metottur. Her aracın ¨
VehicleId’sini ComboBox’a ekler ve eger ComboBox’ta ˘ o¨ge˘
varsa ilk o¨geyi sec¸ili hale getirir. Kullanıcı panelinde ise ˘ once ¨
belirli degis¸kenleri tanımlayıp, belirli nesneler olus¸turulur. ˘
Ardından buttonAnaEkran Click metodu ile ”AnaEkran”
adlı bas¸ka bir formu olus¸turarak ana ekrana gec¸is¸i saglar. ˘
”buttonBiletAra Click” metodu, kullanıcının seyahat bilgilerini
sec¸mesine ve uygun seyahatleri listelemesine olanak
tanır. Kullanıcının girdigi kalkıs¸, varıs¸ s¸ehirleri ve sefer ˘
gun¨ une g ¨ ore uygun seyahatler listelenir. Uygun seyahatler ¨
listBoxSeferler adlı liste kutusuna eklenir. fiyatMatrisleri
newlenir. ”comboBoxNereden SelectedIndexChanged”
ve ”comboBoxNereye SelectedIndexChanged” metotları,
kullanıcının aynı s¸ehri sec¸memesini saglar ve uyarı verir. ˘
”button1 Click” metodu, sec¸ilen bir seyahatin aracının
koltuk sayısını alır ve Transport nesnesini newler.
”CreateSeatLayout” metodu, koltuk duzenini olus¸turarak ¨
kullanıcıya koltuk sec¸me imkanı verir. ”KoltukLabel Click”
metodu, kullanıcının koltuk sec¸mesini ve sec¸tigi koltukları ˘
is¸aretlemesini saglar. ”buttonRezervasyon Click” metodu, ˘
mus¸terinin yaptı ¨ gı rezervasyonları listBoxRezervasyonlar ˘
adlı liste kutusuna ekler. ”buttonbilgiKaydet Click” metodu,
kullanıcının yolcu bilgilerini girdigi textBox’ları kontrol ˘
eder ve bu bilgilerle olus¸turulan bir Passenger nesnesiyle
rezervasyon yapar. ”buttonSonrakiYolcu Click” metodu,
kullanıcının bir sonraki yolcu bilgilerini girebilmesi ic¸in
textBox’ları temizler.


SONUC¸
Sonuc¸ olarak, ana hedef olan nesneye yonelik pro- ¨
gramlama yapısı o¨grenilmis¸ ve interface kullanımı, imple- ˘
ment ve extend etme kavranmıs¸tır. Rezervasyon sistemi
kurulmus¸tur. Firmalar eklenebilmekte, kullanıcı ve admin
giris¸i yapılabilmektedir. Kullanıcı diledigi kadar yolcu ek- ˘
leyip, istedigi rotayı sec¸ebilmektedir. M ˘ us¸terinin isterlerine uy- ¨
gun olarak firmaların eklenen seferleri goz¨ ukmektedir. Koltuk ¨
sec¸imini girilen yolcu sayısı kadar yapabilmektedir.
