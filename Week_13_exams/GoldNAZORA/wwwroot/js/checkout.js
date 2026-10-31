
document.addEventListener("DOMContentLoaded", function () {

    const cities = [
        "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı",
        "Aksaray", "Amasya", "Ankara", "Antalya",
        "Ardahan", "Artvin", "Aydın", "Balıkesir",
        "Bartın", "Batman", "Bayburt", "Bilecik",
        "Bingöl", "Bitlis", "Bolu", "Burdur",
        "Bursa", "Çanakkale", "Çankırı", "Çorum",
        "Denizli", "Diyarbakır", "Düzce", "Edirne",
        "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
        "Gaziantep", "Giresun", "Gümüşhane", "Hakkari",
        "Hatay", "Iğdır", "Isparta", "İstanbul",
        "İzmir", "Kahramanmaraş", "Karabük", "Karaman",
        "Kars", "Kastamonu", "Kayseri", "Kırıkkale",
        "Kırklareli", "Kırşehir", "Kilis", "Kocaeli",
        "Konya", "Kütahya", "Malatya", "Manisa",
        "Mardin", "Mersin", "Muğla", "Muş",
        "Nevşehir", "Niğde", "Ordu", "Osmaniye",
        "Rize", "Sakarya", "Samsun", "Siirt",
        "Sinop", "Sivas", "Şanlıurfa", "Şırnak",
        "Tekirdağ", "Tokat", "Trabzon", "Tunceli",
        "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak",
        "Kırşehir"
    ];

    const cityInput = document.getElementById("City");
    const cityList = document.getElementById("cityList");

    if (!cityInput || !cityList) {
        console.error("İl alanı veya cityList bulunamadı.");
        return;
    }

    cityList.innerHTML = ""; // İl listesinin içindeki eski seçenekleri temizler.
    cities.forEach(function (city) {
        const option = document.createElement("option");
        option.value = city;
        cityList.appendChild(option);
    });

    console.log("İl önerileri yüklendi.");
});