using System;
using System.Collections.Generic;
using Assignment01.Models;

namespace Assignment01.Services
{
    internal class RectangleService: Rectangle
    {
        private readonly Dictionary<int, Func<int>> _rectangleReadOnlyOperations;

        public RectangleService (int length, int width): base(length, width)
        {
            _rectangleReadOnlyOperations = new Dictionary<int, Func<int>>
            {
                {1, GetLength}, {3, GetWidth}, {5, GetPerimeter}, {6, GetArea}
            };
        }

        public void PerformMenuOperation(int selectedMenu)
        {
            if (selectedMenu == 7)
            {
                return;
            }
            if (selectedMenu == 2)
            {
                int length = Program.GetParameterValue(Program.RECTANGLE_LENGTH);
                SetLength(length);
            }
            else if (selectedMenu == 4)
            {
                int width = Program.GetParameterValue(Program.RECTANGLE_WIDTH);
                SetWidth(width);
            }
            else
            {
                int result = _rectangleReadOnlyOperations[selectedMenu].Invoke();
                Console.WriteLine($"Required result: {result}");
            }
        }
    }
}
