<Query Kind="Expression">
  <Connection>
    <ID>035ab7e5-cd77-4241-a2c0-b2b8bb63961e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//This query is for pulling out dataa to be used in a 
//Details report. This query gets all the menu items 
//and their categories, sorting them by the category
//description and then by the menu item description
from cat in Items
orderby cat.MenuCategory.Description, cat.Description
select new
{
	CategoryDescription = cat.MenuCategory.Description,
	ItemDescription = cat.Description,
	Price = cat.CurrentPrice,
	Calories = cat.Calories,
	Comment = cat.Comment
}