namespace TuringMachineEmulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //��������� ���������� ������� ��������� ����� ������
        public string placeholder = "^";
        public int QuantityOfLineCells = 50; //���-�� ������ �� �����
        private void Form1_Load(object sender, EventArgs e)
        {
            LineGrid.RowCount = 1;
            for (int i = 0; i < QuantityOfLineCells; i++)
            {
                LineGrid.Columns.Add(placeholder, i.ToString());
                LineGrid.Rows[0].Cells[i].Value = placeholder;

                LineGrid.Columns[i].Width = 30;
            }
        }


        //���� ��������
        public string alphabet = "";
        private void AcceptAlphabet_Click(object sender, EventArgs e)
        {
            if (AlphabetBox.Text != "")
            {
                alphabet = AlphabetBox.Text;
                MessageBox.Show("������� ������� �����", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //��� ��������� ���������� ��������� � ������ ������� ����� �������� �������� �������� (���?)
                CondGrid.RowCount = 1;
                CondGrid.Columns.Clear();
                CondGrid.Columns.Add(placeholder, "Q");
                for (int i = 0; i < alphabet.Length; i++)
                {
                    CondGrid.Columns.Add(placeholder, alphabet[i].ToString());

                    CondGrid.Columns[i].Width = 40;
                }
                CondGrid.Columns.Add(placeholder, "^");
            }
            else MessageBox.Show("������ �������!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            AcceptWord.Enabled = true;
            DeleteCond.Enabled = true;
            AddCond.Enabled = true;
            Destroy.Enabled = true;
            OneStep.Enabled = true;
            Start.Enabled = true;
        }


        //������� ����� ������
        private void ClearLine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < QuantityOfLineCells; i++)
            {
                LineGrid.Rows[0].Cells[i].Value = placeholder;
                LineGrid.Columns[i].Width = 30;
            }
        }


        //���� �����
        public string word = "";
        private void AcceptWord_Click(object sender, EventArgs e)
        {
            if (alphabet != "")
            {
                if (WordBox.Text != "")
                {
                    word = WordBox.Text;

                    int g = 0;
                    for (int i = 1; i < word.Length + 1; i++)
                    {
                        LineGrid.Rows[0].Cells[i].Value = word[g];
                        g++;
                        LineGrid.Columns[i].Width = 30;
                    }
                }
                else MessageBox.Show("������ �����!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("������ �������!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int RowCounter = 0;
        private void AddCond_Click(object sender, EventArgs e)
        {
            CondGrid.RowCount += 1;
            CondGrid.Rows[RowCounter].Cells[0].Value = "Q" + RowCounter.ToString();
            RowCounter++;
        }

        private void DeleteCond_Click(object sender, EventArgs e)
        {
            if (RowCounter == 0) MessageBox.Show("������� ��������� �����!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CondGrid.RowCount -= 1;
                RowCounter--;
            }
        }


        public int ItterationCounter = 0;
        public string CurrentCondition = "";
        public string StartPosition = "Q0";
        private void Destroy_Click(object sender, EventArgs e)
        {
            CondGrid.Rows.Clear();
            RowCounter = 0;
            ItterationCounter = 0;
            StatusBar.Items[0].Text = "��������: 0";
            CurrentCondition = "";
            StartPosition = "Q0";
            OneStep.Enabled = true;
            Start.Enabled = true;
        }

        public string CommandDirection;
        private void OneStep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CondGrid.Rows.Count; i++)
                for (int j = 0; j < CondGrid.Columns.Count; j++)
                    CondGrid.Rows[i].Cells[j].Style.BackColor = Color.White;

            ItterationCounter++;
            StatusBar.Items[0].Text = "��������: " + ItterationCounter.ToString();

            if (CurrentCondition == "") CurrentCondition = StartPosition;

            int CommandRememberX = 0;
            int CommandRememberY = 0;
            for (int i = 0; i < CondGrid.Rows.Count; i++) if (CurrentCondition == CondGrid.Rows[i].Cells[0].Value.ToString()) CommandRememberY = i; //������� ��������� Q
            string CurrentChar = LineGrid.CurrentCell.Value.ToString();
            for (int j = 0; j < CondGrid.Columns.Count; j++) if (CurrentChar == CondGrid.Columns[j].HeaderText) CommandRememberX = j; //����������� ������
            //���� ����������� � ������������ ������������ ������ �� ������� ���������. ��������� ����������� ��������� � ���������� ��� ��� Y, � ����������� �� ����� ������ 
            //������ ��� X, ��������� ���� ����� ���������� ���������� ��������� ����������� ������-�������

            //LineGrid.Rows[0].Cells[LineGrid.CurrentCell.ColumnIndex].Value = CommandRememberX.ToString(); //������� �������, �� �������!!1!


            string CurrentCommand = CondGrid.Rows[CommandRememberY].Cells[CommandRememberX].Value.ToString();
            if (CurrentCommand != "" && CurrentCommand.Length == 4)
            {
                CondGrid.Rows[CommandRememberY].Cells[CommandRememberX].Style.BackColor = Color.Lime; //������� ��������� ������������ � Lime

                string CommandInsertChar = CurrentCommand[0].ToString();
                CommandDirection = CurrentCommand[1].ToString();
                CurrentCondition = CurrentCommand[2].ToString() + CurrentCommand[3].ToString();
                if (CurrentCondition != "!!")
                {
                    LineGrid.CurrentCell.Value = CommandInsertChar; //������� �������
                    if (CommandDirection == "R") LineGrid.CurrentCell = LineGrid.Rows[0].Cells[LineGrid.CurrentCell.ColumnIndex + 1]; //����� �������
                    if (CommandDirection == "L") LineGrid.CurrentCell = LineGrid.Rows[0].Cells[LineGrid.CurrentCell.ColumnIndex - 1];
                    if (CommandDirection == "S") LineGrid.CurrentCell = LineGrid.Rows[0].Cells[LineGrid.CurrentCell.ColumnIndex];
                }
                else
                {
                    LineGrid.CurrentCell.Value = CommandInsertChar;
                    LineGrid.CurrentCell = LineGrid.Rows[0].Cells[LineGrid.CurrentCell.ColumnIndex];
                    OneStep.Enabled = false;
                    Start.Enabled = false;
                    MessageBox.Show("������������ ���������!", "��������� ����������", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else MessageBox.Show("�������� ��������� ������!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            while (CurrentCondition != "!!")
            {
                OneStep_Click(sender, e);
                Task.Delay(10000);
            }
        }
    }
}