using System;

namespace CAQueue
{
	public class PrintingJob
	{
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString()
        {
            return $"{_file} x #{_copies} copies";
        }
    }
}