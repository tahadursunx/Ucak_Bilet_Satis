# Ucak_Bilet_Satis



tüm varlık kümeleri ve ilişkileri, bagajlar da dahil edilmiş şekilde:

1. **Müşteriler (Customers):**
   - Müşteri ID (PK)
   - Adı
   - Soyadı
   - Cinsiyet
   - Doğum tarihi
   - Telefon numarası
   - E-posta
   - Adres

2. **Uçuşlar (Flights):**
   - Uçuş numarası (PK)
   - Kalkış noktası
   - Varış noktası
   - Kalkış tarihi ve saati
   - Varış tarihi ve saati
   - Koltuk sayısı
   - Fiyat

3. **Biletler (Tickets):**
   - Bilet ID (PK)
   - Uçuş numarası (FK)
   - Müşteri ID (FK)
   - Koltuk numarası
   - Bilet fiyatı
   - Bilet tipi (ekonomi, iş, vb.)

4. **Ödeme Bilgileri (Payment Information):**
   - Ödeme ID (PK)
   - Bilet ID (FK)
   - Ödeme tarihi ve saati
   - Ödeme tutarı
   - Ödeme yöntemi

5. **Personel (Staff):**
   - Personel ID (PK)
   - Adı
   - Soyadı
   - Pozisyon
   - Departman
   - Maaş
   - İşe başlama tarihi

6. **Havaalanları (Airports):**
   - Havalimanı kodu (PK)
   - Havalimanı adı
   - Şehir
   - Ülke

7. **Uçaklar (Aircrafts):**
   - Uçak kodu (PK)
   - Model
   - Üretici
   - Koltuk sayısı
   - Ekonomi sınıfı koltuk sayısı
   - Business sınıfı koltuk sayısı
   - Koltuk düzeni
   - Kullanılabilirlik durumu

8. **Koltuklar (Seats):**
   - Koltuk ID (PK)
   - Uçak kodu (FK)
   - Koltuk numarası
   - Sınıf (ekonomi, iş, vb.)
   - Durum (boş, rezerve edilmiş, dolu)

9. **Havayolu Şirketleri (Airlines):**
   - Havayolu kodu (PK)
   - Havayolu adı
   - Ülke
   - İşletim merkezi
   - İletişim bilgileri (telefon numarası, e-posta, adres vb.)

10. **Bagajlar (Baggage):**
    - Bagaj ID (PK)
    - Bilet ID (FK)
    - Bagaj numarası
    - Ağırlık
    - Boyutlar
    - Durum (teslim edildi, kayıp, bulundu vb.)

İlişkiler:
- Müşteriler ve Biletler: Bir müşteri birden fazla bilet satın alabilir (1-N ilişkisi).
- Uçuşlar ve Biletler: Bir uçuşta birden fazla bilet satılabilir (1-N ilişkisi).
- Ödeme Bilgileri ve Biletler: Bir bilet için bir ödeme yapılabilir (1-1 ilişkisi).
- Personel ve Uçuşlar: Bir personel birçok uçuşa atanabilir (1-N ilişkisi).
- Havaalanları ve Uçuşlar: Bir havaalanından birden fazla uçuş gerçekleştirilebilir (1-N ilişkisi).
- Uçuşlar ve Uçaklar: Bir uçuş, belirli bir uçağa atanır (1-1 ilişkisi).
- Uçaklar ve Koltuklar: Bir uçağın birden fazla koltuğu olabilir (1-N ilişkisi).
- Koltuklar ve Biletler: Her bir koltuk bir veya daha fazla bilete atanabilir (1-N ilişkisi).
- Havayolu Şirketleri ve Uçaklar: Bir havayolu şirketi birden fazla uçağa sahip olabilir (1-N ilişkisi).
- Havayolu Şirketleri ve Uçuşlar: Bir havayolu şirketi birden fazla uçuş gerçekleştirebilir (1-N ilişkisi).
- Havayolu Şirketleri ve Personel: Bir havayolu şirketi bünyesinde birçok personel istihdam edebilir (1-N ilişkisi).
- Biletler ve Bagajlar: Bir bilet için bir veya daha fazla bagaj olabilir (1-N ilişkisi).

Bu tablo yapısı, uçak bileti satış otomasyonu projeniz için kapsamlı bir veritabanı modelini temsil eder. Bu model, sisteminizin gereksinimlerine ve kullanım senaryolarına bağlı olarak daha da genişletilebilir veya özelleştirilebilir.
