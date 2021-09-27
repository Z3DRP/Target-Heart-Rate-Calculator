
namespace Palmer_TargetHeartRateCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activityCmbx = new System.Windows.Forms.ComboBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.zoneChbx = new System.Windows.Forms.CheckBox();
            this.zoneTbar = new System.Windows.Forms.TrackBar();
            this.zoneLbl = new System.Windows.Forms.Label();
            this.statsListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.heartzoneLbl = new System.Windows.Forms.Label();
            this.zoneInfoLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zoneTbar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Age";
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(399, 29);
            this.ageTxt.Multiline = true;
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(95, 23);
            this.ageTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activity Type";
            // 
            // activityCmbx
            // 
            this.activityCmbx.FormattingEnabled = true;
            this.activityCmbx.Location = new System.Drawing.Point(399, 66);
            this.activityCmbx.Name = "activityCmbx";
            this.activityCmbx.Size = new System.Drawing.Size(121, 28);
            this.activityCmbx.TabIndex = 3;
            // 
            // displayBtn
            // 
            this.displayBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayBtn.Location = new System.Drawing.Point(198, 152);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(127, 36);
            this.displayBtn.TabIndex = 5;
            this.displayBtn.Text = "Display THR";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.Location = new System.Drawing.Point(338, 152);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(127, 36);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(478, 152);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 36);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // zoneChbx
            // 
            this.zoneChbx.AutoSize = true;
            this.zoneChbx.Location = new System.Drawing.Point(301, 110);
            this.zoneChbx.Name = "zoneChbx";
            this.zoneChbx.Size = new System.Drawing.Size(204, 24);
            this.zoneChbx.TabIndex = 8;
            this.zoneChbx.Text = "Show Training Zone Target";
            this.zoneChbx.UseVisualStyleBackColor = true;
            this.zoneChbx.CheckedChanged += new System.EventHandler(this.zoneChbx_CheckedChanged);
            // 
            // zoneTbar
            // 
            this.zoneTbar.Location = new System.Drawing.Point(16, 72);
            this.zoneTbar.Maximum = 100;
            this.zoneTbar.Minimum = 50;
            this.zoneTbar.Name = "zoneTbar";
            this.zoneTbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoneTbar.Size = new System.Drawing.Size(45, 289);
            this.zoneTbar.SmallChange = 2;
            this.zoneTbar.TabIndex = 9;
            this.zoneTbar.Value = 50;
            this.zoneTbar.Scroll += new System.EventHandler(this.zoneTbar_Scroll);
            // 
            // zoneLbl
            // 
            this.zoneLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.zoneLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zoneLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zoneLbl.Location = new System.Drawing.Point(16, 23);
            this.zoneLbl.Name = "zoneLbl";
            this.zoneLbl.Size = new System.Drawing.Size(298, 49);
            this.zoneLbl.TabIndex = 10;
            this.zoneLbl.Text = "Training Zone";
            this.zoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsListview
            // 
            this.statsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.statsListview.HideSelection = false;
            this.statsListview.Location = new System.Drawing.Point(106, 216);
            this.statsListview.Name = "statsListview";
            this.statsListview.Size = new System.Drawing.Size(588, 119);
            this.statsListview.TabIndex = 18;
            this.statsListview.UseCompatibleStateImageBehavior = false;
            this.statsListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Age";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Max Heart Rate";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Activity Type";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Target Heart Rate Zone";
            this.columnHeader4.Width = 175;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 53);
            this.label3.TabIndex = 19;
            this.label3.Text = "Maximal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DeepPink;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(87, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 52);
            this.label4.TabIndex = 20;
            this.label4.Text = "Anaerobic";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.BlueViolet;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 53);
            this.label5.TabIndex = 21;
            this.label5.Text = "Steady State";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(87, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 64);
            this.label6.TabIndex = 22;
            this.label6.Text = "Aerobic";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Lavender;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(87, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 53);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fat Burning";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heartzoneLbl
            // 
            this.heartzoneLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.heartzoneLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heartzoneLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heartzoneLbl.Location = new System.Drawing.Point(324, 256);
            this.heartzoneLbl.Name = "heartzoneLbl";
            this.heartzoneLbl.Size = new System.Drawing.Size(241, 49);
            this.heartzoneLbl.TabIndex = 17;
            // 
            // zoneInfoLbl
            // 
            this.zoneInfoLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.zoneInfoLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zoneInfoLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zoneInfoLbl.Location = new System.Drawing.Point(324, 121);
            this.zoneInfoLbl.Name = "zoneInfoLbl";
            this.zoneInfoLbl.Size = new System.Drawing.Size(241, 97);
            this.zoneInfoLbl.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.zoneLbl);
            this.groupBox1.Controls.Add(this.zoneInfoLbl);
            this.groupBox1.Controls.Add(this.heartzoneLbl);
            this.groupBox1.Controls.Add(this.zoneTbar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(106, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 370);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(349, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Your THR for zone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(349, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Zone Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 786);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statsListview);
            this.Controls.Add(this.zoneChbx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.activityCmbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Target Heart Rate (THR) Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoneTbar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox activityCmbx;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox zoneChbx;
        private System.Windows.Forms.TrackBar zoneTbar;
        private System.Windows.Forms.Label zoneLbl;
        private System.Windows.Forms.ListView statsListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label heartzoneLbl;
        private System.Windows.Forms.Label zoneInfoLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

