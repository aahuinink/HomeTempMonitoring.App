namespace HomeTempMonitoring
{
    public class Drawables : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            Rect lineGraphRect = new(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
            DrawLineGraph(canvas, lineGraphRect, );
        }

        public void DrawLineGraph(DataPoint data)
        {
            throw new NotImplementedException ();
        }

    }
}
