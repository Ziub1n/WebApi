using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet("{accountId:int}")]
    public async Task<IActionResult> GetAccount(int accountId)
    {
        var account = await _accountService.GetAccountByIdAsync(accountId);
        if (account == null)
        {
            return NotFound();
        }
        return Ok(account);
    }
}