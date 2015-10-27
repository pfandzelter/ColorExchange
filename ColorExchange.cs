#region UICode
byte Amount1 = 0; // Replace red with:|Red|Green|Blue|Alpha|Zero
byte Amount2 = 1; // Replace green with:|Red|Green|Blue|Alpha|Zero
byte Amount3 = 2; // Replace blue with:|Red|Green|Blue|Alpha|Zero
byte Amount4 = 3; // Replace alpha with:|Red|Green|Blue|Alpha|Zero
#endregion

void Render(Surface dst, Surface src, Rectangle rect)
{
    //give variables the dropdown values
    //replace red (r) with the color chosen in menu 1
    int r = Amount1;
    //replace green (g) with the color chosen in menu 2
    int g = Amount2;
    //replace blue (b) with the color chosen in menu 3
    int b = Amount3; 
    //replace alpha (a) with the color chosen in menu 4
    int a = Amount4;
    //new array to save the colors of a pixel
    byte[] colorsRGBA = new byte[5];
    //the fifth choice is zero, so it is always 0
    colorsRGBA[4] = 0;
 
    ColorBgra CurrentPixel;
    
    for (int y = rect.Top; y < rect.Bottom; y++)
    {
        for (int x = rect.Left; x < rect.Right; x++)
        {
            CurrentPixel = src[x,y];
            //saving the colors of a pixel
            colorsRGBA[0] = CurrentPixel.R;
            colorsRGBA[1] = CurrentPixel.G;
            colorsRGBA[2] = CurrentPixel.B;
            colorsRGBA[3] = CurrentPixel.A;
            //replacing the color channels
            CurrentPixel.R = colorsRGBA[r];
            CurrentPixel.G = colorsRGBA[g];
            CurrentPixel.B = colorsRGBA[b];
            CurrentPixel.A = colorsRGBA[a];
            dst[x,y] = CurrentPixel;
        }
    }
}
