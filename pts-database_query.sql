create database pts_database;
use pts_database;

-- 1. BÖLÜM: TABLO OLUÞTURMA KODLARI
-- Temel Parametre ve Lookup Tablolarý
create table departmanlar (
    departman_id int identity(1,1) primary key,
    departman_adi nvarchar(100) not null unique
);

create table unvanlar (
    unvan_id int identity(1,1) primary key,
    unvan_adi nvarchar(100) not null unique
);

create table izin_turleri (
    izin_turu_id int identity(1,1) primary key,
    izin_turu_adi nvarchar(100) not null unique
);

create table belge_turleri (
    belge_turu_id int identity(1,1) primary key,
    belge_turu_adi nvarchar(100) not null unique
);

create table vardiya_tanimlari (
    vardiya_id int identity(1,1) primary key,
    vardiya_adi nvarchar(100) not null,
    baslangic_saati time not null,
    bitis_saati time not null
);

-- Ana ve Ýliþkili Personel Tablolarý
create table personel (
    personel_id int identity(1,1) primary key,
    ad nvarchar(50) not null,
    soyad nvarchar(50) not null,
    tc_kimlik_no nvarchar(11) not null unique,
    -- DÜZELTME: sgk_sicil_no birden fazla kiþi için boþ olabileceðinden UNIQUE kaldýrýldý.
    sgk_sicil_no nvarchar(30),
    personel_sicil_no nvarchar(20) unique,
    dogum_tarihi date not null,
    cinsiyet nvarchar(10),
    medeni_durum nvarchar(20),
    telefon_kisisel nvarchar(15) unique,
    eposta_is nvarchar(100) not null unique,
    -- DÜZELTME: eposta_kisisel birden fazla kiþi için boþ olabileceðinden UNIQUE kaldýrýldý.
    eposta_kisisel nvarchar(100),
    adres nvarchar(max),
    ise_giris_tarihi date not null,
    isten_ayrilma_tarihi date,
    aktif_mi bit not null default 1,
    calisma_sekli nvarchar(50),
    fotograf_yolu nvarchar(255),
    departman_id int,
    unvan_id int,
    yonetici_id int,
    foreign key (departman_id) references departmanlar(departman_id),
    foreign key (unvan_id) references unvanlar(unvan_id),
    foreign key (yonetici_id) references personel(personel_id)
);

create table maas_gecmisi (
    maas_id int identity(1,1) primary key,
    personel_id int not null,
    brut_maas decimal(18, 2) not null,
    baslangic_tarihi date not null,
    degisiklik_nedeni nvarchar(255),
    foreign key (personel_id) references personel(personel_id)
);

create table banka_hesaplari (
    hesap_id int identity(1,1) primary key,
    personel_id int not null,
    banka_adi nvarchar(100) not null,
    iban nvarchar(34) not null unique,
    birincil_hesap_mi bit not null default 0,
    foreign key (personel_id) references personel(personel_id)
);

create table izinler (
    izin_id int identity(1,1) primary key,
    personel_id int not null,
    izin_turu_id int not null,
    baslangic_tarihi datetime not null,
    bitis_tarihi datetime not null,
    izin_gun_sayisi decimal(4,1),
    aciklama nvarchar(500),
    talep_tarihi datetime default getdate(),
    onay_durumu nvarchar(20) default 'beklemede',
    onaylayan_personel_id int,
    foreign key (personel_id) references personel(personel_id),
    foreign key (izin_turu_id) references izin_turleri(izin_turu_id),
    foreign key (onaylayan_personel_id) references personel(personel_id)
);

create table zimmet (
    zimmet_id int identity(1,1) primary key,
    personel_id int not null,
    urun_adi nvarchar(150) not null,
    seri_numarasi nvarchar(100) unique,
    verilis_tarihi date not null,
    iade_tarihi date,
    aciklama nvarchar(500),
    foreign key (personel_id) references personel(personel_id)
);

create table personel_belgeleri (
    belge_id int identity(1,1) primary key,
    personel_id int not null,
    belge_turu_id int not null,
    belge_adi nvarchar(200) not null,
    yuklenme_tarihi datetime default getdate(),
    dosya_yolu nvarchar(255) not null,
    foreign key (personel_id) references personel(personel_id),
    foreign key (belge_turu_id) references belge_turleri(belge_turu_id)
);

