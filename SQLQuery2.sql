-- Havayolu Þirketi
CREATE TABLE havayolu_sirketi (
    sirket_kodu VARCHAR(10) PRIMARY KEY,
    sirket_adi VARCHAR(255),
    bulundugu_ulke VARCHAR(255),
    isletim_merkezi VARCHAR(255),
    iletisim_bilgileri VARCHAR(255)
);

-- Havaalaný

CREATE TABLE havaalani (
    havaalani_kodu VARCHAR(10) PRIMARY KEY,
    havaalani_adi VARCHAR(255),
    sehir VARCHAR(255),
    ulke VARCHAR(255)
);

-- Uçak
CREATE TABLE ucak (
    ucak_kodu NVARCHAR(10) PRIMARY KEY,
    model VARCHAR(255),
    uretici VARCHAR(255),
    koltuk_sayisi INT,
    koltuk_duzeni NVARCHAR(255),
    havaalani_kodu VARCHAR(10),
    sirket_kodu VARCHAR(10),
    FOREIGN KEY (havaalani_kodu) REFERENCES havaalani(havaalani_kodu),
    FOREIGN KEY (sirket_kodu) REFERENCES havayolu_sirketi(sirket_kodu)
);

-- Uçuþ
CREATE TABLE ucus (
    ucus_no NVARCHAR(20) PRIMARY KEY,
    kalkis_noktasi VARCHAR(255),
    varis_noktasi VARCHAR(255),
    sirket_kodu VARCHAR(10),
    kalkis_tarihi_ve_saati DATETIME,
    inis_tarihi_ve_saati DATETIME,
    ucak_kodu NVARCHAR(10),
    kalkis_havaalani_kodu VARCHAR(10),
    varis_havaalani_kodu VARCHAR(10),
    FOREIGN KEY (sirket_kodu) REFERENCES havayolu_sirketi(sirket_kodu),
    FOREIGN KEY (ucak_kodu) REFERENCES ucak(ucak_kodu),
    FOREIGN KEY (kalkis_havaalani_kodu) REFERENCES havaalani(havaalani_kodu),
    FOREIGN KEY (varis_havaalani_kodu) REFERENCES havaalani(havaalani_kodu)
);   

-- Bilet
CREATE TABLE bilet (
    bilet_id NVARCHAR(15) PRIMARY KEY,
    ucus_no NVARCHAR(20),
    bilet_fiyati DECIMAL(10, 2),
    koltuk_numarasi NVARCHAR(10),
    musteri_id NVARCHAR(15),
    FOREIGN KEY (ucus_no) REFERENCES ucus(ucus_no) ON DELETE CASCADE,
    FOREIGN KEY (musteri_id) REFERENCES musteri(musteri_id)
);

-- Ödeme
CREATE TABLE odeme (
    odeme_id NVARCHAR(15) PRIMARY KEY,
    odeme_tarihi DATE DEFAULT GETDATE(),
    odeme_tutari DECIMAL(10, 2),
    odeme_yontemi VARCHAR(255),
    bilet_id NVARCHAR(15),
    FOREIGN KEY (bilet_id) REFERENCES bilet(bilet_id) ON DELETE CASCADE
);

-- Bagaj
CREATE TABLE bagaj (
    bagaj_id NVARCHAR(15) PRIMARY KEY,
    bilet_id NVARCHAR(15),
    agirlik DECIMAL(10, 2),
    boyut NVARCHAR(50),
    FOREIGN KEY (bilet_id) REFERENCES bilet(bilet_id) ON DELETE CASCADE
);

-- Müþteri
CREATE TABLE musteri (
    musteri_id NVARCHAR(15) PRIMARY KEY,
    ad VARCHAR(255),
    soyad VARCHAR(255),
    cinsiyet VARCHAR(10),
    dogum_tarihi DATE,
    telefon_numarasi VARCHAR(20),
    e_posta NVARCHAR(255) UNIQUE,
    adres NVARCHAR(250)
);

-- Tarife
CREATE TABLE tarife (
    tarife_kodu NVARCHAR(15) PRIMARY KEY,
    check_in NVARCHAR(10),
    yemek_durumu NVARCHAR(10),
    bagaj_kapasitesi DECIMAL(10, 2),
    bilet_id NVARCHAR(15) UNIQUE,
    koltuk_sinifi NVARCHAR(255),
    FOREIGN KEY (bilet_id) REFERENCES bilet(bilet_id) ON DELETE CASCADE
);



