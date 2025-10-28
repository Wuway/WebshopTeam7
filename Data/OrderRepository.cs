using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WebshopTeam7.Model;

namespace WebshopTeam7.Data;
    public class OrderRepository : IRepository<Order>
    {
        private readonly string _connectionstring = "Server=localhost;Database=Webshop2;Trusted_Connection=True;";

    /*  Sletter en ordre fra databasen
        Åbn databaseforbindelse
        Udfør SQL: DELETE FROM Orders WHERE Id = id
        Gem ændringer
        Luk databaseforbindelse*/
    public void Remove(int id)
        {
             public void Remove(int id) 
             { 
                using (SqlConnection connection = new Sqlconnection(_connectionstring)) {
             }


        }



    /*  Tilføjer en ny ordre til databasen
        Åbn databaseforbindelse
        Indsæt ordredata i Order-tabellen
        Gem ændringer
        Luk databaseforbindelse*/
    void IRepository<Order>.Add(Order entity)
        {
            throw new NotImplementedException();
        }



    /*  Henter alle ordrer fra databasen
        Åbn databaseforbindelse
        Udfør SQL: SELECT * FROM Orders
        Opret en liste af Order-objekter ud fra resultaterne
        Luk databaseforbindelse
        RETURNER listen af ordrer*/
        IEnumerable<Order> IRepository<Order>.GetAll()
        {
            throw new NotImplementedException();
        }


    /*  Finder én ordre ud fra dens id
        Åbn databaseforbindelse
        Udfør SQL: SELECT * FROM Orders WHERE Id = id
        Hvis en ordre blev fundet
            Opret et Order-objekt ud fra resultaterne
            RETURNER objektet
        Ellers
            RETURNER null
        Luk databaseforbindelse*/
        Order IRepository<Order>.GetById(int id)
        {
            throw new NotImplementedException();
        }


    /*Opdaterer eksisterende ordre i databasen
        Åbn databaseforbindelse
        Udfør SQL:
            UPDATE Orders 
            SET KundeId = order.KundeId,
                TotalPris = order.TotalPris,
                Status = order.Status
            WHERE Id = order.Id
        Gem ændringer
        Luk databaseforbindelse*/
        void IRepository<Order>.Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }


}
