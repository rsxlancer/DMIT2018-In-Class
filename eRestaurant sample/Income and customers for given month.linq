<Query Kind="Statements">
  <Connection>
    <ID>035ab7e5-cd77-4241-a2c0-b2b8bb63961e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Get the following from the Bills table for the current month/year:
// BillDate, ID, # of people served, total amount billed
//Then, display the total income for the month and the number of customers served

// 0) Set up info that might be passed in to the BLL
var month = DateTime.Today.Month - 1;
var year = DateTime.Today.Year;
// 1) get the data for the month/year with a sum of each Bill's BillItems
var billsInMonth = from item in Bills
				   where item.PaidStatus //Only the bills that were/are paid
				   	&& item.BillDate.Month == month
					&& item.BillDate.Year == year
				   orderby item.BillDate
				   select new
				   {
				   		BillDate = item.BillDate,
						BillID = item.BillID,
						NumberOfCustomers = item.NumberInParty,
						TotalAmount = item.BillItems.Sum(bi => bi.Quantity * bi.SalePrice)
				   };
// billsInMonth.Dump();

//Temp: some variables for formatting
var monthName = DateTime.Today.AddMonths(-1).ToString("MMMM");
var title = string.Format("Total income for {0} {1}",monthName , year);

// Temp: Perform some quick aggregates to check my query
billsInMonth.Sum(tm => tm.TotalAmount).ToString("C").Dump(title, true);

billsInMonth.Sum(tm => tm.NumberOfCustomers).Dump("Patrons Served", true);

// 2) build a report from the billsInMonth data
var report = from item in billsInMonth
			 group item by item.BillDate.Day into dailySummary
			 select new
				{
					Day = dailySummary.Key,
					DailyCustomers = dailySummary.Sum(grp => grp.NumberOfCustomers),
					Income = dailySummary.Sum(grp => grp.TotalAmount)
				};
report.OrderBy(r => r.Day).Dump("DailyIncome");