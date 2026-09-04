-- 1. Customer tablosundaki bütün kolonlar.
SELECT *
FROM Customer


-- 2. Müşteri kartı özeti.
SELECT 
    c.CompanyName, 
    c.City, 
    c.ContractType
FROM Customer c


-- 3. Araçların plaka, tipi ve kapasitesi.
SELECT 
    v.Plate, 
    v.VehicleType, 
    v.CapacityTon
FROM Vehicle v


-- 4. Şoför ad soyad ve ehliyet sınıfı.
SELECT 
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    d.LicenseClass
FROM Driver d


-- 5. Toplam sevkiyat sayısı.
SELECT 
    COUNT(*) AS SevkiyatSayisi
FROM Shipment s


-- 6. Varış şehirlerinin tekrarsız listesi.
SELECT 
    DISTINCT 
    s.DestCity
FROM Shipment s
ORDER BY s.DestCity ASC


-- 7. Araç tiplerinin tekrarsız listesi.
SELECT 
    DISTINCT 
    v.VehicleType
FROM Vehicle v
ORDER BY v.VehicleType ASC


-- 8. Aktif müşteriler.
SELECT 
    c.CompanyName, 
    c.City, 
    c.ContractType
FROM Customer c
WHERE IsActive = 1


-- 9. Pasif müşteriler.
SELECT 
    c.CompanyName, 
    c.City
FROM Customer c
WHERE IsActive = 0


-- 10. 20.000'den büyük navlunlar.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.Freight
FROM Shipment s
WHERE s.Freight > 20000
ORDER BY s.Freight DESC


-- 11. 21.000 veya daha fazla navlun.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.Freight
FROM Shipment s
WHERE s.Freight >= 21000
ORDER BY s.Freight DESC


-- 12. 200 km'den kısa mesafeler.
SELECT 
    s.OriginCity, 
    s.DestCity, 
    s.DistanceKm, 
    s.Freight
FROM Shipment s
WHERE s.DistanceKm < 200


-- 13. 155 km veya daha kısa mesafeler.
SELECT 
    s.OriginCity, 
    s.DestCity, 
    s.DistanceKm, 
    s.Freight
FROM Shipment s
WHERE s.DistanceKm <= 155
ORDER BY s.DistanceKm ASC


-- 14. 10.000 ile 20.000 arası navlun.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.Freight
FROM Shipment s
WHERE s.Freight BETWEEN 10000 AND 20000
ORDER BY s.Freight ASC


-- 15. Yolda olan sevkiyatlar.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.ShipDate, 
    s.Freight
FROM Shipment s
WHERE s.Status = 'Yolda'


-- 16. Teslim edilmiş sevkiyatlar yeniden eskiye sıralar.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.ShipDate, 
    s.Freight
FROM Shipment s
WHERE s.Status = 'Teslim'
ORDER BY s.ShipDate DESC


-- 17. Spot sözleşmeli müşteriler.
SELECT 
    c.CompanyName, 
    c.Email
FROM Customer c
WHERE c.ContractType = 'Spot'


-- 18. Tir tipi araçlar.
SELECT 
    v.Plate, 
    v.CapacityTon
FROM Vehicle v
WHERE v.VehicleType = 'Tir'


-- 19. CE ehliyetli şoförler.
SELECT 
	d.FirstName || ' ' || d.LastName AS AdSoyad,
	d.HireDate,
	d.Phone
FROM Driver d
WHERE d.LicenseClass = 'CE'


-- 20. Firma adında Gida geçen müşteriler.
SELECT 
    c.CompanyName
FROM Customer c
WHERE c.CompanyName LIKE '%Gida%';


-- 21. Plakası 34 ile başlayan araçlar.
SELECT 
	v.Plate
FROM Vehicle v
WHERE v.Plate LIKE '34%'



-- 22. Varış şehrinde "an" geçen sevkiyatlar.
SELECT 
    s.OriginCity, 
    s.DestCity
FROM Shipment s
WHERE s.DestCity LIKE '%an%'
ORDER BY s.OriginCity

-- 23. Soyadında Demir geçen şoförler.
SELECT
	d.FirstName,
	UPPER(d.LastName) AS LastName
FROM Driver d
WHERE d.LastName LIKE '%DEMİR%'

SELECT
	*
FROM Driver d
WHERE d.LastName LIKE '%Demir%' OR d.LastName LIKE '%demir%'


