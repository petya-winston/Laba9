namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxModules = new System.Windows.Forms.ListBox();
            this.listBoxComponents = new System.Windows.Forms.ListBox();
            this.buttonAddModule = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(200, 24);
            this.labelTitle.Text = "Study Program Composer";

            this.listBoxModules.FormattingEnabled = true;
            this.listBoxModules.Location = new System.Drawing.Point(16, 50);
            this.listBoxModules.Size = new System.Drawing.Size(200, 200);

            this.listBoxComponents.FormattingEnabled = true;
            this.listBoxComponents.Location = new System.Drawing.Point(250, 50);
            this.listBoxComponents.Size = new System.Drawing.Size(200, 200);

            this.buttonAddModule.Location = new System.Drawing.Point(16, 260);
            this.buttonAddModule.Size = new System.Drawing.Size(200, 30);
            this.buttonAddModule.Text = "Add Module";
            this.buttonAddModule.Click += new System.EventHandler(this.buttonAddModule_Click);

            this.buttonAddComponent.Location = new System.Drawing.Point(250, 260);
            this.buttonAddComponent.Size = new System.Drawing.Size(200, 30);
            this.buttonAddComponent.Text = "Add Component";
            this.buttonAddComponent.Click += new System.EventHandler(this.buttonAddComponent_Click);

            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxModules);
            this.Controls.Add(this.listBoxComponents);
            this.Controls.Add(this.buttonAddModule);
            this.Controls.Add(this.buttonAddComponent);
            this.Text = "Study Program Composer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxModules;
        private System.Windows.Forms.ListBox listBoxComponents;
        private System.Windows.Forms.Button buttonAddModule;
        private System.Windows.Forms.Button buttonAddComponent;
    }
}

