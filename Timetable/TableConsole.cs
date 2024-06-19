namespace Timetable
{
    internal class TableConsole
    {
        private readonly int _startRow;
        private readonly int[] _linesWritten;
        private readonly int _colWidth;

        public TableConsole(int startRow, int colCount, int colWidth)
        {
            _colWidth = colWidth;
            _startRow = startRow;
            _linesWritten = new int[colCount];
        }

        public void Write(string line, int colIndex)
        {
            var col = colIndex * _colWidth;
            var row = _startRow + _linesWritten[colIndex];
            _linesWritten[colIndex]++;
            Console.SetCursorPosition(col, row);
            Console.Write(line);
        }

        public void MoveCursor()
        {
            var maxRow = _linesWritten.Max();
            Console.CursorTop = maxRow + 1;
        }
    }
}