-- 24. Yolda veya Planlandi durumundaki sevkiyatlar.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.ShipDate
FROM Shipment s
WHERE Status IN ('Yolda', 'Planlandı')


-- 25. Çıkış şehri Izmir veya Istanbul olanlar.
SELECT 
    s.ShipmentId, 
    s.OriginCity, 
    s.DestCity, 
    s.Freight
FROM Shipment s
WHERE s.OriginCity IN ('Izmir', 'Istanbul')
ORDER BY s.Freight DESC


-- 26. İptal edilmemiş sevkiyatlar.

SELECT 
	ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.Status,
	s.Freight
FROM Shipment s
WHERE s.Status NOT IN ('Iptal')
ORDER BY ShipDate


-- 27. Tır olmayan araçlar.
SELECT 
    v.Plate, 
    v.VehicleType, 
    v.CapacityTon
FROM Vehicle v
WHERE v.VehicleType != 'Tir'


-- 28. E-postası olmayan müşteriler.
SELECT 
    c.CompanyName, 
    c.City
FROM Customer c
WHERE c.Email IS NULL


-- 29. Telefonu olmayan şoförler.
SELECT 
    d.FirstName, 
    d.LastName, 
    d.LicenseClass
FROM Driver d
WHERE d.Phone IS NULL


-- 30. Teslim tarihi girilmemiş sevkiyatlar.
SELECT 
	s.ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.ShipDate,
	s.Status
FROM Shipment s
WHERE s.DeliverDate IS NULL

-- 31. Teslim tarihi dolu olan sevkiyatlar.
SELECT 
	s.ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.ShipDate,
	s.Status
FROM Shipment s
WHERE s.DeliverDate IS NOT NULL
ORDER BY s.DeliverDate DESC


-- 32. 2026 yılında yola çıkan sevkiyatlar.
SELECT
	s.ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.ShipDate,
	s.Status
FROM Shipment s
WHERE strftime('%Y', s.ShipDate) = '2026'
ORDER BY s.ShipDate


-- 33. Ağustos ayında yola çıkan sevkiyatlar.
SELECT
	s.ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.ShipDate,
	s.Status
FROM Shipment s
WHERE strftime('%m', s.ShipDate) = '08'
ORDER BY s.ShipDate DESC


-- 34. 2025 yılının ilk yarısında çıkan işler.
SELECT
	s.ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.ShipDate,
	s.Status
FROM Shipment s
WHERE ShipDate BETWEEN '2025-01-01' AND '2025-06-30'
ORDER BY s.ShipDate 


-- 35. Tüm sevkiyatları navluna göre sıralama.
SELECT 
	s.ShipmentId,
	s.OriginCity || ' - ' || s.DestCity AS Route,
	s.Freight,
	s.Status
FROM Shipment s
ORDER BY s.Freight DESC


-- 36. Şoförleri soyada, sonra ada göre sıralama.
SELECT
	*
FROM Driver d
ORDER BY d.LastName, d.FirstName


-- 37. Her müşterinin sevkiyat sayısı.

SELECT 
	c.CompanyName,
	COUNT(s.ShipmentId) AS SevkiyatSayisi
FROM Customer c
	JOIN Shipment s ON c.CustomerId = s.CustomerId
GROUP BY c.CompanyName, c.CustomerId
ORDER BY SevkiyatSayisi DESC


-- 38. Duruma göre sevkiyat sayısı.
SELECT
	s.Status,
	COUNT(s.ShipmentId) AS Adet
FROM Shipment s
GROUP BY s.Status
ORDER BY Adet DESC


-- 39. Araç tipine göre araç sayısı.
SELECT
	v.VehicleType,
	COUNT(v.VehicleId) AS Adet
FROM Vehicle v
GROUP BY v.VehicleType
ORDER BY Adet DESC


-- 40. Ortalama navlunu 15.000'den yüksek müşteriler.
SELECT
	c.CompanyName,
	COUNT(s.ShipmentId) AS SevkiyatSayisi,
	AVG(s.Freight) AS OrtalamaNavlun
FROM Shipment s
	JOIN Customer c ON s.CustomerId = c.CustomerId
GROUP BY c.CompanyName
HAVING OrtalamaNavlun > 15000
ORDER BY OrtalamaNavlun DESC


-- 41. En az 4 sevkiyatı olan şoförler.
SELECT d.FirstName || ' ' || d.LastName AS AdSoyad,
   COUNT(s.ShipmentId) AS SevkiyatSayisi
