using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace LaosApp.Platforms.iOS
{
    public class UITextFieldPadding:UITextField
    {
        private Thickness _padding = new Thickness(0);

        public Thickness Padding
        {
            get => _padding;
            set
            {
                _padding = value;
                //SetNeedsLayout();
            }
        }

        public UITextFieldPadding()
        {
        }

        public UITextFieldPadding(NSCoder coder): base(coder)
        {
        }

        public UITextFieldPadding(CGRect rect): base(rect)
        {
        }

        public override CGRect TextRect(CGRect forBounds)
        {
            var insets = new UIEdgeInsets((nfloat)Padding.Top, (nfloat)Padding.Left, (nfloat)Padding.Bottom, (nfloat)Padding.Right);
            return insets.InsetRect(forBounds);
        }

        public override CGRect EditingRect(CGRect forBounds)
        {
            var insets = new UIEdgeInsets((nfloat)Padding.Top, (nfloat)Padding.Left, (nfloat)Padding.Bottom, (nfloat)Padding.Right);
            return insets.InsetRect(forBounds);
        }

        public override CGRect PlaceholderRect(CGRect forBounds)
        {
            var insets = new UIEdgeInsets((nfloat)Padding.Top, (nfloat)Padding.Left, (nfloat)Padding.Bottom, (nfloat)Padding.Right);
            return insets.InsetRect(forBounds);
        }
    }
}
