using BrunnerTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerTest.calculateLogic
{
    public  interface ICalculateCost
    {
        decimal CalculateCost(List<IProduct> products);
    }
}
