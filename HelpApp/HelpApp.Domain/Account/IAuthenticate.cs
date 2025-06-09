namespace HelpApp.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> Authenticated(string email, string password);
        Task<bool> RegisterUser(string email, string password);
        Task Logout();
    }
}
