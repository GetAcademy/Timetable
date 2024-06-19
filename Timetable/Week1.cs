namespace Timetable
{
    internal class Week1
    {
        private List<Session> _sessions;

        public Week1()
        {
            _sessions = new List<Session>();
            _sessions.Add(new Session("Oppstart", 10, 0, 11, 30, DayOfWeek.Monday));
            _sessions.Add(new Session("Avslutning", 14, 0, 15, 0, DayOfWeek.Monday));
            _sessions.Add(new Session("Chorei", 9, 0, 9, 30, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday, DayOfWeek.Friday));
            _sessions.Add(new Session("Undervisning", 10, 0, 11, 30, DayOfWeek.Tuesday));
            _sessions.Add(new Session("Undervisning", 12, 30, 14, 0, DayOfWeek.Thursday));
            _sessions.Add(new Session("Avslutning i team", 14, 45, 15, 00, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday));
            _sessions.Add(new Session("Q&A", 9, 0, 10, 0, DayOfWeek.Wednesday));
            _sessions.Add(new Session("Q&A", 12, 30, 13, 30, DayOfWeek.Friday));
        }

        public void Show()
        {
            
        }

        private void WriteCol(string text, int col)
        {

        }
    }
}
