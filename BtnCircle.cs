using System.Drawing.Drawing2D;

namespace ATLS_TALKHAND
{
    class BtnCircle : Button
    {
        protected override void OnPaint(PaintEventArgs pevent) {
           
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }

    }
}
