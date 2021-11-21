using GiftSuggestion.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GiftSuggestion.Repository
{
    public interface IGiftRepository
    {
        //Criar o método crud para gravar os dados na base



        Task<int> Gravar(GiftModel gift);
    }
}
