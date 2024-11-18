namespace practice5
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
			addHomeApplianceButton = new Button();
			removeButton = new Button();
			printButton = new Button();
			brandTextBox = new TextBox();
			priceTextBox = new TextBox();
			paramTextBox = new TextBox();
			printTextBox = new TextBox();
			addMicrowaveButton = new Button();
			addFridgeButton = new Button();
			SuspendLayout();
			// 
			// addHomeApplianceButton
			// 
			addHomeApplianceButton.Location = new Point(12, 52);
			addHomeApplianceButton.Name = "addHomeApplianceButton";
			addHomeApplianceButton.Size = new Size(100, 23);
			addHomeApplianceButton.TabIndex = 0;
			addHomeApplianceButton.Text = "Add Home Appliance";
			addHomeApplianceButton.UseVisualStyleBackColor = true;
			addHomeApplianceButton.Click += addHomeApplianceButton_Click;
			// 
			// removeButton
			// 
			removeButton.Location = new Point(12, 92);
			removeButton.Name = "removeButton";
			removeButton.Size = new Size(100, 23);
			removeButton.TabIndex = 1;
			removeButton.Text = "Remove";
			removeButton.UseVisualStyleBackColor = true;
			// 
			// printButton
			// 
			printButton.Location = new Point(12, 132);
			printButton.Name = "printButton";
			printButton.Size = new Size(100, 23);
			printButton.TabIndex = 2;
			printButton.Text = "Print";
			printButton.UseVisualStyleBackColor = true;
			printButton.Click += printButton_Click;
			// 
			// brandTextBox
			// 
			brandTextBox.Location = new Point(12, 12);
			brandTextBox.Name = "brandTextBox";
			brandTextBox.Size = new Size(100, 23);
			brandTextBox.TabIndex = 3;
			brandTextBox.Text = "Brand";
			brandTextBox.Enter += brandTextBox_Enter;
			// 
			// priceTextBox
			// 
			priceTextBox.Location = new Point(118, 12);
			priceTextBox.Name = "priceTextBox";
			priceTextBox.Size = new Size(100, 23);
			priceTextBox.TabIndex = 4;
			priceTextBox.Text = "Price";
			priceTextBox.Enter += priceTextBox_Enter;
			// 
			// paramTextBox
			// 
			paramTextBox.Location = new Point(224, 12);
			paramTextBox.Name = "paramTextBox";
			paramTextBox.Size = new Size(100, 23);
			paramTextBox.TabIndex = 5;
			paramTextBox.Text = "Temperture/Volume";
			paramTextBox.Enter += paramTextBox_Enter;
			// 
			// printTextBox
			// 
			printTextBox.Location = new Point(12, 172);
			printTextBox.Multiline = true;
			printTextBox.Name = "printTextBox";
			printTextBox.ReadOnly = true;
			printTextBox.Size = new Size(312, 175);
			printTextBox.TabIndex = 6;
			// 
			// addMicrowaveButton
			// 
			addMicrowaveButton.Location = new Point(118, 52);
			addMicrowaveButton.Name = "addMicrowaveButton";
			addMicrowaveButton.Size = new Size(100, 23);
			addMicrowaveButton.TabIndex = 7;
			addMicrowaveButton.Text = "Add Microwave";
			addMicrowaveButton.UseVisualStyleBackColor = true;
			addMicrowaveButton.Click += addMicrowaveButton_Click;
			// 
			// addFridgeButton
			// 
			addFridgeButton.Location = new Point(224, 52);
			addFridgeButton.Name = "addFridgeButton";
			addFridgeButton.Size = new Size(100, 23);
			addFridgeButton.TabIndex = 8;
			addFridgeButton.Text = "Add Fridge";
			addFridgeButton.UseVisualStyleBackColor = true;
			addFridgeButton.Click += addFridgeButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(addFridgeButton);
			Controls.Add(addMicrowaveButton);
			Controls.Add(printTextBox);
			Controls.Add(paramTextBox);
			Controls.Add(priceTextBox);
			Controls.Add(brandTextBox);
			Controls.Add(printButton);
			Controls.Add(removeButton);
			Controls.Add(addHomeApplianceButton);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button addHomeApplianceButton;
		private Button removeButton;
		private Button printButton;
		private TextBox brandTextBox;
		private TextBox priceTextBox;
		private TextBox paramTextBox;
		private TextBox printTextBox;
		private Button addMicrowaveButton;
		private Button addFridgeButton;
	}
}
