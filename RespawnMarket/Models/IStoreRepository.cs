﻿namespace RespawnMarket.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
