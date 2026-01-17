using System;
namespace FlashDealz
{
    interface IProductOperation
    {
        void AddProduct();
        int GetCount();
        void SortDiscountedProducts(int low, int high);
        void DisplayProducts();
    }
}