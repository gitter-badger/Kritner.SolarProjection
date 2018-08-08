﻿using KritnerWebsite.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Helpers
{
    public static class ElectricityDataHelper
    {
        public static YearlyElectricityUsage GetUsageBge2017()
        {
            List<MonthlyElectrictyUsage> monthlyCollection2017 = new List<MonthlyElectrictyUsage>()
            {
                new MonthlyElectrictyUsage(new DateTime(2017, 1, 1), 1279, 184.03),
                new MonthlyElectrictyUsage(new DateTime(2017, 2, 1), 1035, 152.21),
                new MonthlyElectrictyUsage(new DateTime(2017, 3, 1), 1063, 153.65),
                new MonthlyElectrictyUsage(new DateTime(2017, 4, 1), 1075, 157.43),
                new MonthlyElectrictyUsage(new DateTime(2017, 5, 1), 1123, 164.07),
                new MonthlyElectrictyUsage(new DateTime(2017, 6, 1), 1986, 271.40),
                new MonthlyElectrictyUsage(new DateTime(2017, 7, 1), 2191, 296.36),
                new MonthlyElectrictyUsage(new DateTime(2017, 8, 1), 1926, 261.51),
                new MonthlyElectrictyUsage(new DateTime(2017, 9, 1), 1673, 223.58),
                new MonthlyElectrictyUsage(new DateTime(2017, 10, 1), 1196, 161.04),
                new MonthlyElectrictyUsage(new DateTime(2017, 11, 1), 1201, 161.50),
                new MonthlyElectrictyUsage(new DateTime(2017, 12, 1), 1271, 170.44)
            };

            return new YearlyElectricityUsage(monthlyCollection2017);
        }

        public static YearlyElectricityUsage GetUsageWithPanelsMortgage()
        {
            List<MonthlyElectrictyUsage> panelExampleFrom2017Usage = new List<MonthlyElectrictyUsage>()
            {
                new MonthlyElectrictyUsage(new DateTime(2017, 1, 1), 1279, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 2, 1), 1035, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 3, 1), 1063, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 4, 1), 1075, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 5, 1), 1123, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 6, 1), 1986, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 7, 1), 2191, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 8, 1), 1926, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 9, 1), 1673, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 10, 1), 1196, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 11, 1), 1201, 189),
                new MonthlyElectrictyUsage(new DateTime(2017, 12, 1), 1271, 189)
            };

            return new YearlyElectricityUsage(panelExampleFrom2017Usage);
        }
    }
}
