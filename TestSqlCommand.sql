-- Solve task by grouping

SELECT 
	"Products"."Title", ARRAY_AGG("Categories"."Name")
FROM "Products"
LEFT JOIN "ProductCategories" ON "ProductCategories"."ProductId" = "Products"."Id"
LEFT JOIN "Categories" ON "ProductCategories"."CategoryId" = "Categories"."Id"
GROUP BY "Products"."Title"; 

-- Solve task without grouping

SELECT 
	"Products"."Title", "Categories"."Name"
FROM "Products"
LEFT JOIN "ProductCategories" ON "ProductCategories"."ProductId" = "Products"."Id"
LEFT JOIN "Categories" ON "ProductCategories"."CategoryId" = "Categories"."Id";