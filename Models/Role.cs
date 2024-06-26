using System.Collections.Generic;

public class Role
{
    public int RoleId { get; set; }
    public string Name { get; set; }

    public ICollection<Account> Accounts { get; set; }
}