using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTempMonitoring
{
    public class Graph : IDrawable
    {
        private int _size;
        private LinkedList<DataPoint> _data;
        private int _lineThickness;
        private Color _lineColor;


        public int Size { get => _size; set => _size = value; }
        public int LineThickness { get => _lineThickness; set => _lineThickness = value; }
        public Color LineColor { get => _lineColor; set => _lineColor = value; }
        public LinkedList<DataPoint> Data { get => _data; set => _data = value; }

        public Graph(int width, int lineThickness, Color lineColor)
        {
            Size = width;
            Data = new LinkedList<DataPoint>();
            LineThickness = lineThickness;
            LineColor = lineColor;
        }

        
        public void UpdateData(DataPoint newDataPoint)
        {
            while (Data.Count >= Size)
            {
                Data.RemoveFirst();
            }
            Data.AddLast(newDataPoint);
        }

        public LinkedList<DataPoint>.Enumerator GetEnumerator()
        {
            return Data.GetEnumerator();
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            Rect lineGraphRect = new(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
            DrawLineGraph(canvas, lineGraphRect, Data.GetEnumerator());
        }

        public void DrawLineGraph(ICanvas canvas, Rect lineGraphRect, LinkedList<DataPoint>.Enumerator data)
        {
            
        }
    }
}
