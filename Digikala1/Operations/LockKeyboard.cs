namespace KeyBoardLock
{
    class LockKeyBoard
    {
        public string A;
        string B;
        int Number;
        public ConsoleKeyInfo Lock;
        public int keyboardnumberlocker()
        {
            while (true)
            {
                Lock = Console.ReadKey(true);
                if (char.IsDigit(Lock.KeyChar))
                {
                    Number = Number * 10 + (int)char.GetNumericValue(Lock.KeyChar);
                    Console.Write(Lock.KeyChar);
                }
                else
                {
                    Console.Beep();
                }
                if (Lock.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
            }
            return Number;
        }

        public string keyboardYorNlocker()
        {
            do
            {
                A = Console.ReadKey(true).KeyChar.ToString();

            } while (A.ToLower() != "y" & A.ToLower() != "n");
            return A;
        }
        public string Mlocker()
        {
            do
            {
                B = Console.ReadKey(true).KeyChar.ToString();

            } while (B.ToLower() != "y" & B.ToLower() != "o" & B.ToLower() != "c" & B.ToLower() != "i" & B.ToLower() != "t");
            return B;
        }
    }
}



