﻿using Kritner.SolarProjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.SolarProjection.Models
{
    public class ProjectionParameters
    {
        public ProjectionParameters(
            IYearlyKwhUsage utilityYear,
            int yearsToProject,
            int financeYears,
            double percentIncreasePerYear
        )
        {
            UtilityYear = utilityYear;
            YearsToProject = yearsToProject;
            FinanceYears = financeYears;
            PercentIncreasePerYear = percentIncreasePerYear;
        }

        public IYearlyKwhUsage UtilityYear { get; }
        public int YearsToProject { get; }
        public int FinanceYears { get; }
        public double PercentIncreasePerYear { get; }
    }
}
