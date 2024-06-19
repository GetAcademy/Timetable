namespace Timetable
{
    internal class Session
    {
        public DayOfWeek[] Days { get; }
        public TimeOnly Start { get; }
        public TimeOnly End { get; }
        public string Name { get; }

        public Session(string name, int startHour, int startMinute, int endHour, int endMinute, params DayOfWeek[] days)
        {
            Days = days;
            Name = name;
            Start = new TimeOnly(startHour, startMinute);
            End = new TimeOnly(endHour, endMinute);
        }

        public override string ToString()
        {
            return Start.ToString("HH:mm") + " - " + End.ToString("HH:mm") + " " + Name;
        }
    }
}
