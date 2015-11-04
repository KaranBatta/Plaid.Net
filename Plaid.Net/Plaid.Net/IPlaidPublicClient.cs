using Plaid.Net.response;

namespace Plaid.Net
{
    public interface IPlaidPublicClient
    {
        InstitutionsResponse GetAllInstitutions();
        CategoriesResponse GetAllCategories();
    }
}
