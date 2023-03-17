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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            DeleteCond = new Button();
            AddCond = new Button();
            Destroy = new Button();
            OneStep = new Button();
            Start = new Button();
            AcceptAlphabet = new Button();
            ClearLine = new Button();
            AcceptWord = new Button();
            AlphabetBox = new TextBox();
            WordBox = new TextBox();
            label3 = new Label();
            AlphabetLabel = new Label();
            WordLabel = new Label();
            groupBox2 = new GroupBox();
            CondGrid = new DataGridView();
            groupBox3 = new GroupBox();
            LineGrid = new DataGridView();
            StatusBar = new StatusStrip();
            ItterationLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CondGrid).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LineGrid).BeginInit();
            StatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DeleteCond);
            groupBox1.Controls.Add(AddCond);
            groupBox1.Controls.Add(Destroy);
            groupBox1.Controls.Add(OneStep);
            groupBox1.Controls.Add(Start);
            groupBox1.Controls.Add(AcceptAlphabet);
            groupBox1.Controls.Add(ClearLine);
            groupBox1.Controls.Add(AcceptWord);
            groupBox1.Controls.Add(AlphabetBox);
            groupBox1.Controls.Add(WordBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(AlphabetLabel);
            groupBox1.Controls.Add(WordLabel);
            groupBox1.Location = new Point(16, 167);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(767, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные:";
            // 
            // DeleteCond
            // 
            DeleteCond.Enabled = false;
            DeleteCond.Location = new Point(614, 132);
            DeleteCond.Margin = new Padding(4, 5, 4, 5);
            DeleteCond.Name = "DeleteCond";
            DeleteCond.Size = new Size(139, 38);
            DeleteCond.TabIndex = 12;
            DeleteCond.Text = "Удалить";
            DeleteCond.UseVisualStyleBackColor = true;
            DeleteCond.Click += DeleteCond_Click;
            // 
            // AddCond
            // 
            AddCond.Enabled = false;
            AddCond.Location = new Point(470, 132);
            AddCond.Margin = new Padding(4, 5, 4, 5);
            AddCond.Name = "AddCond";
            AddCond.Size = new Size(139, 38);
            AddCond.TabIndex = 11;
            AddCond.Text = "Добавить";
            AddCond.UseVisualStyleBackColor = true;
            AddCond.Click += AddCond_Click;
            // 
            // Destroy
            // 
            Destroy.Enabled = false;
            Destroy.Location = new Point(377, 132);
            Destroy.Margin = new Padding(4, 5, 4, 5);
            Destroy.Name = "Destroy";
            Destroy.Size = new Size(84, 38);
            Destroy.TabIndex = 10;
            Destroy.Text = "Сброс";
            Destroy.UseVisualStyleBackColor = true;
            Destroy.Click += Destroy_Click;
            // 
            // OneStep
            // 
            OneStep.Enabled = false;
            OneStep.Location = new Point(239, 132);
            OneStep.Margin = new Padding(4, 5, 4, 5);
            OneStep.Name = "OneStep";
            OneStep.Size = new Size(130, 38);
            OneStep.TabIndex = 9;
            OneStep.Text = "Сделать шаг";
            OneStep.UseVisualStyleBackColor = true;
            OneStep.Click += OneStep_Click;
            // 
            // Start
            // 
            Start.Enabled = false;
            Start.Location = new Point(123, 132);
            Start.Margin = new Padding(4, 5, 4, 5);
            Start.Name = "Start";
            Start.Size = new Size(107, 38);
            Start.TabIndex = 8;
            Start.Text = "Запустить";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // AcceptAlphabet
            // 
            AcceptAlphabet.Location = new Point(319, 80);
            AcceptAlphabet.Margin = new Padding(4, 5, 4, 5);
            AcceptAlphabet.Name = "AcceptAlphabet";
            AcceptAlphabet.Size = new Size(434, 42);
            AcceptAlphabet.TabIndex = 7;
            AcceptAlphabet.Text = "Задать алфавит";
            AcceptAlphabet.UseVisualStyleBackColor = true;
            AcceptAlphabet.Click += AcceptAlphabet_Click;
            // 
            // ClearLine
            // 
            ClearLine.Location = new Point(580, 28);
            ClearLine.Margin = new Padding(4, 5, 4, 5);
            ClearLine.Name = "ClearLine";
            ClearLine.Size = new Size(173, 42);
            ClearLine.TabIndex = 6;
            ClearLine.Text = "Очистить ленту";
            ClearLine.UseVisualStyleBackColor = true;
            ClearLine.Click += ClearLine_Click;
            // 
            // AcceptWord
            // 
            AcceptWord.Enabled = false;
            AcceptWord.Location = new Point(319, 28);
            AcceptWord.Margin = new Padding(4, 5, 4, 5);
            AcceptWord.Name = "AcceptWord";
            AcceptWord.Size = new Size(253, 42);
            AcceptWord.TabIndex = 5;
            AcceptWord.Text = "Поместить слово на ленту";
            AcceptWord.UseVisualStyleBackColor = true;
            AcceptWord.Click += AcceptWord_Click;
            // 
            // AlphabetBox
            // 
            AlphabetBox.Location = new Point(123, 80);
            AlphabetBox.Margin = new Padding(4, 5, 4, 5);
            AlphabetBox.Name = "AlphabetBox";
            AlphabetBox.Size = new Size(185, 31);
            AlphabetBox.TabIndex = 4;
            AlphabetBox.Text = "fa";
            // 
            // WordBox
            // 
            WordBox.Location = new Point(99, 32);
            WordBox.Margin = new Padding(4, 5, 4, 5);
            WordBox.Name = "WordBox";
            WordBox.Size = new Size(210, 31);
            WordBox.TabIndex = 3;
            WordBox.Text = "fafaf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 2;
            label3.Text = "Машина:";
            // 
            // AlphabetLabel
            // 
            AlphabetLabel.AutoSize = true;
            AlphabetLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AlphabetLabel.Location = new Point(9, 80);
            AlphabetLabel.Margin = new Padding(4, 0, 4, 0);
            AlphabetLabel.Name = "AlphabetLabel";
            AlphabetLabel.Size = new Size(112, 32);
            AlphabetLabel.TabIndex = 1;
            AlphabetLabel.Text = "Алфавит:";
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WordLabel.Location = new Point(9, 32);
            WordLabel.Margin = new Padding(4, 0, 4, 0);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(88, 32);
            WordLabel.TabIndex = 0;
            WordLabel.Text = "Слово:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CondGrid);
            groupBox2.Location = new Point(17, 365);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(767, 525);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Таблица состояний:";
            // 
            // CondGrid
            // 
            CondGrid.AllowUserToAddRows = false;
            CondGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CondGrid.Location = new Point(9, 37);
            CondGrid.Margin = new Padding(4, 5, 4, 5);
            CondGrid.Name = "CondGrid";
            CondGrid.RowHeadersWidth = 62;
            CondGrid.RowTemplate.Height = 25;
            CondGrid.Size = new Size(744, 478);
            CondGrid.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LineGrid);
            groupBox3.Location = new Point(17, 20);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(767, 137);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Лента:";
            // 
            // LineGrid
            // 
            LineGrid.AllowUserToAddRows = false;
            LineGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LineGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            LineGrid.DefaultCellStyle = dataGridViewCellStyle1;
            LineGrid.Location = new Point(9, 37);
            LineGrid.Margin = new Padding(4, 5, 4, 5);
            LineGrid.Name = "LineGrid";
            LineGrid.RowHeadersVisible = false;
            LineGrid.RowHeadersWidth = 25;
            LineGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            LineGrid.RowTemplate.Height = 25;
            LineGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            LineGrid.Size = new Size(744, 87);
            LineGrid.TabIndex = 0;
            // 
            // StatusBar
            // 
            StatusBar.ImageScalingSize = new Size(24, 24);
            StatusBar.Items.AddRange(new ToolStripItem[] { ItterationLabel });
            StatusBar.Location = new Point(0, 905);
            StatusBar.Name = "StatusBar";
            StatusBar.Padding = new Padding(1, 0, 20, 0);
            StatusBar.Size = new Size(800, 32);
            StatusBar.TabIndex = 3;
            StatusBar.Text = "statusStrip1";
            // 
            // ItterationLabel
            // 
            ItterationLabel.Name = "ItterationLabel";
            ItterationLabel.Size = new Size(110, 25);
            ItterationLabel.Text = "Итерация: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 937);
            Controls.Add(StatusBar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Turing Machine Emulator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CondGrid).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LineGrid).EndInit();
            StatusBar.ResumeLayout(false);
            StatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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