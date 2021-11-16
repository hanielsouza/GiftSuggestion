using GiftSuggestion.Models;
using System.Threading.Tasks;

namespace GiftSuggestion.Repository
{
    public interface IGiftRepository
    {
        Task<GiftModel> Gravar(GiftModel gift);
    }
}
