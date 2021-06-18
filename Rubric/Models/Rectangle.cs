namespace Assignment01.Models
{
    public class Rectangle: IRectangle
    {
        private int length, width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int length)
        {
            if (length >= 1)
            {
                this.length = length;
            }
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int width)
        {
            if (width >= 1)
            {
                this.width = width;
            }
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
