namespace BasicDIPActivity
{
    public class Filters
    {
        public static ConvMatrix Smooth = new ConvMatrix(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, 9, 0);
        public static ConvMatrix GaussianBlur = new ConvMatrix(new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 1, 2, 1 } }, 16, 0);
        public static ConvMatrix Sharpen = new ConvMatrix(new int[,] { { 0, -2, 0 }, { -2, 11, -2 }, { 0, -2, 0 } }, 3, 0);
        public static ConvMatrix MeanRemoval = new ConvMatrix(new int[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } }, 1, 0);
        public static ConvMatrix EmbossLaplacian = new ConvMatrix(new int[,] { { -1, 0, -1 }, { 0, 4, 0 }, { -1, 0, -1 } }, 1, 127);
        public static ConvMatrix HorzVert = new ConvMatrix(new int[,] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } }, 1, 127);
        public static ConvMatrix AllDirection = new ConvMatrix(new int[,] { { -1, -1,-1 }, { -1, 8, -1 }, { -1, -1, -1 } }, 1, 127);
        public static ConvMatrix Lossy = new ConvMatrix(new int[,] { { 1, -2, 1 }, { -2, 4, -2 }, { -2, 1, -2 } }, 1, 127);
        public static ConvMatrix HorzOnly = new ConvMatrix(new int[,] { { 0, 0, 0 }, { -1, 2, -1 }, { 0, 0, 0 } }, 1, 127);
        public static ConvMatrix VertOnly = new ConvMatrix(new int[,] { { 0, -1, 0 }, { 0, 0, 0 }, { 0, 1, 0 } }, 1, 127);
    }
}
