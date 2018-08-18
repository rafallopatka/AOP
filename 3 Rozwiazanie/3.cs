class ProductsProvider
{
    public virtual Product GetProduct(ProductType productType, int take, int skip, SortType sortType)
    {
        Product product = GetFromDb(productType, take, skip, sortType);

        return product;
    }
}

class ProductsProviderProxy : ProductsProvider
{
    public override Product GetProduct(ProductType productType, int take, int skip, SortType sortType)
    {
        string cacheKey = Cache.CreateCacheKey(nameof(GetProduct), productType, take, skip, sortType);

        if (Cache.Contains(cacheKey) && Cache.IsActual(cacheKey, CheckForChangesCallback))
        {
            return Cache.Get<Product>(cacheKey);
        }

        Product product = base.GetProduct(productType, take, skip, sortType);

        Cache.Store(cacheKey, product);

        return product;
    }
}

IocContainer.Resolve<ProductsProvider>().Using<ProductsProviderProxy>();

var productsProvider = Resolver.Get<ProductsProvider>();
