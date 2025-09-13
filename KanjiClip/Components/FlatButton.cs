using FlatUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace KanjiClip.Components
{
    // A custom FlatButton control supporting custom back colors (original theme lacks this feature for some reason  ? ? ?)
    public class FlatButton : Control
    {
        private int W;
        private int H;
        private bool _Rounded = false;
        private MouseState State = MouseState.None;

        private Color _BaseColor = Helpers.FlatColor;
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; Invalidate(); }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; Invalidate(); }
        }

        [Category("Options")]
        public bool Rounded
        {
            get { return _Rounded; }
            set { _Rounded = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "243, 243, 243")]
        public override Color ForeColor
        {
            get { return _TextColor; }
            set
            {
                _TextColor = value;
                base.ForeColor = value;
                Invalidate();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        public FlatButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor, true);

            DoubleBuffered = true;
            Size = new Size(106, 32);
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 12);
            Cursor = Cursors.Hand;
            ForeColor = _TextColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            using (Bitmap B = new Bitmap(Width, Height))
            using (Graphics G = Graphics.FromImage(B))
            {
                W = Width - 1;
                H = Height - 1;

                Rectangle Base = new Rectangle(0, 0, W, H);

                G.SmoothingMode = SmoothingMode.HighQuality;
                G.PixelOffsetMode = PixelOffsetMode.HighQuality;
                G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                G.Clear(BackColor);

                using (Brush textBrush = new SolidBrush(_TextColor))
                {
                    switch (State)
                    {
                        case MouseState.None:
                            DrawButton(G, Base, textBrush, null);
                            break;
                        case MouseState.Over:
                            DrawButton(G, Base, textBrush, Color.FromArgb(20, Color.White));
                            break;
                        case MouseState.Down:
                            DrawButton(G, Base, textBrush, Color.FromArgb(20, Color.Black));
                            break;
                    }
                }

                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                e.Graphics.DrawImageUnscaled(B, 0, 0);
            }

            base.OnPaint(e);
        }

        private void DrawButton(Graphics G, Rectangle rect, Brush textBrush, Color? overlay)
        {
            if (Rounded)
            {
                using (GraphicsPath GP = Helpers.RoundRec(rect, 6))
                {
                    G.FillPath(new SolidBrush(_BaseColor), GP);
                    if (overlay.HasValue) G.FillPath(new SolidBrush(overlay.Value), GP);
                    G.DrawString(Text, Font, textBrush, rect, Helpers.CenterSF);
                }
            }
            else
            {
                G.FillRectangle(new SolidBrush(_BaseColor), rect);
                if (overlay.HasValue) G.FillRectangle(new SolidBrush(overlay.Value), rect);
                G.DrawString(Text, Font, textBrush, rect, Helpers.CenterSF);
            }
        }

        private void UpdateColors()
        {
            if (_BaseColor == Color.Empty)
            {
                FlatColors colors = Helpers.GetColors(this);
                _BaseColor = colors.Flat;
            }
        }

    }
}
