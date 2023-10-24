SELECT S.BuyerEmail
FROM Sales S
INNER JOIN SalesDetails SD ON S.SaleID = SD.SaleID
GROUP BY S.BuyerEmail, S.SaleDate
HAVING SUM(SD.ProductQuantity * SD.ProductPrice) / COUNT(DISTINCT S.SaleDate) > 1000;
