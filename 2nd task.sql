--так как в задании не указан dll таблиц и у нас связь М-М, то предполагаю что должна быть промежуточная таблица, хранящая связи
--пусть продукты лежат в таблице 	Products(id,name), 
--категории в таблице 				Categories(id,name)
--связи в таблице 					ProductCategoriesRel(productId,categoryId)

select pr.name as "Товар", cat.name as "Категория"
from Products pr
left join ProductCategoriesRel rel on pr.id = rel.productId
left join Categories cat on rel.categoryId = cat.id
