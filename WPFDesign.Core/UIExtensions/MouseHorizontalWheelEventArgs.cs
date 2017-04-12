using System.Windows.Input;

namespace WPFDesign.Core.UIExtensions
{
    public class MouseHorizontalWheelEventArgs : MouseEventArgs
    {
        public int HorizontalDelta { get; }

        public MouseHorizontalWheelEventArgs(MouseDevice mouse, int timestamp, int horizontalDelta)
            : base(mouse, timestamp)
        {
            HorizontalDelta = horizontalDelta;
        }
    }
}