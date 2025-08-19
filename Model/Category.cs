using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopTeam7.Model;

public class Category
{
    public int Id { get; private set; }
    private string _name;
    public string Name { get; set; }

    public Category(string name, int Id = 0)
    {
        this.Name = name;
    }
}
