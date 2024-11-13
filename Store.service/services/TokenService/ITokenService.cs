using Store.Data.Entities.IdentityEntites;

namespace Store.service.services.TokenService
{
    public interface ITokenService
    {
        string GenerateToken(AppUser appUser);
    }
}
