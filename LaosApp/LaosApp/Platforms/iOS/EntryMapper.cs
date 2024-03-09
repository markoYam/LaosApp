using LaosApp.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;

namespace LaosApp.Controls
{
    public static class EntryMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            if (handler == null || view == null)
                return;

            if (view is CustomMaterialOutilineEntry viewData)
            {
                var entryHandler = (EntryHandler)handler;

                UpdateBackground(entryHandler.PlatformView, viewData);

                var padddingViewLeft = new UIView(new CoreGraphics.CGRect(0, 0, viewData.Padding.Left, 0));
                var padddingViewRight = new UIView(new CoreGraphics.CGRect(0, 0, viewData.Padding.Right, 0));
                
                entryHandler.PlatformView.LeftView = padddingViewLeft;
                entryHandler.PlatformView.LeftViewMode = UITextFieldViewMode.Always;

                entryHandler.PlatformView.RightView = padddingViewRight;
                entryHandler.PlatformView.RightViewMode = UITextFieldViewMode.Always;
            }
        }

        private static void UpdateBackground(UITextField control,CustomMaterialOutilineEntry entry)
        {
            if(control == null || entry == null)
            {
                return;
            }

            control.Layer.CornerRadius = entry.CornerRadius;
            control.Layer.BorderColor = entry.BorderColor.ToCGColor();
            control.Layer.BorderWidth = entry.BorderThickness;
            control.BorderStyle = UITextBorderStyle.Line;
           
            //control.Padding = entry.Padding;

        }
    }
}
