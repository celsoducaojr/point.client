using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Entities.Orders;

namespace Point.Client.Main.Api.Extensions
{
    public static class EntityExtensions
    {
        #region  To Entities

        public static Customer ToCustomer(this CustomerDto customerDto, int id)
        {
            return new Customer
            {
                Id = id,
                Name = customerDto.Name,
                MobileNumber = customerDto.MobileNumber,
                Email = customerDto.Email,
                Address = customerDto.Address,
                Remarks = customerDto.Remarks
            };
        }

        #endregion

        #region To DTOs

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

        public static OrderItemDto ToOrderItemDto(this OrderItem orderItem)
        {
            return new OrderItemDto
            {
                ItemUnitId = orderItem.ItemUnitId,
                ItemName = orderItem.ItemName,
                UnitId = orderItem.UnitId,
                UnitName = orderItem.UnitName, 
                Quantity = orderItem.Quantity,
                Price = orderItem.Price,
                Discount = orderItem.Discount,
                Total = orderItem.Total
            };
        }

        #endregion
    }
}