create table personel_vardiyalari (
    personel_vardiya_id int identity(1,1) primary key,
    personel_id int not null,
    vardiya_id int not null,
    baslangic_tarihi date not null,
    bitis_tarihi date not null,
    foreign key (personel_id) references personel(personel_id),
    foreign key (vardiya_id) references vardiya_tanimlari(vardiya_id)
);

create table sirket_egitimleri (
    egitim_id int identity(1,1) primary key,
    egitim_adi nvarchar(200) not null,
    egitmen nvarchar(150),
    baslangic_tarihi datetime,
    bitis_tarihi datetime,
    konum nvarchar(200),
    aciklama nvarchar(max)
);

create table egitim_katilimlari (
    katilim_id int identity(1,1) primary key,
    personel_id int not null,
    egitim_id int not null,
    tamamlama_durumu bit default 0,
    puan int,
    sertifika_yolu nvarchar(255),
    foreign key (personel_id) references personel(personel_id),
    foreign key (egitim_id) references sirket_egitimleri(egitim_id)
);

create table duyurular (
    duyuru_id int identity(1,1) primary key,
    baslik nvarchar(200) not null,
    icerik nvarchar(max) not null,
    yayinlayan_id int not null,
    yayin_tarihi datetime default getdate(),
    gecerlilik_tarihi date,
    foreign key (yayinlayan_id) references personel(personel_id)
);

create table audit_log (
    log_id bigint identity(1,1) primary key,
    kullanici_id int,
    islem_turu nvarchar(50),
    tablo_adi nvarchar(100),
    kayit_id int,
    eski_deger nvarchar(max),
    yeni_deger nvarchar(max),
    islem_tarihi datetime default getdate(),
    aciklama nvarchar(500)
);

create table fazla_mesailer (
    mesai_id int identity(1,1) primary key,
    personel_id int not null,
    mesai_tarihi date not null,
    mesai_suresi_saat decimal(5, 2) not null,
    aciklama nvarchar(500),
    onaylayan_personel_id int,
    odendi_mi bit default 0,
    foreign key (personel_id) references personel(personel_id),
    foreign key (onaylayan_personel_id) references personel(personel_id)
);

create table kullanicilar (
    kullanici_id int identity(1,1) primary key,
    personel_id int unique,
    kullanici_adi nvarchar(50) not null unique,
    sifre_hash nvarchar(128) not null,
    foreign key (personel_id) references personel(personel_id)
);

-- 2. BÖLÜM: SÝSTEM KONTROLÜ ÝÇÝN ÖRNEK VERÝ GÝRÝÞLERÝ
insert into departmanlar (departman_adi) values ('Yönetim'), ('Bilgi Teknolojileri'), ('Ýnsan Kaynaklarý');
insert into unvanlar (unvan_adi) values ('Genel Müdür'), ('Yazýlým Geliþtirme Uzmaný'), ('Kýdemli Yazýlým Geliþtirici'), ('Ýnsan Kaynaklarý Müdürü'), ('Sistem Yöneticisi');
insert into izin_turleri (izin_turu_adi) values ('Yýllýk Ücretli Ýzin'), ('Hastalýk Raporu'), ('Ücretsiz Ýzin'), ('Babalýk Ýzni');
insert into belge_turleri (belge_turu_adi) values ('Ýþ Sözleþmesi'), ('Kimlik Fotokopisi'), ('Diploma'), ('Saðlýk Raporu');
insert into vardiya_tanimlari (vardiya_adi, baslangic_saati, bitis_saati) values ('Sabah Vardiyasý', '08:00:00', '16:00:00'), ('Akþam Vardiyasý', '16:00:00', '00:00:00');

insert into personel (ad, soyad, tc_kimlik_no, personel_sicil_no, dogum_tarihi, cinsiyet, medeni_durum, telefon_kisisel, eposta_is, ise_giris_tarihi, calisma_sekli, departman_id, unvan_id, yonetici_id)
values
('Ali', 'Yýlmaz', '11111111111', 'MD-001', '1975-05-10', 'erkek', 'evli', '5551112233', 'ali.yilmaz@sirket.com', '2010-02-01', 'tam zamanlý', 1, 1, null),
('Ayþe', 'Kaya', '22222222222', 'IK-001', '1988-11-20', 'kadýn', 'evli', '5552223344', 'ayse.kaya@sirket.com', '2015-08-15', 'tam zamanlý', 3, 4, 1),
('Mehmet', 'Çelik', '33333333333', 'BT-001', '1992-01-30', 'erkek', 'bekar', '5553334455', 'mehmet.celik@sirket.com', '2018-06-01', 'tam zamanlý', 2, 2, 1),
('Fatma', 'Demir', '44444444444', 'BT-002', '1990-07-25', 'kadýn', 'bekar', '5554445566', 'fatma.demir@sirket.com', '2017-03-20', 'hibrit', 2, 3, 1),
('Mustafa', 'Öztürk', '55555555555', 'BT-003', '1995-09-12', 'erkek', 'bekar', '5555556677', 'mustafa.ozturk@sirket.com', '2022-10-03', 'uzaktan', 2, 5, 1);

