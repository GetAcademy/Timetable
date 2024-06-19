namespace Timetable
{
    internal class Week1
    {
        private List<Session> _sessions;

        public Week1()
        {
            _sessions = new List<Session>();
            _sessions.Add(new Session("Oppstart", 10, 0, 11, 30, DayOfWeek.Monday));
            _sessions.Add(new Session("Avslutning", 14, 0, 15, 00, DayOfWeek.Monday));
            _sessions.Add(new Session("Undervisning", 10, 0, 11, 30, DayOfWeek.Tuesday));
            _sessions.Add(new Session("Undervisning", 12, 30, 14, 00, DayOfWeek.Thursday));

        }
    }
}
