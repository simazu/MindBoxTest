SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
	FROM Products
	LEFT JOIN Pairs ON Products.Id = Pairs.ProductId
	LEFT JOIN Categories ON Pairs.CategoryId = Categories.Id