using System;
using Assignment01.Exceptions;

namespace Assignment01.Controllers
{
    public static class RetryController
    {
        internal static void LengthWidthInput(Action action)
        {
            bool retry = true;
            do
            {
                try
                {
                    action.Invoke();
                    retry = false;
                }
                catch (Exception ex) when (ex is LessThanZeroException || ex is FormatException)
                {
                    Console.Write("Invalid integer input is provided. ");
                    if (ex is LessThanZeroException)
                    {
                        Console.Write(ex.Message);
                    }
                    Console.Write("\n\nPlease enter a value again: ");
                }
            } while (retry);
        }

        internal static void MenuInput(Action action)
        {
            bool retry = true;
            do
            {
                try
                {
                    action.Invoke();
                    retry = false;
                }
                catch (Exception ex) when (ex is InvalidMenuOptionException || ex is FormatException)
                {
                    continue;
                }
            } while (retry);
        }
    }
}
