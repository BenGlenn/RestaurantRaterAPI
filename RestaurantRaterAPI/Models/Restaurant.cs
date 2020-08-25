using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRaterAPI.Models
{
    // This is the Restaurant ENTITY ( the class that gets stored in the database)

    public class Restaurant
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Rating { get; set; }

        public bool IsRecommended 
        {
            get
            {
                // public bool IsRecommended => Rating > 3.5;

                return Rating > 3.5;

                // SAME THING for all 4 iterations 

                //return (Rating > 3.5) ? true : false;

                ////SAME THING

                //if(Rating > 3.5)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
        
        }

    }
}