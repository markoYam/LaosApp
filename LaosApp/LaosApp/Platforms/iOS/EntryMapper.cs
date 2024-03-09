using LaosApp.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace LaosApp.Platforms.iOS
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
                
                var control = new UITextFieldPadding();
                control.Layer.CornerRadius = viewData.CornerRadius;
                UpdateBackground(entryHandler.PlatformView, viewData);
            }
        }

        private static void UpdateBackground(UITextField control,CustomMaterialOutilineEntry entry)
        {
            if(control == null || entry == null)
            {
                return;
            }

            var paddingControl = control as UITextFieldPadding;
            paddingControl.Layer.CornerRadius = entry.CornerRadius;
            paddingControl.Layer.BorderColor = entry.BorderColor.ToCGColor();
            paddingControl.Layer.BorderWidth = entry.BorderThickness;
            paddingControl.Padding = entry.Padding;

        }
    }
}
