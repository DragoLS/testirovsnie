namespace first
{
    public class Class1
    {
        public int Ch(string pas)
        {
            bool chec = false;
            int ball = 0;
            char[] chars = new char[pas.Length];
            chars = pas.ToCharArray();
            foreach (char c in chars)
            {   
                if (char.IsDigit(c))
                {
                    chec = true;
                }
            }
            if (chec) { ball++; }
            chec = false;
            if (pas.Length > 7) { ball++; }
            foreach (char c in chars)
            {
                if (char.IsLower(c))
                {
                    chec = true;
                }

            }
            
            if (chec) { ball++; }
            chec = false;
            foreach (char c in chars)
            {
                if (char.IsUpper(c))
                {
                    chec = true;
                }
            }
            if (chec) { ball++; }
            chec = false;
            foreach (char c in chars)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    chec = true;
                }
            }
            if (chec) { ball++; }
            chec = false;
            return ball;
        }

    }
}
