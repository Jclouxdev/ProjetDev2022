using System;
using App.Models;

namespace App.ViewModels
{
    public class ItemListViewModel
    {
        public List<Item> ItemList { get; set; }

        public ItemListViewModel(List<Item> itemList)
        {
            ItemList = itemList;
        }
    }
}