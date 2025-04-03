using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;

namespace Point.Client.Main.Api.Extensions
{
    public static class EntityExtensions
    {
        public static ItemDto ToItemDto(this Item item)
        {
            return new ItemDto
            {
                Name = item.Name,
                Description = item.Description,
                CategoryId = item.Category?.Id,
                Tags = item.Tags?.Select(tag => tag.Id).ToList()
            };
        }
    }
}
