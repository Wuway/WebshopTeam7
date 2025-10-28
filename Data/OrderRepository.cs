using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WebshopTeam7.Model;

namespace WebshopTeam7.Data;
public class OrderRepository : IRepository<Order>
{
    private string _connectionString;
    public OrderRepository(string connectionstring)
    {
        this._connectionString = connectionstring;
    }

    public void Remove(int id)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            //kald på stored procedure
        }
    }

    public void Add(Order entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetById(int id)
    {
        //using (var command = new SqlCommand("uspGetOrderById", _connection))
        //{
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@OrderId", id);

        //    using (var reader = command.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //            return new Order
        //            {
        //                OrderId = (int)reader["OrderId"],
        //                Customer = (int)reader["CustomerId"],
        //                Date = (DateTime)reader["OrderDate"],

        //            };
        //        }
        //    }
        //}
        //return null;
    }


    public void Update(Order entity)
    {
        throw new NotImplementedException();
    }
  


}
