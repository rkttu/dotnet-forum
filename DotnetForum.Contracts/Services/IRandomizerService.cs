﻿namespace DotnetForum.Contracts.Services
{
    public interface IRandomizerService
    {
        int GetNextNumber(int? min = null, int? max = null);
    }
}
