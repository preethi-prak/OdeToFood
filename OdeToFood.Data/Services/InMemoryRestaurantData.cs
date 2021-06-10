using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestuarantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1 , Name = "Lucalli's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 2 , Name = "Godhavari Indian Restaurant", Cuisine = CuisineType.Indian},
                new Restaurant{Id = 3 , Name = "50 Kitchen", Cuisine = CuisineType.American},
                new Restaurant{Id = 3 , Name = "Fasika Cafe", Cuisine = CuisineType.Ethopian}

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
