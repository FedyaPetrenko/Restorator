using System;

namespace Restorator_1._0.Model
{
    internal class Visits
    {
        private DateTime _dateTime;
        private int _numberOfVisits;
        private int _allMoney;
        private string _favoritesDishes;
        private string _complaint;
        private int _percentageDiscounts;

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public int NumberOfVisits
        {
            get { return _numberOfVisits; }
            set { _numberOfVisits = value; }
        }

        public int Money
        {
            get { return _allMoney; }
            set { _allMoney = value; }
        }

        public string FavoritesDishes
        {
            get { return _favoritesDishes; }
            set { _favoritesDishes = value; }
        }

        public string Complaint
        {
            get { return _complaint; }
            set { _complaint = value; }
        }

        public int PercentageDiscounts
        {
            get { return _percentageDiscounts; }
            set { _percentageDiscounts = value; }
        }

        public Visits()
        {
        }

        public Visits(DateTime dateTime, int numberOfVisits, int money, string favoritesDishes, string complaint,
            int percentageDiscounts)
        {
            DateTime = dateTime;
            NumberOfVisits = numberOfVisits;
            Money = money;
            FavoritesDishes = favoritesDishes;
            Complaint = complaint;
            PercentageDiscounts = percentageDiscounts;
        }
    }
}
