﻿using GiftSuggestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftSuggestion.Repository
{
    public class GiftImplementation : IGiftRepository
    {
        public async Task<GiftModel> Gravar(GiftModel gift)
        {
            return new GiftModel();
        }
    }
}
