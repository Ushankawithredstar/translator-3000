namespace Translator_3000
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
            txt_gooseOutput = new TextBox();
            btn_translateHumanToGoose = new Button();
            txt_humanInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_gooseInput = new TextBox();
            txt_humanOutput = new TextBox();
            btn_translateGooseToHuman = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_gooseOutput
            // 
            txt_gooseOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_gooseOutput.Cursor = Cursors.IBeam;
            txt_gooseOutput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_gooseOutput.Location = new Point(12, 527);
            txt_gooseOutput.Multiline = true;
            txt_gooseOutput.Name = "txt_gooseOutput";
            txt_gooseOutput.PlaceholderText = "Вывод";
            txt_gooseOutput.ReadOnly = true;
            txt_gooseOutput.ScrollBars = ScrollBars.Vertical;
            txt_gooseOutput.Size = new Size(503, 118);
            txt_gooseOutput.TabIndex = 0;
            // 
            // btn_translateHumanToGoose
            // 
            btn_translateHumanToGoose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_translateHumanToGoose.AutoSize = true;
            btn_translateHumanToGoose.Cursor = Cursors.Hand;
            btn_translateHumanToGoose.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_translateHumanToGoose.Location = new Point(12, 478);
            btn_translateHumanToGoose.Name = "btn_translateHumanToGoose";
            btn_translateHumanToGoose.Size = new Size(155, 43);
            btn_translateHumanToGoose.TabIndex = 1;
            btn_translateHumanToGoose.Text = "Перевести";
            btn_translateHumanToGoose.UseVisualStyleBackColor = true;
            btn_translateHumanToGoose.Click += btn_translateHumanToGoose_Click;
            // 
            // txt_humanInput
            // 
            txt_humanInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_humanInput.Cursor = Cursors.IBeam;
            txt_humanInput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_humanInput.Location = new Point(12, 344);
            txt_humanInput.MaxLength = 255;
            txt_humanInput.Multiline = true;
            txt_humanInput.Name = "txt_humanInput";
            txt_humanInput.PlaceholderText = "Ввод";
            txt_humanInput.ScrollBars = ScrollBars.Vertical;
            txt_humanInput.Size = new Size(503, 118);
            txt_humanInput.TabIndex = 2;
            txt_humanInput.TextChanged += txt_humanInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(481, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 42);
            label1.TabIndex = 3;
            label1.Text = "Переводчик 3000";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1121, 667);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 4;
            label2.Text = "С любовью, для Заяча";
            // 
            // txt_gooseInput
            // 
            txt_gooseInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_gooseInput.Cursor = Cursors.IBeam;
            txt_gooseInput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_gooseInput.Location = new Point(749, 344);
            txt_gooseInput.Multiline = true;
            txt_gooseInput.Name = "txt_gooseInput";
            txt_gooseInput.PlaceholderText = "Ввод";
            txt_gooseInput.ScrollBars = ScrollBars.Vertical;
            txt_gooseInput.Size = new Size(503, 118);
            txt_gooseInput.TabIndex = 5;
            txt_gooseInput.TextChanged += txt_gooseInput_TextChanged;
            // 
            // txt_humanOutput
            // 
            txt_humanOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_humanOutput.Cursor = Cursors.IBeam;
            txt_humanOutput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_humanOutput.Location = new Point(749, 527);
            txt_humanOutput.Multiline = true;
            txt_humanOutput.Name = "txt_humanOutput";
            txt_humanOutput.PlaceholderText = "Вывод";
            txt_humanOutput.ReadOnly = true;
            txt_humanOutput.ScrollBars = ScrollBars.Vertical;
            txt_humanOutput.Size = new Size(503, 118);
            txt_humanOutput.TabIndex = 6;
            // 
            // btn_translateGooseToHuman
            // 
            btn_translateGooseToHuman.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_translateGooseToHuman.AutoSize = true;
            btn_translateGooseToHuman.Cursor = Cursors.Hand;
            btn_translateGooseToHuman.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_translateGooseToHuman.Location = new Point(749, 478);
            btn_translateGooseToHuman.Name = "btn_translateGooseToHuman";
            btn_translateGooseToHuman.Size = new Size(155, 43);
            btn_translateGooseToHuman.TabIndex = 7;
            btn_translateGooseToHuman.Text = "Перевести";
            btn_translateGooseToHuman.UseVisualStyleBackColor = true;
            btn_translateGooseToHuman.Click += btn_translateGooseToHuman_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 302);
            label3.Name = "label3";
            label3.Size = new Size(334, 32);
            label3.TabIndex = 8;
            label3.Text = "С человеческого на гусиный";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(749, 302);
            label4.Name = "label4";
            label4.Size = new Size(331, 32);
            label4.TabIndex = 9;
            label4.Text = "С гусиного на человеческий";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1264, 681);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_translateGooseToHuman);
            Controls.Add(txt_humanOutput);
            Controls.Add(txt_gooseInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_humanInput);
            Controls.Add(btn_translateHumanToGoose);
            Controls.Add(txt_gooseOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Переводчик 3000";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_gooseOutput;
        private Button btn_translateHumanToGoose;
        private TextBox txt_humanInput;
        private Label label1;
        private Label label2;
        private TextBox txt_gooseInput;
        private TextBox txt_humanOutput;
        private Button btn_translateGooseToHuman;
        private Label label3;
        private Label label4;
    }
}