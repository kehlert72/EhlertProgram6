using System.Drawing;

namespace EhlertProgram6
{
    public static class ImageFilter
    {
        // The method that contains the instructions to apply a blue filter
        public static Image ApplyBlueFilter(this Image inputImage)
        {
            // Create a new bitmap object with the dimensions of the original image
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            // Create a graphics variable from the outputImage created above
            Graphics imageGraphics = Graphics.FromImage(outputImage);

            // Fill the imageGraphics variable with the input (original) image
            imageGraphics.DrawImage(inputImage, 5, 5);

            // Apply bluefilter by brushing with ARGB color
            imageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Blue)), 0, 0, outputImage.Width, outputImage.Height);

            return outputImage;
        }
    }
}
