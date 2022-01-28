using System;

namespace WebApplication1.Util
{
    public class FestivalReminder
    {
        public bool IsHoliday()
        {
            return DateTime.Today == DateTime.Parse("2022/11/11");
        }
    }
}