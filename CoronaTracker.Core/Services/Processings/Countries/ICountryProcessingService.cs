﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Threading.Tasks;
using CoronaTracker.Core.Models.Countries;

namespace CoronaTracker.Core.Services.Processings.Countries
{
    public interface ICountryProcessingService
    {
        bool VerifyCountryChanged(Country country);
        ValueTask<Country> UpsertCountryAsync(Country country);
    }
}
