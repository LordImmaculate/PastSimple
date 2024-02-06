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
            this.components = new System.ComponentModel.Container();
            this.labelVerb = new System.Windows.Forms.Label();
            this.labelVerbInfo = new System.Windows.Forms.Label();
            this.textBoxVerb = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelPastSimpleInfo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonMute = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVerb
            // 
            this.labelVerb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerb.Location = new System.Drawing.Point(109, 133);
            this.labelVerb.Name = "labelVerb";
            this.labelVerb.Size = new System.Drawing.Size(258, 29);
            this.labelVerb.TabIndex = 2;
            this.labelVerb.Text = "labelVerb";
            this.labelVerb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVerbInfo
            // 
            this.labelVerbInfo.Location = new System.Drawing.Point(222, 120);
            this.labelVerbInfo.Name = "labelVerbInfo";
            this.labelVerbInfo.Size = new System.Drawing.Size(32, 13);
            this.labelVerbInfo.TabIndex = 3;
            this.labelVerbInfo.Text = "Verb:";
            // 
            // textBoxVerb
            // 
            this.textBoxVerb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVerb.Location = new System.Drawing.Point(188, 180);
            this.textBoxVerb.MaxLength = 15;
            this.textBoxVerb.Name = "textBoxVerb";
            this.textBoxVerb.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerb.TabIndex = 4;
            this.textBoxVerb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxVerb_KeyDown);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(201, 203);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelPastSimpleInfo
            // 
            this.labelPastSimpleInfo.Location = new System.Drawing.Point(188, 162);
            this.labelPastSimpleInfo.Name = "labelPastSimpleInfo";
            this.labelPastSimpleInfo.Size = new System.Drawing.Size(100, 23);
            this.labelPastSimpleInfo.TabIndex = 6;
            this.labelPastSimpleInfo.Text = "In the Past Simple";
            this.labelPastSimpleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelCorrect
            // 
            this.labelCorrect.Location = new System.Drawing.Point(181, 226);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(115, 23);
            this.labelCorrect.TabIndex = 7;
            this.labelCorrect.Text = "labelCorrect";
            this.labelCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCorrect.Visible = false;
            // 
            // labelSolution
            // 
            this.labelSolution.Location = new System.Drawing.Point(114, 249);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(248, 19);
            this.labelSolution.TabIndex = 8;
            this.labelSolution.Text = "labelSolution";
            this.labelSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSolution.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonMute
            // 
            this.toolStripButtonMute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMute.Image = global::PastSimple.Properties.Resources.muted;
            this.toolStripButtonMute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMute.Name = "toolStripButtonMute";
            this.toolStripButtonMute.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMute.Text = "toolStripButton1";
            this.toolStripButtonMute.Click += new System.EventHandler(this.toolStripButtonMute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelPastSimpleInfo);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.textBoxVerb);
            this.Controls.Add(this.labelVerbInfo);
            this.Controls.Add(this.labelVerb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Past Simple Game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private ErrorProvider errorProvider;
        private Label labelCorrect;
        private Label labelSolution;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonMute;
    }
}

