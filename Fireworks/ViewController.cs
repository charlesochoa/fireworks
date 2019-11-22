using Foundation;
using System;
using UIKit;

namespace Fireworks
{
    public partial class ViewController : UIViewController
    {
        public SimpleParticleGen Spg;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Spg = new SimpleParticleGen(UIImage.FromFile("xamlogo.png"), View);

            buttonStart.TouchUpInside += delegate(object s, EventArgs e)
            {
                Spg.Start();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void SwitchNight_ValueChanged (UISwitch sender)
        {
            if(sender.On)
            {
                View.BackgroundColor = UIColor.FromRGB(12,5,17);
                labelNight.TextColor = UIColor.White;
                labelSize.TextColor = UIColor.White;
            } else
            {
                View.BackgroundColor = UIColor.White;
                labelNight.TextColor = UIColor.FromRGB(12, 5, 17);
                labelSize.TextColor = UIColor.FromRGB(12, 5, 17);
            }
        }

        partial void SliderSize_ValueChanged(UISlider sender)
        {
            Spg.ScaleMax = (nfloat) sender.Value;
        }

    }
}