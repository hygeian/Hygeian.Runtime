using System;

namespace Hygeian.Runtime.Core
{
    public static class SystemClock
    {
        private static DateTimeOffset TimestampStartTime { get; set; } = new DateTimeOffset(1970, 01, 01, 0, 0, 0, TimeSpan.Zero);

        private static TimeSpan DefaultTimeSpan { get; } = TimeSpan.FromHours(8);

        public static DateTimeOffset Now
        {
            get { return DateTimeOffset.UtcNow.ToOffset(DefaultTimeSpan); }
        }

        public static DateTimeOffset FromTimestamp(int timestamp, TimeSpan? offSet = null)
        {
            if (offSet.HasValue)
                return TimestampStartTime.AddSeconds(timestamp).ToOffset(offSet.Value);
            else
                return TimestampStartTime.AddSeconds(timestamp).ToOffset(DefaultTimeSpan);
        }

        public static DateTimeOffset ToDateTimeOffSet(DateTime dateTime)
        {
            return new DateTimeOffset(dateTime, DefaultTimeSpan);
        }

        public static DateTimeOffset ToDateTimeOffSet(string dateTime)
        {
            DateTime dt = DateTime.Parse(dateTime);
            return ToDateTimeOffSet(dt);
        }
    }
}
