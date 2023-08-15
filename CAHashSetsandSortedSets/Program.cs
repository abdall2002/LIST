// See https://aka.ms/new-console-template for more information

using CAHashSetsandSortedSets;

var cust1 = new Customer { Name = "Essam A", Telephone = "+1 123 123 4533" };
var cust2 = new Customer { Name = "Essam A", Telephone = "+1 123 123 4533" };
Console.WriteLine(cust1.Name.GetHashCode());             // -> print -346360240
Console.WriteLine(cust1.Equals(cust2));                  // -> True
Console.WriteLine(object.ReferenceEquals(cust1,cust2));  // -> False





Console.ReadKey();