FROM Driver d
INNER JOIN Shipment s
    ON d.DriverId = s.DriverId
GROUP BY d.DriverId, d.FirstName, d.LastName
HAVING COUNT(*) >= 4
ORDER BY SevkiyatSayisi DESC


-- 42. Sevkiyat ve müşteri bilgileri.
SELECT 
    s.ShipmentId,
    c.CompanyName,
    s.OriginCity,
    s.DestCity,
    s.Freight,
    s.Status
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
ORDER BY s.ShipDate ASC


-- 43. Sevkiyat + şoför + plaka.
SELECT 
    s.ShipmentId,
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    v.Plate,
    v.VehicleType,
    s.OriginCity,
    s.DestCity,
    s.Status
FROM Shipment s
INNER JOIN Driver d
    ON s.DriverId = d.DriverId
INNER JOIN Vehicle v
    ON s.VehicleId = v.VehicleId


-- 44. Tam operasyon satırı.
SELECT 
    s.ShipDate,
    c.CompanyName,
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    v.Plate,
    s.OriginCity,
    s.DestCity,
    s.Freight,
    s.Status
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
INNER JOIN Driver d
    ON s.DriverId = d.DriverId
INNER JOIN Vehicle v
    ON s.VehicleId = v.VehicleId
ORDER BY s.ShipDate DESC


-- 45. Tır ile yapılan ve teslim edilmiş işler.
SELECT 
    c.CompanyName,
    v.Plate,
    s.OriginCity,
    s.DestCity,
    s.Freight
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
INNER JOIN Vehicle v
    ON s.VehicleId = v.VehicleId
WHERE v.VehicleType = 'Tir'
  AND s.Status = 'Teslim'
ORDER BY s.Freight DESC


-- 46. Yolda hiç işi olmayan müşteriler.
SELECT 
    c.CompanyName,
    c.City
FROM Customer c
LEFT JOIN Shipment s
    ON c.CustomerId = s.CustomerId
   AND s.Status = 'Yolda'
WHERE s.ShipmentId IS NULL


-- 47. Telefonu olmayan şoförlerin teslim edilmiş sevkiyatları.
SELECT
	d.FirstName || ' ' || d.LastName AS AdSoyad,
	s.OriginCity || ' - ' || s.DestCity AS Guzergah,
	s.ShipDate,
	s.Freight
FROM Driver d
	JOIN Shipment s ON d.DriverId = s.DriverId
WHERE d.Phone IS NULL AND s.Status = 'Teslim'


-- 48. Navlun dilimi.
--10.000’den küçük → 'Düşük'
--10.000–20.000 (20.000 dahil) → 'Orta'
--20.000’den büyük → 'Yüksek' Kolon adı NavlunDilimi olsun.

SELECT 
    s.ShipmentId,
    s.OriginCity,
    s.DestCity,
    s.Freight,
       CASE
        WHEN s.Freight < 10000 THEN 'Dusuk'
		WHEN s.Freight <= 20000 THEN 'Orta'
		ELSE 'Yuksek'
       END AS NavlunDilimi
FROM Shipment s
ORDER BY s.Freight ASC


-- 49. Sevkiyat durumunu operasyon kuyruğuna çevirme.
SELECT s.ShipDate,
       c.CompanyName,
       s.OriginCity,
       s.DestCity,
       s.Freight,
       s.Status,
       CASE
           WHEN s.Status = 'Planlandi' THEN 'Bekliyor'
           WHEN s.Status = 'Yolda' THEN 'Sahada'
           WHEN s.Status = 'Teslim' THEN 'Kapandı'
           ELSE 'Iptal/Diger'
       END AS Kuyruk
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
WHERE s.OriginCity IN ('Izmir', 'Istanbul', 'Bursa')
ORDER BY Kuyruk ASC, s.ShipDate ASC


-- 50. Aktif şoförler + yoldaki seferlerin şoförleri.
SELECT FirstName || ' ' || LastName AS AdSoyad,
   'Aktif Sefer' AS Tip
FROM Driver
WHERE IsActive = 1

UNION

SELECT d.FirstName || ' ' || d.LastName AS AdSoyad,
   'Yoldaki Sefer' AS Tip
FROM Driver d
INNER JOIN Shipment s
    ON d.DriverId = s.DriverId
WHERE s.Status = 'Yolda'
ORDER BY Tip ASC, AdSoyad ASC