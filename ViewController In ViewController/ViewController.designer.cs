// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestViewControllerInViewController
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton AddBtn { get; set; }

		[Outlet]
		AppKit.NSButton ClearBtn { get; set; }

		[Outlet]
		AppKit.NSStackView MyStackView { get; set; }

		//todo если ошибки тут закоментировать

		//[Action ("AddBtn:")]
		//partial void AddBtn (AppKit.NSButton sender);

		//+++


		void ReleaseDesignerOutlets ()
		{
			if (AddBtn != null) {
				AddBtn.Dispose ();
				AddBtn = null;
			}

			if (ClearBtn != null) {
				ClearBtn.Dispose ();
				ClearBtn = null;
			}

			if (MyStackView != null) {
				MyStackView.Dispose ();
				MyStackView = null;
			}
		}
	}
}
