namespace WestcoastBank;

public class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Epost { get; set; }
    public string? PhoneNumber { get; set; }
    List<Address> Addresses {get; set;} = [];

}
