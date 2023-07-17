﻿using Microsoft.AspNetCore.Mvc;
using RankingApp.Models;

namespace RankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id = 1, Title = "The First Time", ImageId = 1, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 2, Title = "Maze Runner", ImageId = 2, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 3, Title = "Charlie And The Chocolate Factory", ImageId = 3, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 4, Title = "Love And Monsters", ImageId = 4, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 5, Title = "Along Came Polly", ImageId = 5, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 6, Title = "Hachi", ImageId = 6, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 7, Title = "13 Going On 30", ImageId = 7, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 8, Title = "Monster In Law", ImageId = 8, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 9, Title = "Twilight", ImageId = 9, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 10, Title = "Friends With Money", ImageId = 10, Ranking = 0, ItemType = 1}
        };
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
    }
}
