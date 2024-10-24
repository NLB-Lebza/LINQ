//this is filtering using linq


List <Customer> customers = new List<Customer>
{
    new Customer{Name ="ntsako",City ="johannesburg"},
    new Customer {Name="lebo", City="pta"},
    new Customer {Name="lungelo", City ="pta"}

};//dont forget the ;
var mycustomers = customers.Where(x => x.City == "pta");

foreach (var customer in mycustomers)
{
    Console.WriteLine(customer);
    
}

