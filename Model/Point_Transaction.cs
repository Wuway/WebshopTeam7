using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model;

public class Point_Transaction
{
    private Customer userId;
    private int amount;
    private Order order;

    public Point_Transaction(Customer userId, int amount, Order order)
    {
        this.userId = userId;
        this.amount = amount;
        this.order = order;
    }
}
