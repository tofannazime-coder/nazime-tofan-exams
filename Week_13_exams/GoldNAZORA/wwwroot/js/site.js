
document.addEventListener("DOMContentLoaded", function () {

    // Sepeti getir
    function getCart() {
        try {
            return JSON.parse(localStorage.getItem("goldNazoraCart")) || [];
        } catch {
            return [];
        }
    }

    // Sepeti kaydet
    function saveCart(cart) {
        localStorage.setItem("goldNazoraCart", JSON.stringify(cart));
    }

    // Fiyatı sayıya çevir
    function parsePrice(priceText) {
        return Number(
            String(priceText)
                .replace(/[^\d,.-]/g, "")
                .replace(/\./g, "")
                .replace(",", ".")
        ) || 0;
    }

    // Fiyatı TL olarak göster
    function formatPrice(price) {
        return price.toLocaleString("tr-TR", {
            style: "currency",
            currency: "TRY",
            maximumFractionDigits: 2
        });
    }

    // Sepetteki toplam ürün adedini güncelle
    function updateCartCount() {
        const cartCount = document.getElementById("cartCount");
        if (!cartCount) return;

        const cart = getCart();

        const totalQuantity = cart.reduce(
            (total, item) => total + item.quantity,
            0
        );

        cartCount.textContent = totalQuantity;
    }

    // Ürünleri sepete ekle
    document.querySelectorAll(".add-to-cart").forEach(function (button) {
        button.addEventListener("click", function () {

            const name = button.dataset.name;
            const price = parsePrice(button.dataset.price);
            const image = button.dataset.image;

            if (!name || !image || price <= 0) {
                alert("Ürün bilgileri eksik. Lütfen kontrol et.");
                return;
            }

            const cart = getCart();
            const existingProduct = cart.find(item => item.name === name);

            if (existingProduct) {
                existingProduct.quantity++;
            } else {
                cart.push({
                    name: name,
                    price: price,
                    image: image,
                    quantity: 1
                });
            }

            saveCart(cart);
            updateCartCount();

            const originalText = button.textContent;
            button.textContent = "Sepete Eklendi ✓";

            setTimeout(function () {
                button.textContent = originalText;
            }, 1200);
        });
    });

    // Sepet sayfasını oluştur
    function renderCart() {
        const cartItems = document.getElementById("cartItems");
        const emptyCart = document.getElementById("emptyCart");
        const cartTotal = document.getElementById("cartTotal");
        const cartSummary = document.getElementById("cartSummary");

        // Sepet sayfasında değilsek işlemi durdur
        if (!cartItems || !cartTotal) return;

        const cart = getCart();
        cartItems.innerHTML = "";

        if (cart.length === 0) {
            if (emptyCart) emptyCart.style.display = "block";
            if (cartSummary) cartSummary.style.display = "none";

            cartTotal.textContent = formatPrice(0);
            return;
        }

        if (emptyCart) emptyCart.style.display = "none";
        if (cartSummary) cartSummary.style.display = "block";

        cart.forEach(function (item, index) {

            const row = document.createElement("div");
            row.className = "cart-product-row";

            const image = document.createElement("img");
            image.src = item.image;
            image.alt = item.name;
            image.className = "cart-product-image";

            const details = document.createElement("div");
            details.className = "cart-product-details";

            const name = document.createElement("h3");
            name.textContent = item.name;

            const price = document.createElement("p");
            price.textContent =
                "Birim fiyat: " + formatPrice(item.price);

            // Ürün adedini değiştirme alanı
            const quantityControls = document.createElement("div");
            quantityControls.className = "quantity-controls";

            const decreaseButton = document.createElement("button");
            decreaseButton.type = "button";
            decreaseButton.className = "quantity-button";
            decreaseButton.textContent = "−";

            const quantityText = document.createElement("span");
            quantityText.className = "quantity-number";
            quantityText.textContent = item.quantity;

            const increaseButton = document.createElement("button");
            increaseButton.type = "button";
            increaseButton.className = "quantity-button";
            increaseButton.textContent = "+";

            // Adedi azalt
            decreaseButton.addEventListener("click", function () {
                const cart = getCart();
                const product = cart[index];

                if (!product) return;

                if (product.quantity > 1) {
                    product.quantity--;
                } else {
                    // Adet 1 ise ürün sepetten çıkar
                    cart.splice(index, 1);
                }

                saveCart(cart);
                updateCartCount();
                renderCart();
            });

            // Adedi artır
            increaseButton.addEventListener("click", function () {
                const cart = getCart();
                const product = cart[index];

                if (!product) return;

                product.quantity++;

                saveCart(cart);
                updateCartCount();
                renderCart();
            });

            quantityControls.append(
                decreaseButton,
                quantityText,
                increaseButton
            );

            const subtotal = document.createElement("p");
            subtotal.textContent =
                "Ara toplam: " +
                formatPrice(item.price * item.quantity);

            const removeButton = document.createElement("button");
            removeButton.type = "button";
            removeButton.className = "cart-remove-button";
            removeButton.textContent = "Ürünü Sil";

            removeButton.addEventListener("click", function () {
                const updatedCart = getCart();

                updatedCart.splice(index, 1);

                saveCart(updatedCart);
                updateCartCount();
                renderCart();
            });

            details.append(
                name,
                price,
                quantityControls,
                subtotal,
                removeButton
            );
            row.append(image, details);
            cartItems.appendChild(row);
        });

        // Sepetin toplam tutarını hesapla
        const total = cart.reduce(
            (sum, item) => sum + item.price * item.quantity,
            0
        );

        cartTotal.textContent = formatPrice(total);
    }

    // Sepeti onayla: teslimat bilgileri sayfasına git
    const checkoutButton = document.getElementById("checkoutButton");

    if (checkoutButton) {
        checkoutButton.addEventListener("click", function () {

            const cart = getCart();

            if (cart.length === 0) {
                alert("Sepetinizde ürün bulunmuyor.");
                return;
            }

            // Sepeti silmeden teslimat sayfasına yönlendir
            window.location.href = "/Cart/Checkout";
        });
    }

    // Sayfa açıldığında sepeti güncelle
    updateCartCount();
    renderCart();

});


