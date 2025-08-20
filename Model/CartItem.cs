using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model;

internal class CartItem
{
    public int CartId { get; set; }   //CartId bruges til at identificere den specifikke kurv, som produktet er i
    public int ProductId { get; set; } // ProductId bruges til at identificere det specifikke produkt i kurven
    public double Amount { get; set; } // Amount er antallet af dette produkt i kurven

    public CartItem(int productId, int cartId, int amount) // Konstruktøren initialiserer egenskaberne for CartItem-objektet
    {
        ProductId = productId;
        CartId = cartId;
        Amount = amount;
    }

}
