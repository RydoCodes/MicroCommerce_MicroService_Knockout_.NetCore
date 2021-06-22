using MicroCommerce.Models;
using Shed.CoreKit.WebApi;
using System;
using System.Collections.Generic;

namespace MicroCommerce
{
    public interface IShoppingCart
    {
        Cart Get();

        [HttpPut, Route("addorder/{productId}/{qty}")]
        Cart AddOrder(Guid productId, int qty);

        Cart DeleteOrder(Guid orderId);

        [HttpPut, Route("deleteorder/{orderId}/{qty}")]
        Cart DeleteOrder(Guid OrderId, int qty);

        [Route("getevents/{timestamp}")]
        IEnumerable<CartEvent> GetCartEvents(long timestamp);
    }
}
