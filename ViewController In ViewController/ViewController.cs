using System;

using AppKit;
using Foundation;

namespace TestViewControllerInViewController
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MyStackView.AddView(new NSVisualEffectView(), NSStackViewGravity.Bottom);
			SetActions();
			// Do any additional setup after loading the view.
		}

		private void SetActions() { 
			ClearBtn.Activated += (sender, e) => {
				MyStackView.AddView(CreateView(), NSStackViewGravity.Top);
			};
		}

		private NSView CreateView()
		{
			var controller = (NSViewController)this.Storyboard.InstantiateControllerWithIdentifier("FilterView");

			AddChildViewController(controller);

			return controller.View;
		}

		public void RemoveMyView(FilterViewController controller)
		{
			MyStackView.RemoveView(controller.View);
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
