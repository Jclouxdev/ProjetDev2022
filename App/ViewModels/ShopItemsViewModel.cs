using System;
using App.Models;

namespace App.ViewModels
{
    public class ShopItemsViewModel
    {
        public List<ShopItem> ShopItemsList { get; set; }

        public ShopItemsViewModel(List<ShopItem> shopItemsList)
        {
            ShopItemsList = shopItemsList;
        }
    }
}