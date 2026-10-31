
const cartCount = document.getElementById("cartCount");
const cartButton = document.getElementById("cartButton");

let cart = [];

document.querySelectorAll(".add-to-cart").forEach(button => {
    button.addEventListener("click", () => {
        const productName = button.dataset.name;

        cart.push(productName);

        // Sepet sayacı varsa güncelle
        if (cartCount) {
            cartCount.textContent = cart.length;
        }

        const originalText = button.textContent;
        button.textContent = "Sepete Eklendi ✓";

        setTimeout(() => {
            button.textContent = originalText;
        }, 1200);
    });
});

// Sepet butonu varsa tıklama olayını ekle
if (cartButton) {
    cartButton.addEventListener("click", () => {
        if (cart.length === 0) {
            alert("Sepetiniz şu anda boş.");
            return;
        }

        alert(
            "Sepetinizdeki ürünler:\n\n" +
            cart.map((product, index) =>
                `${index + 1}. ${product}`
            ).join("\n")
        );
    });
}
