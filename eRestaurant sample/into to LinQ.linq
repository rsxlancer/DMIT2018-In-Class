<Query Kind="Statements">
  <Connection>
    <ID>035ab7e5-cd77-4241-a2c0-b2b8bb63961e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

/* Example 1: Querying data from eRestaurant */
var result = from row in Tables
			 where row.Capacity > 3
			 select row;

//the following won't work in a VS project...
result.Dump();//the.Dump() is an extension methof in linqpad- it's not in .NET

/*Example 2: Query a simple array of strings*/
string[] names = {"Dan", "Don", "Sam", "Dwayne", "laurel", "Steve"};
names.Dump();

var shortList = from person in names
				where person.StartsWith("D")
				select person;
shortList.Dump();

/*Example 3: Find the most recent Bill and its total*/
//Get all the bills that have been placed
var allBills = from thingy in Bills
			   where thingy.OrderPlaced.HasValue
			   select new//declaring an "anonymous type" on-the-fly
				{		 //using an initializer list to set the properties
					BillDate = thingy.BillDate,
					IsReady = thingy.OrderReady
				};
allBills.Count().Dump();//show count of items
allBills.Take(5).Dump();//show the first 5 bills