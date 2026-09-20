# Event Manager 🎉

## 🇹🇷 Türkçe

**Event Manager**, etkinlik planlama ve rezervasyon işlemlerini kolaylaştırmak amacıyla geliştirilmiş bir web projesidir.

Bu proje, **INFOTECH ACADEMY** eğitim sürecinde verilen uygulama çalışmaları kapsamında geliştirilmiştir.

## 📌 Proje Hakkında

Event Manager ile kullanıcılar farklı etkinlik paketlerini inceleyebilir, etkinlik danışmanlarını görüntüleyebilir ve kendi etkinlikleri için rezervasyon oluşturabilir.

Rezervasyon formunda kullanıcıdan kişisel iletişim bilgileri, etkinlik türü, etkinlik tarihi, konuk sayısı, bütçe ve ek hizmet tercihleri alınır.

Seçilen etkinlik paketi, konuk sayısı ve ek hizmetlere göre toplam fiyat **anlık olarak hesaplanır.**

## ✨ Özellikler

* 🏠 Etkinlik paketlerinin listelenmesi
* 💒 Düğün Organizasyonu
* 🎯 Kurumsal Konferans
* 🎉 Doğum Günü Partisi
* 💍 Nişan Töreni
* 📸 Dış Çekim Paketi
* 🍽️ Catering Hizmetleri
* 👩‍💼 Etkinlik danışmanlarının listelenmesi
* 📋 JSON dosyasından danışman bilgilerinin alınması
* 📅 Etkinlik tarihi seçimi
* 👥 1–500 kişi arasında konuk sayısı
* 💰 Dinamik fiyat hesaplama
* ⚠️ Ek hizmet seçildiğinde anlık maliyet uyarısı
* 💌 Davetiye Yazdırma
* 🍽️ Uluslararası Catering
* 📸 Profesyonel Fotoğraf Çekimi
* 🌸 Özel Dekorasyon
* 📧 Ad Soyad, e-posta ve telefon bilgileri
* 📱 Responsive tasarım
* 🪟 Bootstrap Modal ile rezervasyon sonucu gösterimi

## 🛠️ Kullanılan Teknolojiler

* HTML5
* CSS3
* Bootstrap 5
* JavaScript
* jQuery
* JSON
* Google Fonts

## 💰 Fiyat Hesaplama

Rezervasyon toplam fiyatı aşağıdaki formüle göre hesaplanmaktadır:

**Temel Paket + (Konuk Sayısı × 50 TL) + Ek Hizmetler**

Örneğin:

```text
Düğün Organizasyonu      10.000 TL
100 Konuk                 5.000 TL
Özel Dekorasyon            4.000 TL
---------------------------------
Toplam                    19.000 TL
```

### Ek Hizmetler

| Hizmet                         |  Ek Ücret |
| ------------------------------ | --------: |
| 💌 Davetiye Yazdırma           | +3.000 TL |
| 🍽️ Uluslararası Catering      | +7.500 TL |
| 📸 Profesyonel Fotoğraf Çekimi | +5.000 TL |
| 🌸 Özel Dekorasyon             | +4.000 TL |

## 📂 Proje Yapısı

```text
EventManager
│
├── index.html
├── consultants.html
├── reservation.html
│
├── css
│   └── style.css
│
├── js
│   └── reservation.js
│
├── data
│   └── consultation.json
│
├── images
│   └── hero.jpg
│
└── README.md
```

## 📄 Sayfalar

### 🏠 Ana Sayfa

Ana sayfada etkinlik paketleri kartlar halinde gösterilmektedir.

Her kartta etkinlik türü, açıklama ve başlangıç fiyatı bulunmaktadır.

### 👩‍💼 Etkinlik Danışmanları

Danışman bilgileri `consultation.json` dosyasında tutulmaktadır.

Bu veriler kullanılarak danışmanların bilgileri web sayfasında görüntülenmektedir.

### 📝 Rezervasyon

Rezervasyon sayfasında kullanıcı;

* Ad Soyad
* E-posta
* Telefon
* Etkinlik türü
* Etkinlik tarihi
* Konuk sayısı
* Bütçe
* Özel istekler
* Ek hizmetler

bilgilerini seçebilir veya girebilir.

Ek hizmetler seçildiğinde toplam fiyat otomatik olarak güncellenmektedir.

## 🎨 Tasarım

Projede **Bootstrap 5** kullanılarak responsive ve kullanıcı dostu bir arayüz oluşturulmuştur.

Ayrıca özel tasarım için `style.css` dosyasında;

