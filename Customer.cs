namespace WestcoastBank;

public class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Epost { get; set; } ="";
    public required string PhoneNumber { get; set; }="";
    List<Address> Address {get;} = [];

}
