using System.Windows.Forms;

namespace PastSimple
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelVerb = new System.Windows.Forms.Label();
            this.labelVerbInfo = new System.Windows.Forms.Label();
            this.textBoxVerb = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelPastSimpleInfo = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.toolStripButtonMute = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelCorrect = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelIncorrect = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVerb
            // 
            this.labelVerb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVerb.CausesValidation = false;
            this.labelVerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerb.Location = new System.Drawing.Point(218, 256);
            this.labelVerb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVerb.Name = "labelVerb";
            this.labelVerb.Size = new System.Drawing.Size(516, 56);
            this.labelVerb.TabIndex = 2;
            this.labelVerb.Text = "labelVerb";
            this.labelVerb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVerbInfo
            // 
            this.labelVerbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVerbInfo.Location = new System.Drawing.Point(444, 231);
            this.labelVerbInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVerbInfo.Name = "labelVerbInfo";
            this.labelVerbInfo.Size = new System.Drawing.Size(64, 25);
            this.labelVerbInfo.TabIndex = 3;
            this.labelVerbInfo.Text = "Verb:";
            // 
            // textBoxVerb
            // 
            this.textBoxVerb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxVerb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVerb.Location = new System.Drawing.Point(376, 346);
            this.textBoxVerb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxVerb.MaxLength = 15;
            this.textBoxVerb.Name = "textBoxVerb";
            this.textBoxVerb.Size = new System.Drawing.Size(196, 31);
            this.textBoxVerb.TabIndex = 4;
            this.textBoxVerb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxVerb_KeyDown);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Location = new System.Drawing.Point(402, 390);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(150, 44);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelPastSimpleInfo
            // 
            this.labelPastSimpleInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPastSimpleInfo.Location = new System.Drawing.Point(376, 312);
            this.labelPastSimpleInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPastSimpleInfo.Name = "labelPastSimpleInfo";
            this.labelPastSimpleInfo.Size = new System.Drawing.Size(200, 44);
            this.labelPastSimpleInfo.TabIndex = 6;
            this.labelPastSimpleInfo.Text = "In the Past Simple";
            this.labelPastSimpleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorrect
            // 
            this.labelCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorrect.Location = new System.Drawing.Point(362, 435);
            this.labelCorrect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(230, 44);
            this.labelCorrect.TabIndex = 7;
            this.labelCorrect.Text = "labelCorrect";
            this.labelCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCorrect.Visible = false;
            // 
            // labelSolution
            // 
            this.labelSolution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSolution.Location = new System.Drawing.Point(228, 479);
            this.labelSolution.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(496, 37);
            this.labelSolution.TabIndex = 8;
            this.labelSolution.Text = "labelSolution";
            this.labelSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSolution.Visible = false;
            // 
            // toolStripButtonMute
            // 
            this.toolStripButtonMute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMute.Image = global::PastSimple.Properties.Resources.unmuted;
            this.toolStripButtonMute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMute.Name = "toolStripButtonMute";
            this.toolStripButtonMute.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonMute.Text = "Mute Audio";
            this.toolStripButtonMute.Click += new System.EventHandler(this.toolStripButtonMute_Click);
            // 
            // toolStripLabelCorrect
            // 
            this.toolStripLabelCorrect.Name = "toolStripLabelCorrect";
            this.toolStripLabelCorrect.Size = new System.Drawing.Size(116, 44);
            this.toolStripLabelCorrect.Text = "Correct: 0";
            // 
            // toolStripLabelIncorrect
            // 
            this.toolStripLabelIncorrect.Name = "toolStripLabelIncorrect";
            this.toolStripLabelIncorrect.Size = new System.Drawing.Size(132, 44);
            this.toolStripLabelIncorrect.Text = "Incorrect: 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMute,
            this.toolStripLabelCorrect,
            this.toolStripLabelIncorrect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(968, 50);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 694);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelPastSimpleInfo);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.textBoxVerb);
            this.Controls.Add(this.labelVerbInfo);
            this.Controls.Add(this.labelVerb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Past Simple Game";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVerb;
        private System.Windows.Forms.Label labelVerbInfo;
        private System.Windows.Forms.TextBox textBoxVerb;
        private Button btnEnter;
        private Label labelPastSimpleInfo;
        private Label labelCorrect;
        private Label labelSolution;
        private ToolStripButton toolStripButtonMute;
        private ToolStripLabel toolStripLabelCorrect;
        private ToolStripLabel toolStripLabelIncorrect;
        private ToolStrip toolStrip1;
    }
}

