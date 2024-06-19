namespace Timetable
{
    internal class Week1
    {
        private List<Session> _sessions;

        public Week1()
        {
            _sessions = new List<Session>
            {
                new Session("Start", 10, 0, 11, 30, DayOfWeek.Monday),
                new Session("Oppsum", 14, 0, 15, 0, DayOfWeek.Monday),
                new Session("Chorei", 9, 0, 9, 30, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Thursday, DayOfWeek.Friday),
                new Session("Und", 10, 0, 11, 30, DayOfWeek.Tuesday),
                new Session("Und", 12, 30, 14, 0, DayOfWeek.Thursday),
                new Session("Team", 14, 45, 15, 00, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday),
                new Session("Q&A", 9, 0, 10, 0, DayOfWeek.Wednesday),
                new Session("Q&A", 12, 30, 13, 30, DayOfWeek.Friday)
            };
            _sessions.Sort((a, b) => a.Start.CompareTo(b.Start));
        }

        public void Show()
        {
            Console.WriteLine("Mandag                  Tirsdag                 Onsdag                  Torsdag                 Fredag");
            var tableConsole = new TableConsole(2, 5, 24);
            foreach (var session in _sessions)
            {
                foreach (var day in session.Days)
                {
                    tableConsole.Write(session.ToString(), (int)day - 1);
                }
            }

            tableConsole.MoveCursor();
        }
    }
}
