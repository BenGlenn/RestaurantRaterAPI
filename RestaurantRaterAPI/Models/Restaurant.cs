using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace RestaurantRaterAPI.Models
{
    // This is the Restaurant ENTITY ( the class that gets stored in the database)

    public class Restaurant
    {
        // Primary Key
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       
        public double Rating
        {
            get
            {
               // return AvgFoodRating + AvgEnvRating + AvgCleanRating / 3; Another way of doing below CODE //


                // Calculate a total average score based on Ratings
                double totalAverageRating = 0;

                foreach(var rating in Ratings)
                {
                   // totalAverageRating = totalAverageRating + rating.AverageRating; SAME AS BELOW CODE //
                    totalAverageRating +=  rating.AverageRating;
                }
                // Return Average of Total if the count is above 0

                return (Ratings.Count > 0) ? Math.Round(totalAverageRating / Ratings.Count, 2) : 0;
            }
        }

        // Average Food Rating

        // THIS IS ANOTHER WAY TO DO THE BELOW CODE //

        //public double FoodRating
        //{
        //    get
        //    {
        //        double totalFoodScore = 0;
        //        foreach (var rating in Ratings)
        //            totalFoodScore += rating.FoodScore;

        //        return Ratings.Count > 0 ? totalFoodScore / Ratings.Count : 0;
        //    }
        //}

        public double AvgFoodRating
        {
            get
            {
                // Calculate a total average score based on Ratings
                double totalFoodRating = 0;

                foreach (var rating in Ratings)
                {
                    // totalAverageRating = totalAverageRating + rating.AverageRating; SAME AS BELOW CODE //
                    totalFoodRating += rating.FoodScore;
                }
                // Return Average of Total if the count is above 0

                return (Ratings.Count > 0) ? Math.Round(totalFoodRating / Ratings.Count, 2) : 0;
            }
        }

        // Average Environment Rating

        // Cleaner way to do the below CODE //

        //public double EnvironmentRating
        //{
        //    get
        //    {
        //       IEnumerable<double> scores = Ratings.Select(rating => rating.EnvironmentScore);
        //        double totalEnvironmentScore = scores.Sum();
        //        return (Ratings.Count > 0) ? totalEnvironmentScore / Ratings.Count : 0;
        //    }
        //}

        public double AvgEnvRating
        {
            get
            {
                // Calculate a total average score based on Ratings
                double totalEnvRating = 0;

                foreach (var rating in Ratings)
                {
                    // totalAverageRating = totalAverageRating + rating.AverageRating; SAME AS BELOW CODE //
                    totalEnvRating += rating.EnvironmentScore;
                }
                // Return Average of Total if the count is above 0

                return (Ratings.Count > 0) ? Math.Round(totalEnvRating / Ratings.Count, 2) : 0;
            }
        }

        // Average Cleanliness Rating 
        public double AvgCleanRating
        {
            get
            {
                // Calculate a total average score based on Ratings
                double totalCleanRating = 0;

                foreach (var rating in Ratings)
                {
                    // totalAverageRating = totalAverageRating + rating.AverageRating; SAME AS BELOW CODE //
                    totalCleanRating += rating.CleanlinessScore;
                }
                // Return Average of Total if the count is above 0

                return (Ratings.Count > 0) ? Math.Round(totalCleanRating / Ratings.Count, 2) : 0;
            }
        }

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

        // All of the associate Rating objects from the database (pulling from the ratings class) 
        // Based on the Foreign Key relationship

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

    }
}