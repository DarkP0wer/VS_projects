using System;

namespace English
{
    public static class Config
    {
        public static readonly string json_fileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\WordBook.json";
        public static readonly int countRowsForRetime = 25;
        public static readonly string g_domain = "https://translate.google.com/translate";
        public static readonly short count_to_exclude_word = 30;


        public enum TimeInSeconds
        {
            Now = 0,
            Min_15 = 15 * 60,
            Hour = 1 * 60 * 60,
            Hour_3 = 3 * 60 * 60,
            Day = 1 * 24 * 60 * 60 - 6 * 60 * 60,
            Day_2 = 2 * 24 * 60 * 60 - 6 * 60 * 60,
            Day_4 = 4 * 24 * 60 * 60 - 6 * 60 * 60,
            Week = 1 * 7 * 24 * 60 * 60 - 6 * 60 * 60,
            Week_2 = 2 * 7 * 24 * 60 * 60 - 6 * 60 * 60,
            Month = 1 * 4 * 7 * 24 * 60 * 60 - 6 * 60 * 60,
            Month_6 = 6 * 4 * 7 * 24 * 60 * 60 - 6 * 60 * 60,
            Year = 1 * 12 * 4 * 7 * 24 * 60 * 60 - 6 * 60 * 60
        }


        public static int GetUnixTime()
        {
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }


        public static string GetStringTime(int seconds)
        {
            var t = TimeSpan.FromSeconds(seconds);
            var str_time = string.Format("{0:D2}s", t.Seconds);

            if (t.Days > 0)
                str_time = string.Format("{3:D2}d:{2:D2}h:{1:D2}m:{0:D2}s", t.Seconds, t.Minutes, t.Hours, t.Days);
            else if (t.Hours > 0)
                str_time = string.Format("{2:D2}h:{1:D2}m:{0:D2}s", t.Seconds, t.Minutes, t.Hours);
            else if (t.Minutes > 0)
                str_time = string.Format("{1:D2}m:{0:D2}s", t.Seconds, t.Minutes);

            return str_time;
        }
    }


}
