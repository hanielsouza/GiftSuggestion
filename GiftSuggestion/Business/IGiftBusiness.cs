using GiftSuggestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftSuggestion.Business
{
    public interface IGiftBusiness
    {
        Task<GiftModel> Cadastrar(GiftModel model);
    }
}
