namespace WinFormsControl
{
    partial class SampleControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleControl));
            this.Label1 = new Label();
            this.txtInput = new TextBox();
            this.Label2 = new Label();
            this.txtOutput = new TextBox();
            this.btnRun = new Button();
            this.btnClear = new Button();
            this.SuspendLayout();
            //
            // Label1
            //
            resources.ApplyResources(Label1, "Label1");
            Label1.Name = "Label1";
            //
            // txtInput
            //
            resources.ApplyResources(txtInput, "txtInput");
            txtInput.Name = "txtInput";
            //
            // Label2
            resources.ApplyResources(Label2, "Label2");
            Label2.Name = "Label2";
            //
            // txtOutput
            //
            resources.ApplyResources(txtOutput, "txtOutput");
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            //
            // btnRun
            //
            resources.ApplyResources(btnRun, "btnRun");
            btnRun.Name = "btnRun";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            //
            // btnClear
            //
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.Name = "btnClear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            //
            // SampleControl
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(Label1);
            this.Controls.Add(txtInput);
            this.Controls.Add(Label2);
            this.Controls.Add(txtOutput);
            this.Controls.Add(btnRun);
            this.Controls.Add(btnClear);
            resources.ApplyResources(this, "$this");
            this.Name = "SampleControl";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label Label1;
        private TextBox txtInput;
        private Label Label2;
        private TextBox txtOutput;
        private Button btnRun;
        private Button btnClear;
    }
}
