
namespace Employee_Class
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.GroupBox();
            this.idBox = new System.Windows.Forms.GroupBox();
            this.deptBox = new System.Windows.Forms.GroupBox();
            this.positionBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "List Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(185, 350);
            this.nameBox.TabIndex = 1;
            this.nameBox.TabStop = false;
            this.nameBox.Text = "Employee Name";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(203, 25);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(185, 350);
            this.idBox.TabIndex = 0;
            this.idBox.TabStop = false;
            this.idBox.Text = "Employee ID";
            // 
            // deptBox
            // 
            this.deptBox.Location = new System.Drawing.Point(394, 25);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(185, 350);
            this.deptBox.TabIndex = 0;
            this.deptBox.TabStop = false;
            this.deptBox.Text = "Employee Department";
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(585, 25);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(185, 350);
            this.positionBox.TabIndex = 0;
            this.positionBox.TabStop = false;
            this.positionBox.Text = "Employee Position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.deptBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox nameBox;
        private System.Windows.Forms.GroupBox idBox;
        private System.Windows.Forms.GroupBox deptBox;
        private System.Windows.Forms.GroupBox positionBox;
    }
}

