using X.Api.Entities;

namespace X.Api.Data;

public class CustomerDataService
{
    public List<Customer> ListOfCustomers()
    {
        return new List<Customer>()
        {
            new()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Rajiv",
                LastName = "Yanamandra",
                Phone = "123456",
                Mobile = "123456",
                Gender = "Male"
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Siri",
                LastName = "Kanteti",
                Phone = "123456",
                Mobile = "123789",
                Gender = "Female"
            }
        };
    }
}