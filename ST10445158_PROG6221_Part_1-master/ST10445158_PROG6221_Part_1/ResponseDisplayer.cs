namespace ST10445158_PROG6221_Part_1
{
    using System;
    using System.Threading;

    class ResponseDisplayer
    {
        public void Display(string message, ConsoleColor color)
        {
            Console.Write("\nChatbot: ");
            Console.ForegroundColor = color;

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}