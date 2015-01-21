namespace CR_ReverseBoolean
{
	partial class ReverseBooleanPlugIn
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ReverseBooleanPlugIn()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReverseBooleanPlugIn));
			this.rpReverseBoolean = new DevExpress.Refactor.Core.RefactoringProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.rpReverseBoolean)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// rpReverseBoolean
			// 
			this.rpReverseBoolean.ActionHintText = "";
			this.rpReverseBoolean.AutoActivate = true;
			this.rpReverseBoolean.AutoUndo = false;
			this.rpReverseBoolean.CodeIssueMessage = null;
			this.rpReverseBoolean.Description = resources.GetString("rpReverseBoolean.Description");
			this.rpReverseBoolean.Image = ((System.Drawing.Bitmap)(resources.GetObject("rpReverseBoolean.Image")));
			this.rpReverseBoolean.NeedsSelection = false;
			this.rpReverseBoolean.ProviderName = "Reverse Boolean";
			this.rpReverseBoolean.Register = true;
			this.rpReverseBoolean.SupportsAsyncMode = false;
			this.rpReverseBoolean.CheckAvailability += new DevExpress.Refactor.Core.CheckAvailabilityEventHandler(this.rpReverseBoolean_CheckAvailability);
			this.rpReverseBoolean.Apply += new DevExpress.Refactor.Core.ApplyRefactoringEventHandler(this.rpReverseBoolean_Apply);
			this.rpReverseBoolean.PreparePreview += new DevExpress.Refactor.Core.PrepareRefactoringPreviewEventHandler(this.rpReverseBoolean_PreparePreview);
			((System.ComponentModel.ISupportInitialize)(this.rpReverseBoolean)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.Refactor.Core.RefactoringProvider rpReverseBoolean;
	}
}