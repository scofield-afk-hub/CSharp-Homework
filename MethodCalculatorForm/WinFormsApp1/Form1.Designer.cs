namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnMax = new Button();
            btnPower = new Button();
            btnIsPrime = new Button();
            btnFactorial = new Button();
            lblHint = new Label();
            lblResult = new Label();
            SuspendLayout();

            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(24, 27);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Text = "First number:";

            txtNumber1.Location = new Point(145, 24);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(250, 23);
            txtNumber1.TabIndex = 0;

            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(24, 67);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Text = "Second number:";

            txtNumber2.Location = new Point(145, 64);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(250, 23);
            txtNumber2.TabIndex = 1;

            btnMax.Location = new Point(24, 110);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(85, 35);
            btnMax.TabIndex = 2;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;

            btnPower.Location = new Point(119, 110);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(85, 35);
            btnPower.TabIndex = 3;
            btnPower.Text = "Power";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;

            btnIsPrime.Location = new Point(214, 110);
            btnIsPrime.Name = "btnIsPrime";
            btnIsPrime.Size = new Size(85, 35);
            btnIsPrime.TabIndex = 4;
            btnIsPrime.Text = "IsPrime";
            btnIsPrime.UseVisualStyleBackColor = true;
            btnIsPrime.Click += btnIsPrime_Click;

            btnFactorial.Location = new Point(309, 110);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(86, 35);
            btnFactorial.TabIndex = 5;
            btnFactorial.Text = "Factorial";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += btnFactorial_Click;

            lblHint.Location = new Point(24, 160);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(371, 40);
            lblHint.Text = "IsPrime and Factorial use the first number only.\nFactorial accepts whole numbers from 0 to 20.";

            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(24, 215);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(371, 65);
            lblResult.Text = "Result:";
            lblResult.TextAlign = ContentAlignment.MiddleLeft;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 305);
            Controls.Add(lblNumber1);
            Controls.Add(txtNumber1);
            Controls.Add(lblNumber2);
            Controls.Add(txtNumber2);
            Controls.Add(btnMax);
            Controls.Add(btnPower);
            Controls.Add(btnIsPrime);
            Controls.Add(btnFactorial);
            Controls.Add(lblHint);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Method Calculator Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnMax;
        private Button btnPower;
        private Button btnIsPrime;
        private Button btnFactorial;
        private Label lblHint;
        private Label lblResult;
    }
}

