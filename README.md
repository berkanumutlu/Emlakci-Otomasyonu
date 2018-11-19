# [C#] Emlakçı Otomasyonu
Emlakçı Otomasyonu projesi genel olarak;

  - Giriş Ekranı
  - Ana Menü ( Ev işlemlerinin yapıldığı bölüm )
  - Ev Düzenleme Ekranı
  - Yeni Ev Ekleme Ekranı
  - Ev Listeleme Ve Sorgulama Ekranı
  - Yeni Kullanıcı Kayıt Ekranı
  - Müşteri Ev Satış Ekranı
  - Satılan veya Kiralanan Evlerin Sorgulandığı Sorgulama Ekranı
  
özelliklerini içermektedir.
### Emlakçı Otomasyonu - Giriş Ekranı
Proje çalıştırıldığında önce Giriş Ekranı gösterilir. Varsayılan Kullanıcı adı: emlakçı, Şifre: giriş olarak ayarlanmıştır.
Kullanıcı bilgileri proje içerisinde bulunan "**users.txt**" adlı dosyada tutulmaktadır.

Kullanıcı
  - Yeni ev ekleme,
  - Silme,
  - Düzenleme ve
  - Sorgulama-listeleme
  
işlemlerini yapabilme yetkisine sahiptir.

### Emlakçı Otomasyonu - Kayıt Ekranı
Yeni eklenecek evle ilgili bilgiler bu form üzerinden gerekli kontroller yapılarak alınır. Bu bilgiler proje dosyası içerisinde bulunan "**satilik.txt**" ve "**kiralik.txt**" olmak üzere iki dosyada saklanır. Program kapatılıp yeniden açıldıktan sonra bu kayıtlara ulaşılabilmektedir.

### Emlakçı Otomasyonu - Sorgulama Ekranı
Müşterinin isteklerine göre sorgulama yaparak kayıtlar arasında uygun evleri arayıp bulan formdur. Sonuçlar bu form üzerinde listelenerek ve detaylarına ulaşmak için Kayıt Ekranına benzer bir form üzerinde kolay bir şekilde görüntülenebilmesi sağlanır. Sorgulama esnasında sadece aktif durumda olan evler varsayılan olarak taranır. Ancak opsiyonel olarak daha önce emlakçının elinde olan ama işlemi tamamlanmış evler de taranabilmektedir. Sorgulama Ekranından bulunan bir evin detaylarının görüntüleneceği Listeleme formu üzerinden düzenleme, silme ve arşivleme işlemeleri yapılabilmektedir.
Listeleme Ekranından evin görüntülerine de ulaşılabilir. İlgili eve ait görüntülerin bulunduğu Windows klasörü, program içinden bir buton ile açılabilmektedir.
