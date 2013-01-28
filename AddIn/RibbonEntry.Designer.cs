namespace AddIn
{
    partial class RibbonEntry : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonEntry()
            : base(Globals.Factory.GetRibbonFactory())
        {
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.commitBtn = this.Factory.CreateRibbonButton();
            this.pushBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabReviewWord";
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabReviewWord";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.commitBtn);
            this.group1.Items.Add(this.pushBtn);
            this.group1.Label = "WordGit";
            this.group1.Name = "group1";
            // 
            // commitBtn
            // 
            this.commitBtn.Label = "Commit";
            this.commitBtn.Name = "commitBtn";
            // 
            // pushBtn
            // 
            this.pushBtn.Label = "Push";
            this.pushBtn.Name = "pushBtn";
            // 
            // RibbonEntry
            // 
            this.Name = "RibbonEntry";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonEntry_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton commitBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pushBtn;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonEntry RibbonEntry
        {
            get { return this.GetRibbon<RibbonEntry>(); }
        }
    }
}
