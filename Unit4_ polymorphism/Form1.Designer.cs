namespace Unit4__polymorphism
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
			label1 = new Label();
			label2 = new Label();
			txtoption_Unit = new TextBox();
			txtvalue = new TextBox();
			label3 = new Label();
			btn_convert = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(120, 52);
			label1.Name = "label1";
			label1.Size = new Size(312, 78);
			label1.TabIndex = 0;
			label1.Text = "CONVERSION FROM \r\n      UNITS TO CM";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkOrange;
			label2.Location = new Point(195, 224);
			label2.Name = "label2";
			label2.Size = new Size(170, 63);
			label2.TabIndex = 1;
			label2.Text = "Unit to be converte: \r\n-Kilometers\r\n-Feet";
			// 
			// txtoption_Unit
			// 
			txtoption_Unit.Location = new Point(195, 290);
			txtoption_Unit.Name = "txtoption_Unit";
			txtoption_Unit.Size = new Size(153, 23);
			txtoption_Unit.TabIndex = 2;
		
			// 
			// txtvalue
			// 
			txtvalue.Location = new Point(195, 187);
			txtvalue.Name = "txtvalue";
			txtvalue.Size = new Size(153, 23);
			txtvalue.TabIndex = 4;
			txtvalue.TextChanged += txtvalue_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkOrange;
			label3.Location = new Point(204, 152);
			label3.Name = "label3";
			label3.Size = new Size(137, 21);
			label3.TabIndex = 3;
			label3.Text = "Enter the value: ";
			// 
			// btn_convert
			// 
			btn_convert.BackColor = Color.DarkOrange;
			btn_convert.FlatStyle = FlatStyle.Flat;
			btn_convert.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn_convert.ForeColor = Color.Snow;
			btn_convert.Location = new Point(204, 335);
			btn_convert.Name = "btn_convert";
			btn_convert.Size = new Size(137, 45);
			btn_convert.TabIndex = 5;
			btn_convert.Text = "CONVERT";
			btn_convert.UseVisualStyleBackColor = false;
			btn_convert.UseWaitCursor = true;
			btn_convert.Click += btn_convert_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGoldenrodYellow;
			ClientSize = new Size(569, 428);
			Controls.Add(btn_convert);
			Controls.Add(txtvalue);
			Controls.Add(label3);
			Controls.Add(txtoption_Unit);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CONVERSION";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtoption_Unit;
		private TextBox txtvalue;
		private Label label3;
		private Button btn_convert;
	}
}
