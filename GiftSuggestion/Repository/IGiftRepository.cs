using GiftSuggestion.Models;

namespace GiftSuggestion.Repository
{
    interface IGiftRepository
    {
        //Criar o método crud para gravar os dados na base

        void Gravar(GiftModel gift);
    }
}
