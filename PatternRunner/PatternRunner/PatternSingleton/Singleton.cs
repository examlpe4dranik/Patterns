namespace PatternRunner.PatternSingleton
{
    public sealed class Singleton
    {
        private DateTime _dateCreate;
        private string _storage;

        private Singleton()
        { }

        private static Singleton _instance;

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                _instance._dateCreate = DateTime.Now;
            }

            return _instance;
        }

        public void SetData(string value) => _storage = value;

        public string GetData() => $"{_storage}::{_dateCreate}";
    }
}