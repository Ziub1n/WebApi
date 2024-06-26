using System.Threading.Tasks;

public interface IAccountService
{
    Task<AccountDto> GetAccountByIdAsync(int accountId);
}