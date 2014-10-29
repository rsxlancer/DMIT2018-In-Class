<Query Kind="Expression">
  <Connection>
    <ID>035ab7e5-cd77-4241-a2c0-b2b8bb63961e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//how many customers per hour on september 15, 2014
from info in Bills
where info.BillDate.Year == 2014
	&& info.BillDate.Month == 9
	&& info.BillDate.Day == 15
group info by info.BillDate.Hour into infoGroup
select new
{
	Hour = infoGroup.Key,
	CustomerBillCount = infoGroup.Count(),
	CustomersCount = infoGroup.Sum(x=>x.NumberInParty)
}