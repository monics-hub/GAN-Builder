using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanBuilder.controls
{
    [DefaultEvent("_TextChanged")]
    public partial class CueTextbox : UserControl
    {
        private Panel hintBox;
        private Label hintLabel;
        private int middle;
        private int top;
        private Point point1;
        private Point point2;
        private Point point3;
        private Point[] triangle;

        public CueTextbox()
        {
            InitializeComponent();
            hintBox = new Panel();
            hintLabel = new Label();
            hintBox.Visible = false;

        }
        public enum HintStyle {Invisible, Top, Bottom, Dynamic}

        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private HintStyle hintStyle = HintStyle.Invisible;
        private Color hintBackgroundColor = Color.AliceBlue;
        private Color hintForegroundColor = Color.White;
        private Font hintFont = null;
        private string hintText = "...";

        //Events
        public event EventHandler _TextChanged;

        //Properties

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category("Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }


        [Category("Appearance")]
        public System.Windows.Forms.HorizontalAlignment TextAlign
        {
            get { return textBox1.TextAlign; }
            set { textBox1.TextAlign = value; }
        }


        [Category("Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Appearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Appearance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("Appearance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        [Category("Appearance")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }

        [Category("Appearance")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }


        [Category("Appearance")]
        public Color HintBackgroundColor 
        { 
            get => hintBackgroundColor; 
            set => hintBackgroundColor = value; 
        }

        [Category("Appearance")]
        public Color HintForegroundColor 
        { 
            get => hintForegroundColor; 
            set => hintForegroundColor = value; 
        }

        [Category("Appearance")]
        public Font HintFont 
        { 
            get => hintFont; 
            set => hintFont = value; 
        }

        [Category("Appearance")]
        public HintStyle HintStyle1 { get => hintStyle; set => hintStyle = value; }

        [Category("Appearance")]
        public string HintText 
        { 
            get => hintText; 
            set => hintText = value; 
        }

        [Category("Behavior")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Behavior")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        
        //Overridden methods

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }

            // Draw Hint
            this.Parent.Controls.Add(hintBox);
            hintBox.Controls.Add(hintLabel);
            hintBox.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            hintBox.BackColor = hintBackgroundColor;
            hintLabel.Text = hintText;
            hintLabel.ForeColor = hintForegroundColor;
            hintLabel.Font = hintFont;
            hintLabel.AutoSize = true;
            hintLabel.TextAlign = ContentAlignment.MiddleCenter;
            hintLabel.Dock = DockStyle.Fill;
            hintLabel.MaximumSize = new System.Drawing.Size(this.Width, 0);
            hintBox.Size = new Size(this.Width, hintLabel.Height + 5);
            if (hintStyle == HintStyle.Top)
            {
                hintBox.Location = new Point(this.Location.X, this.Location.Y - hintBox.Height - 10);
            }
            else
            {
                hintBox.Location = new Point(this.Location.X, this.Location.Y + this.Height + 10);
            }
            hintBox.BringToFront();

            middle = hintBox.Location.X + (hintBox.Width / 2);
            top = hintBox.Location.Y;
            point1 = new Point(middle, top - 10);
            point2 = new Point(middle - 5, top);
            point3 = new Point(middle + 5, top);
            triangle = new Point[] {point1, point2, point3 };
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            using (SolidBrush brush = new SolidBrush(hintBackgroundColor))
            {
                e.Graphics.FillPolygon(brush, triangle);
            }

        }

        private void ShowHint()
        {
            if (hintStyle!= HintStyle.Invisible)
            {
                hintBox.Visible = true;
            }

        }
        private void HideHint()
        {
            hintBox.Visible = false;
        }

        //Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
            ShowHint();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
            HideHint();
        }
    }
}
