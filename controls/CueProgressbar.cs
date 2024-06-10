using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanBuilder.controls
{
    class CueProgressbar: UserControl
    {
        public CueProgressbar()
        {
            this.Height = 20;
            this.Width = 200;
            BackColor = Color.Gray;
        }
        private Color sliderColor = Color.RoyalBlue;
        private int channelHeight = 20;
        private int sliderHeight = 20;
        private int value = 20;

        [Category("Appearance")]
        public Color SliderColor { get => sliderColor; 
            set {sliderColor = value;
                this.Invalidate();
            }}

        [Category("Appearance")]
        public int ChannelHeight
        {
            get => channelHeight;
            set{channelHeight = value;
                this.Invalidate();
                this.Height = channelHeight;
            }
        }

        [Category("Appearance")]
        public int SliderHeight { get => sliderHeight; 
            set { sliderHeight = value; 
                this.Invalidate(); 
            }}

        [Category("Behavior")]
        public int Value { get => value; 
            set { this.value = value;
                this.Invalidate();
            }}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            SolidBrush channelBrush = new SolidBrush(BackColor);
            SolidBrush sliderBrush = new SolidBrush(sliderColor);
            int channelWidth = this.Width;
            int sliderWidth = (this.Width*value) /100;
            channelHeight = this.Height;
            Rectangle channel = new Rectangle();
            Rectangle slider = new Rectangle();
    
            int diff = (channelHeight - sliderHeight) / 2;
            channel = new Rectangle(0, 0, channelWidth, channelHeight);
            slider = new Rectangle(0, diff, sliderWidth, sliderHeight);

            graph.FillRectangle(channelBrush, channel);
            graph.FillRectangle(sliderBrush, slider);

        }

    }
}
