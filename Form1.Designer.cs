namespace TuringMachineEmulator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteCond = new System.Windows.Forms.Button();
            this.AddCond = new System.Windows.Forms.Button();
            this.Destroy = new System.Windows.Forms.Button();
            this.OneStep = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.AcceptAlphabet = new System.Windows.Forms.Button();
            this.ClearLine = new System.Windows.Forms.Button();
            this.AcceptWord = new System.Windows.Forms.Button();
            this.AlphabetBox = new System.Windows.Forms.TextBox();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AlphabetLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CondGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LineGrid = new System.Windows.Forms.DataGridView();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ItterationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CondGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineGrid)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteCond);
            this.groupBox1.Controls.Add(this.AddCond);
            this.groupBox1.Controls.Add(this.Destroy);
            this.groupBox1.Controls.Add(this.OneStep);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.AcceptAlphabet);
            this.groupBox1.Controls.Add(this.ClearLine);
            this.groupBox1.Controls.Add(this.AcceptWord);
            this.groupBox1.Controls.Add(this.AlphabetBox);
            this.groupBox1.Controls.Add(this.WordBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AlphabetLabel);
            this.groupBox1.Controls.Add(this.WordLabel);
            this.groupBox1.Location = new System.Drawing.Point(11, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные:";
            // 
            // DeleteCond
            // 
            this.DeleteCond.Enabled = false;
            this.DeleteCond.Location = new System.Drawing.Point(430, 79);
            this.DeleteCond.Name = "DeleteCond";
            this.DeleteCond.Size = new System.Drawing.Size(97, 23);
            this.DeleteCond.TabIndex = 12;
            this.DeleteCond.Text = "Удалить";
            this.DeleteCond.UseVisualStyleBackColor = true;
            this.DeleteCond.Click += new System.EventHandler(this.DeleteCond_Click);
            // 
            // AddCond
            // 
            this.AddCond.Enabled = false;
            this.AddCond.Location = new System.Drawing.Point(329, 79);
            this.AddCond.Name = "AddCond";
            this.AddCond.Size = new System.Drawing.Size(97, 23);
            this.AddCond.TabIndex = 11;
            this.AddCond.Text = "Добавить";
            this.AddCond.UseVisualStyleBackColor = true;
            this.AddCond.Click += new System.EventHandler(this.AddCond_Click);
            // 
            // Destroy
            // 
            this.Destroy.Enabled = false;
            this.Destroy.Location = new System.Drawing.Point(264, 79);
            this.Destroy.Name = "Destroy";
            this.Destroy.Size = new System.Drawing.Size(59, 23);
            this.Destroy.TabIndex = 10;
            this.Destroy.Text = "Сброс";
            this.Destroy.UseVisualStyleBackColor = true;
            this.Destroy.Click += new System.EventHandler(this.Destroy_Click);
            // 
            // OneStep
            // 
            this.OneStep.Enabled = false;
            this.OneStep.Location = new System.Drawing.Point(167, 79);
            this.OneStep.Name = "OneStep";
            this.OneStep.Size = new System.Drawing.Size(91, 23);
            this.OneStep.TabIndex = 9;
            this.OneStep.Text = "Сделать шаг";
            this.OneStep.UseVisualStyleBackColor = true;
            this.OneStep.Click += new System.EventHandler(this.OneStep_Click);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(86, 79);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 8;
            this.Start.Text = "Запустить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // AcceptAlphabet
            // 
            this.AcceptAlphabet.Location = new System.Drawing.Point(223, 48);
            this.AcceptAlphabet.Name = "AcceptAlphabet";
            this.AcceptAlphabet.Size = new System.Drawing.Size(304, 25);
            this.AcceptAlphabet.TabIndex = 7;
            this.AcceptAlphabet.Text = "Задать алфавит";
            this.AcceptAlphabet.UseVisualStyleBackColor = true;
            this.AcceptAlphabet.Click += new System.EventHandler(this.AcceptAlphabet_Click);
            // 
            // ClearLine
            // 
            this.ClearLine.Location = new System.Drawing.Point(406, 17);
            this.ClearLine.Name = "ClearLine";
            this.ClearLine.Size = new System.Drawing.Size(121, 25);
            this.ClearLine.TabIndex = 6;
            this.ClearLine.Text = "Очистить ленту";
            this.ClearLine.UseVisualStyleBackColor = true;
            this.ClearLine.Click += new System.EventHandler(this.ClearLine_Click);
            // 
            // AcceptWord
            // 
            this.AcceptWord.Enabled = false;
            this.AcceptWord.Location = new System.Drawing.Point(223, 17);
            this.AcceptWord.Name = "AcceptWord";
            this.AcceptWord.Size = new System.Drawing.Size(177, 25);
            this.AcceptWord.TabIndex = 5;
            this.AcceptWord.Text = "Поместить слово на ленту";
            this.AcceptWord.UseVisualStyleBackColor = true;
            this.AcceptWord.Click += new System.EventHandler(this.AcceptWord_Click);
            // 
            // AlphabetBox
            // 
            this.AlphabetBox.Location = new System.Drawing.Point(86, 48);
            this.AlphabetBox.Name = "AlphabetBox";
            this.AlphabetBox.Size = new System.Drawing.Size(131, 23);
            this.AlphabetBox.TabIndex = 4;
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(69, 19);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(148, 23);
            this.WordBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Машина:";
            // 
            // AlphabetLabel
            // 
            this.AlphabetLabel.AutoSize = true;
            this.AlphabetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlphabetLabel.Location = new System.Drawing.Point(6, 48);
            this.AlphabetLabel.Name = "AlphabetLabel";
            this.AlphabetLabel.Size = new System.Drawing.Size(74, 21);
            this.AlphabetLabel.TabIndex = 1;
            this.AlphabetLabel.Text = "Алфавит:";
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordLabel.Location = new System.Drawing.Point(6, 19);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(57, 21);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.Text = "Слово:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CondGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица состояний:";
            // 
            // CondGrid
            // 
            this.CondGrid.AllowUserToAddRows = false;
            this.CondGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CondGrid.Location = new System.Drawing.Point(6, 22);
            this.CondGrid.Name = "CondGrid";
            this.CondGrid.RowHeadersWidth = 62;
            this.CondGrid.RowTemplate.Height = 25;
            this.CondGrid.Size = new System.Drawing.Size(521, 287);
            this.CondGrid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LineGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Лента:";
            // 
            // LineGrid
            // 
            this.LineGrid.AllowUserToAddRows = false;
            this.LineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LineGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LineGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.LineGrid.Location = new System.Drawing.Point(6, 22);
            this.LineGrid.Name = "LineGrid";
            this.LineGrid.RowHeadersVisible = false;
            this.LineGrid.RowHeadersWidth = 25;
            this.LineGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LineGrid.RowTemplate.Height = 25;
            this.LineGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.LineGrid.Size = new System.Drawing.Size(521, 52);
            this.LineGrid.TabIndex = 0;
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItterationLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 540);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(560, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // ItterationLabel
            // 
            this.ItterationLabel.Name = "ItterationLabel";
            this.ItterationLabel.Size = new System.Drawing.Size(72, 17);
            this.ItterationLabel.Text = "Итерация: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 562);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Turing Machine Emulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CondGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineGrid)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button DeleteCond;
        private Button AddCond;
        private Button Destroy;
        private Button OneStep;
        private Button Start;
        private Button AcceptAlphabet;
        private Button ClearLine;
        private Button AcceptWord;
        private TextBox AlphabetBox;
        private TextBox WordBox;
        private Label label3;
        private Label AlphabetLabel;
        private Label WordLabel;
        private DataGridView CondGrid;
        private GroupBox groupBox3;
        private DataGridView LineGrid;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel ItterationLabel;
    }
}