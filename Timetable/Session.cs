namespace Timetable
{
    internal class Session
    {
        private DayOfWeek[] _days;
        private string _name;
        private TimeOnly _start;
        private TimeOnly _end;

        public Session(string name, int startHour, int startMinute, int endHour, int endMinute, params DayOfWeek[] days)
        {
            _days = days;
            _name = name;
            _start = new TimeOnly(startHour, startMinute);
            _end = new TimeOnly(endHour, endMinute);
        }
    }
}
