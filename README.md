# Personel Takip Sistemi (PTS)

![Lisans](https://img.shields.io/badge/lisans-MIT-blue.svg)
![Dil](https://img.shields.io/badge/dil-C%23-orange.svg)
![Veritabanı](https://img.shields.io/badge/veritabanı-SQL%20Server-red.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg)

Microsoft SQL Server 2022 veritabanı ile entegre, C# Windows Forms (.NET Framework) kullanılarak geliştirilmiş kapsamlı bir Personel Takip Sistemi masaüstü uygulaması.

> [!NOTE]
> *Uygulama Genel Olarak Bu Şekilde Gözükmektedir.*

![PTS Ana Ekranı](https://i.imgur.com/dBHZkbR.png) 
*(Ekran Görüntüsü)*

---

## 🚀 Proje Hakkında

Bu proje, bir şirketin insan kaynakları (İK) departmanının ihtiyaç duyabileceği tüm temel fonksiyonları barındıran, modüler ve yönetilebilir bir personel takip sistemi (PTS) olarak tasarlanmıştır. Sıfırdan başlayarak, adım adım modern bir masaüstü uygulaması geliştirme sürecini kapsamaktadır. Güvenli giriş sisteminden, anlık veri sunan gösterge paneline, detaylı filtreleme ve profesyonel raporlama (Excel'e aktarma) özelliklerine kadar birçok modern uygulama tekniğini barındırır.

---

## ✨ Özellikler

Proje, aşağıdaki modül ve yetenekleri içermektedir:

* 🔐 **Güvenli Giriş Sistemi:** Kullanıcı adı ve şifre ile giriş. Şifreler veritabanında SHA256 ile hash'lenerek güvenli bir şekilde saklanır.
* 📊 **Gösterge Paneli (Dashboard):** Sisteme giriş yapıldığında kullanıcıyı karşılayan, kritik İK metriklerini (toplam personel, bekleyen izinler, ödenmemiş mesailer vb.) anlık olarak gösteren özet ekranı.
* 👤 **Personel Yönetimi:** Personel ekleme, düzenleme, listeleme ve pasif hale getirme (soft-delete).
* 🏢 **Tanımlamalar:**
    * Departman Yönetimi (Ekle/Güncelle/Sil)
    * Unvan Yönetimi (Ekle/Güncelle/Sil)
* ✈️ **İzin Yönetimi:**
    * Personel için yeni izin talebi oluşturma.
    * Tüm izin taleplerini listeleme ve yönetici tarafından onaylama/reddetme.
* 💻 **Zimmet Yönetimi:**
    * Personele şirket varlıklarını (laptop, telefon vb.) atama.
    * Tüm zimmet kayıtlarını listeleme ve iade alma.
* 💰 **Maaş Geçmişi:** Personel detay ekranından ilgili personelin geçmiş tüm maaş kayıtlarını görüntüleme.
* ⏰ **Fazla Mesai Yönetimi:**
    * Personel için fazla mesai kaydı oluşturma.
    * Tüm mesai kayıtlarını listeleme ve "ödendi" olarak işaretleme.
* 🔍 **Gelişmiş Filtreleme:** Tüm listeleme ekranlarında (Personel, İzin, Zimmet, Fazla Mesai) birden çok kritere göre (isim, departman, durum, tarih aralığı vb.) dinamik filtreleme.
* 📄 **Profesyonel Raporlama:**
    * Tüm listeleme ekranlarındaki verileri tek tuşla `.xlsx` (Excel) formatında dışa aktarma.
    * [ClosedXML](https://github.com/ClosedXML/ClosedXML) kütüphanesi kullanılarak oluşturulan, başlıkları kalın ve sütunları otomatik ayarlanmış profesyonel raporlar.
* ✨ **Modern Arayüz ve Kullanılabilirlik:**
    * Sekmeli ana form yapısı.
    * Uygulamanın her yerinden ulaşılabilen menü.
    * Giriş yapan kullanıcıyı ve saati gösteren durum çubuğu.
    * Standart "Hakkında" penceresi.

---

## 🛠️ Kullanılan Teknolojiler

* **Programlama Dili:** C#
* **Platform:** .NET Framework 4.7.2
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** Microsoft SQL Server 2022
* **Veri Erişimi:** ADO.NET
* **Excel Kütüphanesi:** ClosedXML (NuGet üzerinden)
* **Geliştirme Ortamı:** Visual Studio 2022
* **Versiyon Kontrol:** Git & GitHub

---

## 🏁 Kurulum ve Başlatma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin.

1.  **Ön Gereksinimler**
    * Visual Studio 2022 (veya uyumlu bir sürüm)
    * Microsoft SQL Server (2022 veya uyumlu bir sürüm) ve SQL Server Management Studio (SSMS)

2.  **Kurulum Adımları**
    * **Depoyu Klonlayın:**
        ```sh
        git clone [https://github.com/](https://github.com/)[GitHubKullaniciAdiniz]/[ProjeAdiniz].git
        ```
    * **Veritabanını Oluşturun:**
        1.  Proje içinde bulunan `.sql` script dosyasını SSMS ile açın.
        2.  Script'i çalıştırarak `pts_database` veritabanını, tabloları ve örnek verileri oluşturun.
    * **Bağlantı Cümlesini Ayarlayın:**
        1.  Solution Explorer'da, `App.config` dosyasını açın.
        2.  `connectionStrings` bölümündeki `Data Source` değerini kendi SQL Server sunucu adınızla değiştirin (örn: `.` veya `.\SQLEXPRESS`).
    * **NuGet Paketlerini Yükleyin:**
        1.  Solution Explorer'da projeye sağ tıklayın ve "Manage NuGet Packages..." seçeneğini seçin.
        2.  Açılan pencerede `ClosedXML` paketinin kurulu olduğundan emin olun. Değilse, "Restore" butonuna tıklayarak paketleri yükleyin.
    * **Uygulamayı Çalıştırın:**
        1.  Projeyi Visual Studio'da açın (`.sln` dosyası).
        2.  `F5` tuşuna basarak veya "Start" butonuna tıklayarak projeyi başlatın.
        3.  Giriş ekranına aşağıdaki bilgilerle giriş yapabilirsiniz:
            * **Kullanıcı Adı:** `admin`
            * **Şifre:** `12345`

---

## 📜 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına göz atın.

---

## 📬 İletişim

[Yusuf Toktaş] - [yusuf.toktas.32@gmail.com]

Proje Linki: [https://github.com/[yusuf-toktas]/[Personel-Takip-Sistemi]](https://github.com/yusuf-toktas/Personel-Takip-Sistemi)
