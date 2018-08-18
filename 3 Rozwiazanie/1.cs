class ProductsProvider
{
    public Product GetProduct(ProductType productType, int take, int skip, SortType sortType)
    {
        string cacheKey = Cache.CreateCacheKey(nameof(GetProduct), productType, take, skip, sortType);

        if (Cache.Contains(cacheKey) && Cache.IsActual(cacheKey, CheckForChangesCallback))
        {
            return Cache.Get<Product>(cacheKey);
        }

        Product product = GetFromDb(productType, take, skip, sortType);

        Cache.Store(cacheKey, product);

        return product;
    }
}
