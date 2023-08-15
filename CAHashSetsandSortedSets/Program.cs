// See https://aka.ms/new-console-template for more information

using CAHashSetsandSortedSets;

//var cust1 = new Customer { Name = "Essam A", Telephone = "+1 123 123 4533" };
//var cust2 = new Customer { Name = "Essam A", Telephone = "+1 123 123 4533" };
//Console.WriteLine(cust1.Name.GetHashCode());             // -> print -346360240
//Console.WriteLine(cust1.Equals(cust2));                  // -> True
//Console.WriteLine(object.ReferenceEquals(cust1,cust2));  // -> False

var customers = new List<Customer>
{
    new Customer { Name = "Issam A", Telephone = "+1 123 123 4565" },
    new Customer { Name = "Reem S", Telephone = "+1 123 123 4566" },
    new Customer { Name = "Issam B", Telephone = "+1 123 123 4567" },
    new Customer { Name = "Abeer A", Telephone = "+1 123 123 4568" },
    new Customer { Name = "Salem D", Telephone = "+1 123 123 4569" } 
};
Console.WriteLine("Hashset");
Console.WriteLine("-------");
var custhashSet1 = new HashSet<Customer>(customers);
//custhashSet1.Add(new Customer { Name = "Issam X", Telephone = "+1 123 123 4563" });

var customers2 = new List<Customer>
{
    new Customer { Name = "Essam A", Telephone = "+1 123 123 4533" },
    new Customer { Name = "Rim S", Telephone = "+1 123 123 4554" }
};

var custhashSet2 = new HashSet<Customer>(customers2);

custhashSet1.UnionWith(custhashSet2);      // للدمج

foreach (var item in custhashSet1) 
    Console.WriteLine(item);




Console.ReadKey();