* Renk değişkenleri
* Kart tasarımları
* Hover efektleri
* Form stilleri
* Responsive düzen
* Hero alanı
* Footer tasarımı

gibi özel CSS düzenlemeleri kullanılmıştır.

Projede ayrıca **Google Fonts** üzerinden Inter yazı tipi kullanılmıştır.

## 🎯 Projenin Amacı

Bu projenin amacı, web geliştirme sırasında öğrenilen HTML, CSS, Bootstrap, JavaScript, jQuery ve JSON konularını gerçek bir etkinlik yönetim projesi üzerinde uygulamaktır.

Proje sayesinde özellikle:

* Bootstrap Grid kullanımı
* Navbar oluşturma
* Card tasarımları
* Form oluşturma
* Modal kullanımı
* JavaScript ile dinamik işlemler
* jQuery kullanımı
* JSON verileriyle çalışma
* Dinamik fiyat hesaplama
* Responsive web tasarımı

konularında pratik yapılmıştır.

---

# Event Manager 🎉

## 🇬🇧 English

**Event Manager** is a web project developed to make event planning and reservation processes easier.

This project was developed as part of the practical assignments during the **INFOTECH ACADEMY** training program.

## 📌 About the Project

With Event Manager, users can explore different event packages, view event consultants, and create reservations for their events.

The reservation form collects customer contact information, event type, event date, number of guests, budget, and additional service preferences.

The total price is calculated **dynamically** based on the selected package, number of guests, and additional services.

## ✨ Features

* 🏠 Event package listing
* 💒 Wedding Organization
* 🎯 Corporate Conference
* 🎉 Birthday Party
* 💍 Engagement Organization
* 📸 Outdoor Photography Package
* 🍽️ Catering Services
* 👩‍💼 Event consultant listing
* 📋 Consultant data stored in a JSON file
* 📅 Event date selection
* 👥 Guest count between 1–500
* 💰 Dynamic price calculation
* ⚠️ Instant cost warning for additional services
* 💌 Invitation Printing
* 🍽️ International Catering
* 📸 Professional Photography
* 🌸 Special Decoration
* 📧 Name, email, and phone information
* 📱 Responsive design
* 🪟 Reservation result displayed with Bootstrap Modal

## 🛠️ Technologies Used

* HTML5
* CSS3
* Bootstrap 5
* JavaScript
* jQuery
* JSON
* Google Fonts

## 💰 Price Calculation

The total reservation price is calculated using the following formula:

**Base Package + (Guest Count × 50 TL) + Additional Services**

For example:

```text
Wedding Organization     10,000 TL
100 Guests                5,000 TL
Special Decoration        4,000 TL
---------------------------------
Total                    19,000 TL
```

### Additional Services

| Service                     | Additional Fee |
| --------------------------- | -------------: |
| 💌 Invitation Printing      |      +3,000 TL |
| 🍽️ International Catering  |      +7,500 TL |
| 📸 Professional Photography |      +5,000 TL |
| 🌸 Special Decoration       |      +4,000 TL |

## 📂 Project Structure

```text
EventManager
│
├── index.html
├── consultants.html
├── reservation.html
│
├── css
│   └── style.css
│
├── js
│   └── reservation.js
│
├── data
│   └── consultation.json
│
├── images
│   └── hero.jpg
│
└── README.md
```

## 📄 Pages

### 🏠 Home Page

The home page displays different event packages as cards.

Each card contains the event type, a short description, and the starting price.

### 👩‍💼 Event Consultants

Consultant information is stored in the `consultation.json` file.

The consultant data is used to display consultant information on the web page.

### 📝 Reservation

On the reservation page, users can enter or select:

* Full Name
* Email
* Phone
* Event Type
* Event Date
* Number of Guests
* Budget
* Special Requests
* Additional Services

When additional services are selected, the total price is updated automatically.

## 🎨 Design

**Bootstrap 5** is used to create a responsive and user-friendly interface.

Custom styling is also provided through the `style.css` file, including:

* Color variables
* Card designs
* Hover effects
* Form styles
* Responsive layout
* Hero section
* Footer design

The project also uses the **Inter** font from Google Fonts.

## 🎯 Project Purpose

The purpose of this project is to practice HTML, CSS, Bootstrap, JavaScript, jQuery, and JSON through a real-world event management project.

The project provides practical experience with:

* Bootstrap Grid
* Navbar
* Card components
* Forms
* Bootstrap Modal
* Dynamic JavaScript operations
* jQuery
* JSON data
* Dynamic price calculation
* Responsive web design

---

## 👩‍💻 Developer

**Nazime Tofan**

Developed as part of the **INFOTECH ACADEMY** training program.
