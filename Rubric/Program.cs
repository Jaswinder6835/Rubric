using System;
using Assignment01.Services;
using Assignment01.Exceptions;
using Assignment01.Controllers;

namespace Assignment01
{
    class Program
    {
        public static readonly string RECTANGLE_LENGTH = "Length";
        public static readonly string RECTANGLE_WIDTH = "Width";

        private static string _inputValue;
        private static int _rectangleLength, _rectangleWidth;
        private static RectangleService _rectangleService;

        static void Main()
        {
            _rectangleLength = GetParameterValue(RECTANGLE_LENGTH);
            _rectangleWidth = GetParameterValue(RECTANGLE_WIDTH);
            _rectangleService = new RectangleService(_rectangleLength, _rectangleWidth);
            int selectedMenu;
            do
            {
                selectedMenu = GetSelectedMenuInput();
                _rectangleService.PerformMenuOperation(selectedMenu);
            } while (selectedMenu != 7);
        }

        internal static int GetParameterValue(string parameterName)
        {
            Console.Write($"Provide {parameterName} of the rectangle: ");
            RetryController.LengthWidthInput(() =>
            {
                _inputValue = Console.ReadLine();
                ValidateParameterInput(_inputValue, parameterName);
            });
            return int.Parse(_inputValue);
        }

        internal static void ValidateParameterInput(string inputValue, string rectangleAttribute)
        {
            if (int.Parse(inputValue) <= 0)
            {
                throw new LessThanZeroException(rectangleAttribute);
            }
        }

        internal static int GetSelectedMenuInput()
        {
            RetryController.MenuInput(() =>
            {
                Console.Write(GetRectangleMenu());
                _inputValue = Console.ReadLine();
                ValidateSelectedMenuInput(_inputValue);
            });
            return int.Parse(_inputValue);
        }

        internal static string GetRectangleMenu()
        {
            return "\nMenu:\n" +
                "1. Get Rectangle Length\n" +
                "2. Change Rectangle Length\n" +
                "3. Get Rectangle Width\n" +
                "4. Change Rectangle Width\n" +
                "5. Get Rectangle Perimeter\n" +
                "6. Get Rectangle Area\n" +
                "7. Exit\n\n" +
                "Select option: ";
        }

        internal static void ValidateSelectedMenuInput(string inputValue)
        {
            int selectedOption = int.Parse(inputValue);
            if (selectedOption < 1 || selectedOption > 7)
            {
                throw new InvalidMenuOptionException();
            }
        }
    }
}
