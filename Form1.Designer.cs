namespace NASA_By_Janar
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

    #region Code généré par le Concepteur de composants

    private void InitializeComponent()
    {
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label1 = new System.Windows.Forms.Label();
        this.backButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.pictureBox1.Location = new System.Drawing.Point(12, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(776, 426);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // label1
        // 
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.label1.Location = new System.Drawing.Point(12, 451);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(776, 87);
        this.label1.TabIndex = 1;
        this.label1.Text = "label1";
        // 
        // backButton
        // 
        this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.backButton.Location = new System.Drawing.Point(713, 541);
        this.backButton.Name = "backButton";
        this.backButton.Size = new System.Drawing.Size(75, 23);
        this.backButton.TabIndex = 2;
        this.backButton.Text = "Retour";
        this.backButton.UseVisualStyleBackColor = true;
        this.backButton.Click +=
new System.EventHandler(this.backButton_Click);
//
// Form1
//
this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(800, 576);
this.Controls.Add(this.backButton);
this.Controls.Add(this.label1);
this.Controls.Add(this. pictureBox1);
this.Name = "Form1";
this.Text = "Form1";
((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
this.ResumeLayout(false);

}

#endregion

private System.Windows.Forms.PictureBox pictureBox1;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Button backButton;

}
}