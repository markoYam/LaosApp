using Microsoft.Maui.Handlers;
using Android.Graphics.Drawables;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using LaosApp.Controls;

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
                var gradient = new GradientDrawable();
                gradient.SetCornerRadius(handler.MauiContext?.Context.ToPixels(viewData.CornerRadius) ?? 0);
                gradient.SetStroke((int)handler.MauiContext?.Context.ToPixels(viewData.BorderThickness), viewData.BorderColor.ToAndroid());

                entryHandler.PlatformView.Background = gradient;

                var padtop = handler.MauiContext?.Context.ToPixels(viewData.Padding.Top) ?? 0;
                var padleft = handler.MauiContext?.Context.ToPixels(viewData.Padding.Left) ?? 0;
                var padright = handler.MauiContext?.Context.ToPixels(viewData.Padding.Right) ?? 0;
                var padbottom = handler.MauiContext?.Context.ToPixels(viewData.Padding.Bottom) ?? 0;

                entryHandler.PlatformView.SetPadding((int)padleft, (int)padtop, (int)padright, (int)padbottom);


            }
        }
    }
}
