using System.Collections.Generic;

public class AccountDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public List<ShoppingCartDto> Cart { get; set; }
}