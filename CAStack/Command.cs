using System;


namespace CAStack
{
	public class Command
	{
        private readonly DateTime _createdAt;
        private readonly string _url;

        public Command(DateTime createdAt, string url)
        {
            _createdAt = createdAt;
            _url = url;
        }
        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }
    }
}
