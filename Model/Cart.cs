using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model;

public class Cart
{
    public int CartId { get; set; } // Primærnøgle for kurven, bruges til at identificere den specifikke kurv
    public int UserId { get; set; } // UserId bruges til at identificere den specifikke bruger, der ejer kurven
    public DateTime CreatedAt { get; set; } // CreatedAt angiver, hvornår kurven blev oprettet
    public bool IsCheckedOut { get; set; } // IsCheckedOut angiver, om kurven er blevet tjekket ud eller ej

    public List<CartItem> Items { get; set; } = new List<CartItem>(); // Liste over CartItem-objekter, der repræsenterer de produkter, der er i kurven


}
