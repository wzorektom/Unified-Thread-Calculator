

namespace ThreadCalculatorClassLibrary
{
    public class LoginData
    {
        private static int _attempts = 3;



        public string SetTypedPass { get; set; }

        public string GetPass { get; } = "";

        public int GetAttempts
        {
            get { return _attempts; }
            set { _attempts = value; }
        }

    }
}
