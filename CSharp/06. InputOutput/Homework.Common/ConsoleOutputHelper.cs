namespace Homework.Common
{
    using System;

    public static class ConsoleOutputHelper
    {
        public static void WriteMessage(
            string message,
            ConsoleMessageType messageType = ConsoleMessageType.Default)
        {
            switch (messageType)
            {
                case ConsoleMessageType.Default:
                    {
                        Console.ResetColor();
                        break;
                    }

                case ConsoleMessageType.Error:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }

                case ConsoleMessageType.Info:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }

                case ConsoleMessageType.Warrning:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }

                case ConsoleMessageType.Success:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }

                default:
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
