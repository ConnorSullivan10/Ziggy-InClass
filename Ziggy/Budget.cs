using System;

namespace Ziggy
{
    public class Budget
    {
        private int GovernmentBudget { get; set; } = 999999999;

        public bool AuthorizeLeap(Leaper theLeaper, DateTime dayInHistory)
        {
            return false;
            var numberOfDaysToTravel = (dayInHistory - theLeaper.CurrentDate).Days;

            var costOfTravel = 1000 * numberOfDaysToTravel;

            return costOfTravel < GovernmentBudget;

            // It costs $1,000 to leap 1 day
        }
    }
}