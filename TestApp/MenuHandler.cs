using System;
using CefSharp;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Diagnostics;

public class MenuHandler : IContextMenuHandler
{
    public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
    {
        // Remove any existent option using the Clear method of the model
        //
        //model.Clear();

        

        //Console.WriteLine("Context menu opened !");

        // You can add a separator in case that there are more items on the list
        if (model.Count > 0)
        {
            model.AddSeparator();
        }

        

        // Add a new item to the list using the AddItem method of the model
        model.AddItem((CefMenuCommand)26501, "Show DevTools");
        model.AddItem((CefMenuCommand)26502, "Close DevTools");

        // Add a separator
        model.AddSeparator();

        model.AddItem((CefMenuCommand)26503, "Set 100% zoom");
        model.AddItem((CefMenuCommand)26504, "Set 50% zoom");
        model.AddItem((CefMenuCommand)26505, "Set 150% zoom");

        model.AddSeparator();

        model.AddItem((CefMenuCommand)26506, "Screenshot");

        
    }


    public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
    {
        // React to the first ID (show dev tools method)
        if (commandId == (CefMenuCommand)26501)
        {
            browser.GetHost().ShowDevTools();
            return true;
        }

        // React to the second ID (show dev tools method)
        if (commandId == (CefMenuCommand)26502)
        {
            browser.GetHost().CloseDevTools();
            return true;
        }

        // React to the third ID
        if (commandId == (CefMenuCommand)26503)
        {
            browser.SetZoomLevel(0);
            return true;
        }


        if (commandId == (CefMenuCommand)26504)
        {
            browser.SetZoomLevel(-5);
            return true;
        }

        if (commandId == (CefMenuCommand)26505)
        {
            browser.SetZoomLevel(5);
            return true;
        }

        int filenumber = 0;

        if (commandId == (CefMenuCommand)26506)
        {
            filenumber += 1;
            Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
            System.Threading.Thread.Sleep(1000);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            captureBitmap.Save(@"C:\tmp\capture" + filenumber + ".jpeg", ImageFormat.Jpeg);
            Process.Start(@"C:\tmp\capture" + filenumber + ".jpeg");
        }
    
        return false;
    }

    public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
    {

    }

    public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
    {
        return false;
    }
}