namespace Evaluation_Manager
{
	partial class FrmEvaluation
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboActivities = new System.Windows.Forms.ComboBox();
			this.txtMinForSignature = new System.Windows.Forms.TextBox();
			this.txtMinForGrade = new System.Windows.Forms.TextBox();
			this.txtActivityDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTeacher = new System.Windows.Forms.TextBox();
			this.txtEvaluationDate = new System.Windows.Forms.TextBox();
			this.numPoints = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(31, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aktivnost";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(376, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Uvjet za potpis:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(593, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Uvjet za ocjenu:";
			// 
			// cboActivities
			// 
			this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboActivities.FormattingEnabled = true;
			this.cboActivities.Location = new System.Drawing.Point(34, 54);
			this.cboActivities.Name = "cboActivities";
			this.cboActivities.Size = new System.Drawing.Size(252, 21);
			this.cboActivities.TabIndex = 3;
			this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cbo_Activities_SelectedIndexChanged);
			// 
			// txtMinForSignature
			// 
			this.txtMinForSignature.Location = new System.Drawing.Point(366, 54);
			this.txtMinForSignature.Name = "txtMinForSignature";
			this.txtMinForSignature.Size = new System.Drawing.Size(159, 20);
			this.txtMinForSignature.TabIndex = 4;
			// 
			// txtMinForGrade
			// 
			this.txtMinForGrade.Location = new System.Drawing.Point(596, 54);
			this.txtMinForGrade.Name = "txtMinForGrade";
			this.txtMinForGrade.Size = new System.Drawing.Size(145, 20);
			this.txtMinForGrade.TabIndex = 5;
			// 
			// txtActivityDescription
			// 
			this.txtActivityDescription.Location = new System.Drawing.Point(36, 97);
			this.txtActivityDescription.Multiline = true;
			this.txtActivityDescription.Name = "txtActivityDescription";
			this.txtActivityDescription.Size = new System.Drawing.Size(705, 174);
			this.txtActivityDescription.TabIndex = 6;
			this.txtActivityDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(402, 303);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ocjenjivač:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(538, 303);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Datum evaluacije:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(668, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Bodovi:";
			// 
			// txtTeacher
			// 
			this.txtTeacher.Location = new System.Drawing.Point(405, 319);
			this.txtTeacher.Multiline = true;
			this.txtTeacher.Name = "txtTeacher";
			this.txtTeacher.ReadOnly = true;
			this.txtTeacher.Size = new System.Drawing.Size(103, 18);
			this.txtTeacher.TabIndex = 10;
			// 
			// txtEvaluationDate
			// 
			this.txtEvaluationDate.Location = new System.Drawing.Point(541, 319);
			this.txtEvaluationDate.Multiline = true;
			this.txtEvaluationDate.Name = "txtEvaluationDate";
			this.txtEvaluationDate.ReadOnly = true;
			this.txtEvaluationDate.Size = new System.Drawing.Size(103, 18);
			this.txtEvaluationDate.TabIndex = 11;
			this.txtEvaluationDate.TextChanged += new System.EventHandler(this.txtEvaluationDate_TextChanged);
			// 
			// numPoints
			// 
			this.numPoints.Location = new System.Drawing.Point(671, 317);
			this.numPoints.Name = "numPoints";
			this.numPoints.ReadOnly = true;
			this.numPoints.Size = new System.Drawing.Size(70, 20);
			this.numPoints.TabIndex = 12;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(530, 370);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(96, 31);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Spremi";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(662, 370);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(96, 31);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Odustani";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FrmEvaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 413);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.numPoints);
			this.Controls.Add(this.txtEvaluationDate);
			this.Controls.Add(this.txtTeacher);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtActivityDescription);
			this.Controls.Add(this.txtMinForGrade);
			this.Controls.Add(this.txtMinForSignature);
			this.Controls.Add(this.cboActivities);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmEvaluation";
			this.Text = "FrmEvaluation";
			this.Load += new System.EventHandler(this.FrmEvaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboActivities;
		private System.Windows.Forms.TextBox txtMinForSignature;
		private System.Windows.Forms.TextBox txtMinForGrade;
		private System.Windows.Forms.TextBox txtActivityDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTeacher;
		private System.Windows.Forms.TextBox txtEvaluationDate;
		private System.Windows.Forms.NumericUpDown numPoints;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}