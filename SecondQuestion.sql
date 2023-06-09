/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT TOP (1000) [Product].[Id]
      ,[Product].[Name]
	  ,Category.Name
  FROM [products].[dbo].[Product]
  left join products.dbo.ProductsCategories on ProductsCategories.productId = [Product].Id
  left join products.dbo.Category on Category.Id = ProductsCategories.CategoryId