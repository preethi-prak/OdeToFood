﻿using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRestuarantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
