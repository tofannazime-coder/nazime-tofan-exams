$(document).ready(function () {

    // Fiyat hesaplama fonksiyonu
    function calculatePrice() {

        // Temel paket fiyatı
        let basePrice = Number($("#eventType").val()) || 0;

        // Konuk sayısı
        let guestCount = Number($("#guestCount").val()) || 0;

        // Her konuk için 50 TL
        let guestPrice = guestCount * 50;

        // Ek hizmetlerin toplam fiyatı
        let extraPrice = 0;

        $(".extra-service:checked").each(function () {
            extraPrice += Number($(this).val()) || 0;
        });

        // Toplam fiyat
        let totalPrice = basePrice + guestPrice + extraPrice;


        // Fiyatları ekrana yazdır
        $("#basePrice").text(
            basePrice.toLocaleString("tr-TR") + " TL"
        );

        $("#guestPrice").text(
            guestPrice.toLocaleString("tr-TR") + " TL"
        );

        $("#extraPrice").text(
            extraPrice.toLocaleString("tr-TR") + " TL"
        );

        $("#totalPrice").text(
            totalPrice.toLocaleString("tr-TR") + " TL"
        );
    }


    // Etkinlik türü değiştiğinde fiyatı hesapla
    $("#eventType").on("change", function () {
        calculatePrice();
    });


    // Konuk sayısı değiştiğinde fiyatı hesapla
    $("#guestCount").on("input", function () {
        calculatePrice();
    });


    // Ek hizmet seçildiğinde fiyatı hesapla
    $(".extra-service").on("change", function () {

        let selectedService = $(this).data("service");

        // Hizmet seçildiyse uyarı göster
        if ($(this).is(":checked")) {

            $("#warningBox")
                .removeClass("d-none")
                .html(
                    "<strong>⚠️ Dikkat!</strong> " +
                    selectedService +
                    " seçildi. Bu hizmet toplam bütçenizi artıracaktır."
                );

        }
        // Hiçbir hizmet seçili değilse uyarıyı gizle
        else if ($(".extra-service:checked").length === 0) {

            $("#warningBox").addClass("d-none");
        }

        calculatePrice();
    });


    // Form gönderildiğinde
    $("#reservationForm").on("submit", function (event) {

        event.preventDefault();

        // Etkinlik türü seçilmemişse
        if ($("#eventType").val() === null) {

            alert("Lütfen etkinlik türünü seçiniz.");
            return;
        }


        // Konuk sayısını kontrol et
        let guestCount = Number($("#guestCount").val());

        if (guestCount < 1 || guestCount > 500) {

            alert("Konuk sayısı 1 ile 500 arasında olmalıdır.");
            return;
        }


        // Tarih kontrolü
        if ($("#eventDate").val() === "") {

            alert("Lütfen etkinlik tarihini seçiniz.");
            return;
        }


        // Başarı modalını aç
        let successModal = new bootstrap.Modal(
            document.getElementById("successModal")
        );

        successModal.show();
    });


    // Sayfa açıldığında ilk fiyatı hesapla
    calculatePrice();

});