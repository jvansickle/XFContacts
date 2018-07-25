using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace XFContacts.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        NSWindow _window;

        public override NSWindow MainWindow => _window;
        
        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
            var height = 1136;
            var width = 640;

            var rect = new CoreGraphics.CGRect(NSScreen.MainScreen.VisibleFrame.Width - (width / 2),
                                               NSScreen.MainScreen.VisibleFrame.Height - (height / 2),
                                               width,
                                               height);

            _window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            _window.Title = "";
            _window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
