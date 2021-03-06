﻿using System;

namespace Task1
{
    /// <summary>
    /// This class is for smth.
    /// </summary>
    public static class Population
    {
        /// <summary>
        /// This method is for counting years.
        /// </summary>
        /// <param name="initialPopulation">
        /// InitialPopullation is initial number of people.
        /// </param>
        /// <param name="percent">
        /// Popullation growth.
        /// </param>
        /// <param name="visitors">
        /// Number of visitors per year.
        /// </param>
        /// <param name="currentPopulation">
        /// The number of people is planning.
        /// </param>
        /// <returns>
        /// How many years meet the requirement.
        /// </returns>
        /// <exception cref="System.ArgumentException">
        /// Initialpopulation, visitors, currentPopulation cannot be less or equals zero.
        ///  </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Value of percents cannot be less then 0% or more then 100%.
        ///  </exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("initialPopulation <=0", nameof(initialPopulation));
            }

            if (visitors <= 0)
            {
                throw new ArgumentException("visitors <=0", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("currentPopulation <=0", nameof(currentPopulation));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0% or more then 100%.");
            }

            int sumYears = 0;

            while (initialPopulation < currentPopulation)
            {
                int counter = ((int)(initialPopulation * percent) / 100) + visitors;
                initialPopulation += counter;
                sumYears++;
            }

            return sumYears;
        }
    }
}