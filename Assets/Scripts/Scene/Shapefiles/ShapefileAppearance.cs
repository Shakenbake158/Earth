using System.Drawing;

namespace Earth.Scene
{
    public class ShapefileAppearance
    {
        public ShapefileAppearance()
	    {
            PolylineColor = Color.Yellow;
            PolylineOutlineColor = Color.Black;
            PolylineWidth = 3.0;
            PolylineOutlineWidth = 2.0;
	    }

        public Bitmap Bitmap { get; set; }
        public Color PolylineColor { get; set; }
        public Color PolylineOutlineColor { get; set; }
        public double PolylineWidth { get; set; }
        public double PolylineOutlineWidth { get; set; }
    }
}
