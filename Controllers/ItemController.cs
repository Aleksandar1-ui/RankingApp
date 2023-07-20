using Microsoft.AspNetCore.Mvc;
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
            new ItemModel{Id = 10, Title = "Friends With Money", ImageId = 10, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 11, Title = "Take Me Home", ImageId = 11, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 12, Title = "Justified", ImageId = 12, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 13, Title = "Escape", ImageId = 13, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 14, Title = "Glory Days", ImageId = 14, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 15, Title = "Celebrity", ImageId = 15, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 16, Title = "This Is Me ... Then", ImageId = 16, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 17, Title = "X", ImageId = 17, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 18, Title = "Dangerously In Love", ImageId = 18, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 19, Title = "Believe", ImageId = 19, Ranking = 0, ItemType = 2},
            new ItemModel{Id = 20, Title = "My Everything", ImageId = 20, Ranking = 0, ItemType = 2}
        };
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
    }
}
