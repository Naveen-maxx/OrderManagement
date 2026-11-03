using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement;

public class OrderService
{
    public decimal CalculateOrderTotal()
    {
        decimal itemPrice = 500m;
        int quantity = 3;

        return itemPrice * quantity;
    }
}