class ProductsProvider
{
    public virtual Product GetProduct(ProductType productType, int take, int skip, SortType sortType)
    {
        Product product = GetFromDb(productType, take, skip, sortType);

        return product;
    }
}
