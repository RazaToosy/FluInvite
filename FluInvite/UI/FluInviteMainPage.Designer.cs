namespace FluInvite.UI
{
    partial class FluInviteMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxListSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSessionDateTimes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimeBetweenSessions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxNoOfPatientsInSlot = new System.Windows.Forms.TextBox();
            this.labelLocationOfSource = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Patients in Search";
            // 
            // textBoxListSize
            // 
            this.textBoxListSize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxListSize.Location = new System.Drawing.Point(239, 12);
            this.textBoxListSize.Name = "textBoxListSize";
            this.textBoxListSize.Size = new System.Drawing.Size(240, 21);
            this.textBoxListSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Session Dates and Times";
            // 
            // textBoxSessionDateTimes
            // 
            this.textBoxSessionDateTimes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSessionDateTimes.Location = new System.Drawing.Point(239, 40);
            this.textBoxSessionDateTimes.Multiline = true;
            this.textBoxSessionDateTimes.Name = "textBoxSessionDateTimes";
            this.textBoxSessionDateTimes.Size = new System.Drawing.Size(240, 99);
            this.textBoxSessionDateTimes.TabIndex = 1;
            this.textBoxSessionDateTimes.Text = "Use following format \"DD/MM/YY HH:MM,DD/MM/YY HH:MM,....\"   in Pairs to represent" +
    " Session Starts and Ends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Slot Length";
            // 
            // textBoxTimeBetweenSessions
            // 
            this.textBoxTimeBetweenSessions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeBetweenSessions.Location = new System.Drawing.Point(239, 153);
            this.textBoxTimeBetweenSessions.Name = "textBoxTimeBetweenSessions";
            this.textBoxTimeBetweenSessions.Size = new System.Drawing.Size(240, 21);
            this.textBoxTimeBetweenSessions.TabIndex = 1;
            this.textBoxTimeBetweenSessions.Text = "In Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max No Of Patients in each Slot";
            // 
            // textBoxMaxNoOfPatientsInSlot
            // 
            this.textBoxMaxNoOfPatientsInSlot.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxNoOfPatientsInSlot.Location = new System.Drawing.Point(239, 183);
            this.textBoxMaxNoOfPatientsInSlot.Name = "textBoxMaxNoOfPatientsInSlot";
            this.textBoxMaxNoOfPatientsInSlot.Size = new System.Drawing.Size(240, 21);
            this.textBoxMaxNoOfPatientsInSlot.TabIndex = 1;
            // 
            // labelLocationOfSource
            // 
            this.labelLocationOfSource.AutoSize = true;
            this.labelLocationOfSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocationOfSource.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationOfSource.Location = new System.Drawing.Point(17, 223);
            this.labelLocationOfSource.Name = "labelLocationOfSource";
            this.labelLocationOfSource.Size = new System.Drawing.Size(247, 17);
            this.labelLocationOfSource.TabIndex = 0;
            this.labelLocationOfSource.Text = "Click here to choose Location of Source csv";
            this.labelLocationOfSource.Click += new System.EventHandler(this.labelLocationOfSource_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FluInviteMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSessionDateTimes);
            this.Controls.Add(this.textBoxMaxNoOfPatientsInSlot);
            this.Controls.Add(this.textBoxTimeBetweenSessions);
            this.Controls.Add(this.textBoxListSize);
            this.Controls.Add(this.labelLocationOfSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FluInviteMainPage";
            this.Text = "Flu Invite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxListSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSessionDateTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimeBetweenSessions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxNoOfPatientsInSlot;
        private System.Windows.Forms.Label labelLocationOfSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