insert into maas_gecmisi (personel_id, brut_maas, baslangic_tarihi, degisiklik_nedeni)
values
(1, 45000.00, '2022-01-01', 'Yýllýk Zam'),
(2, 28000.00, '2022-01-01', 'Yýllýk Zam'),
(3, 25000.00, '2022-06-01', 'Ýþe Giriþ'),
(4, 32000.00, '2022-01-01', 'Performans Zammý'),
(5, 23000.00, '2022-10-03', 'Ýþe Giriþ');

insert into banka_hesaplari (personel_id, banka_adi, iban, birincil_hesap_mi)
values
(1, 'A Bankasý', 'TR110000111122223333444455', 1),
(3, 'B Bankasý', 'TR220000111122223333444466', 1);

insert into zimmet (personel_id, urun_adi, seri_numarasi, verilis_tarihi, aciklama)
values
(3, 'Dell XPS 15 Laptop', 'DXPS15-TR-12345', '2022-06-05', 'Yazýlým geliþtirme için tahsis edildi.');

insert into izinler (personel_id, izin_turu_id, baslangic_tarihi, bitis_tarihi, izin_gun_sayisi, aciklama, onay_durumu, onaylayan_personel_id)
values
(4, 1, '2023-08-14 09:00:00', '2023-08-18 18:00:00', 5, 'Yýllýk izin kullanýmý', 'onaylandý', 1);

insert into sirket_egitimleri(egitim_adi, egitmen, baslangic_tarihi, bitis_tarihi, konum)
values
('Ýleri Seviye SQL Server Performans Tuning', 'Ahmet Kurt', '2023-11-20 09:00:00', '2023-11-22 17:00:00', 'Online - Teams');

insert into egitim_katilimlari (personel_id, egitim_id, tamamlama_durumu)
values (3, 1, 0);

insert into duyurular (baslik, icerik, yayinlayan_id, gecerlilik_tarihi)
values
('Kurban Bayramý Tatili Hk.', 'Deðerli çalýþma arkadaþlarýmýz, Kurban Bayramý tatili nedeniyle 28 Haziran - 2 Temmuz tarihleri arasýnda resmi tatil olacaktýr. Ýyi bayramlar dileriz.', 2, '2023-07-03');

insert into audit_log (kullanici_id, islem_turu, tablo_adi, kayit_id, eski_deger, yeni_deger, aciklama)
values
(2, 'maaþ güncelleme', 'maas_gecmisi', 4, '28000.00', '32000.00', 'Fatma Demir için performans zammý yapýldý.');

insert into fazla_mesailer (personel_id, mesai_tarihi, mesai_suresi_saat, aciklama, odendi_mi) 
values
(
    3, -- Mehmet Çelik
    '2025-09-28', 
    3.5, 
    'Proje teslimatý için yapýlan ek çalýþma.',
    0  -- Henüz ödenmedi
),
(
    4, -- Fatma Demir
    '2025-10-02', 
    2.0, 
    'Kritik bir hatanýn gece giderilmesi.',
    0  -- Henüz ödenmedi
),
(
    5, -- Mustafa Öztürk
    '2025-09-15', 
    4.25, 
    'Hafta sonu acil sunucu bakýmý.',
    1  -- Ödendi olarak iþaretlenmiþ
);

-- Bu kullanýcýyý yöneticimiz olan Ali Yýlmaz (personel_id=1) ile iliþkilendirelim.
-- Kullanýcý Adý: admin
-- Þifre: 12345
-- '12345' þifresinin SHA256 HASH'i: 5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5
insert into kullanicilar (personel_id, kullanici_adi, sifre_hash)
values (
    1, 
    'admin', 
    '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5'
);