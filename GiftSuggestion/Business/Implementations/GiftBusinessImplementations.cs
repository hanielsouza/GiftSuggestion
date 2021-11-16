using GiftSuggestion.Models;
using GiftSuggestion.Repository;
using System;
using System.Threading.Tasks;

namespace GiftSuggestion.Business.Implementations
{
    public class GiftBusinessImplementations : IGiftBusiness
    {
        private readonly IGiftRepository _repository;

        public GiftBusinessImplementations(IGiftRepository repository)
        {
            _repository = repository;
        }

        public async Task<GiftModel> Cadastrar(GiftModel model)
        {
            return await _repository.Gravar(model);
        }
        
    }
}
