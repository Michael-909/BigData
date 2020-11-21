using System;
using System.Collections.Generic;

namespace BigData.Models
{
    public partial class DmWeatherCheckT
    {
        public string EventId { get; set; }
        public string WellId { get; set; }
        public string DailyId { get; set; }
        public double? CloudCoverPercent { get; set; }
        public string WeatherCheckId { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public double? CeilingHeight { get; set; }
        public double? SwellHeight { get; set; }
        public DateTime? CheckDate { get; set; }
        public double? PrecipitationAmount { get; set; }
        public string PrecipitationType { get; set; }
        public double? PressureAtmospheric { get; set; }
        public double? PressureBarometric { get; set; }
        public double? SeaDirCurrent { get; set; }
        public double? SeaSpeedCurrent { get; set; }
        public double? CurrentTemperature { get; set; }
        public double? TempHigh { get; set; }
        public double? TempLow { get; set; }
        public double? TempSea { get; set; }
        public double? Visibility { get; set; }
        public double? WaveDir { get; set; }
        public double? WaveHeight { get; set; }
        public double? WaveHeightMaxDir { get; set; }
        public double? WaveHeightMax { get; set; }
        public double? WavePeriodMax { get; set; }
        public double? WavePeriod { get; set; }
        public string WeatherAgency { get; set; }
        public double? WindDir { get; set; }
        public double? WindGustDir { get; set; }
        public double? WindGustSpeed { get; set; }
        public double? WindSpeed { get; set; }
        public double? SwellPeriod { get; set; }
        public double? SwellDirection { get; set; }
        public string CurrentMonitorEquipment { get; set; }

        public virtual DmDailyT DmDailyT { get; set; }
    }
}
