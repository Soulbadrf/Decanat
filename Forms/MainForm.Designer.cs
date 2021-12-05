
namespace Decanat
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDiagrams = new System.Windows.Forms.Button();
            this.buttonDiagram = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonUpperStep = new System.Windows.Forms.Button();
            this.debtors = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.newLine = new System.Windows.Forms.Button();
            this.newDocument = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordBookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.performance = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.recordNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDiagrams);
            this.panel1.Controls.Add(this.buttonDiagram);
            this.panel1.Controls.Add(this.buttonGraph);
            this.panel1.Controls.Add(this.buttonUpperStep);
            this.panel1.Controls.Add(this.debtors);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 619);
            this.panel1.TabIndex = 0;
            // 
            // buttonDiagrams
            // 
            this.buttonDiagrams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagrams.Location = new System.Drawing.Point(12, 502);
            this.buttonDiagrams.Name = "buttonDiagrams";
            this.buttonDiagrams.Size = new System.Drawing.Size(174, 85);
            this.buttonDiagrams.TabIndex = 13;
            this.buttonDiagrams.Text = "Построить диаграмму";
            this.buttonDiagrams.UseVisualStyleBackColor = true;
            this.buttonDiagrams.Click += new System.EventHandler(this.buttonDiagrams_Click);
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagram.Location = new System.Drawing.Point(12, 401);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(174, 85);
            this.buttonDiagram.TabIndex = 12;
            this.buttonDiagram.Text = "Оценки по информатике";
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.buttonDiagram_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.Location = new System.Drawing.Point(12, 296);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(174, 85);
            this.buttonGraph.TabIndex = 11;
            this.buttonGraph.Text = "График среднего балла";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // buttonUpperStep
            // 
            this.buttonUpperStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpperStep.Location = new System.Drawing.Point(12, 194);
            this.buttonUpperStep.Name = "buttonUpperStep";
            this.buttonUpperStep.Size = new System.Drawing.Size(174, 85);
            this.buttonUpperStep.TabIndex = 10;
            this.buttonUpperStep.Text = "Повышенная стипендия";
            this.buttonUpperStep.UseVisualStyleBackColor = true;
            this.buttonUpperStep.Click += new System.EventHandler(this.buttonUpperStep_Click);
            // 
            // debtors
            // 
            this.debtors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debtors.Location = new System.Drawing.Point(12, 87);
            this.debtors.Name = "debtors";
            this.debtors.Size = new System.Drawing.Size(174, 85);
            this.debtors.TabIndex = 9;
            this.debtors.Text = "Должники";
            this.debtors.UseVisualStyleBackColor = true;
            this.debtors.Click += new System.EventHandler(this.debtors_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.menuLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 67);
            this.panel3.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(12, 9);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(182, 45);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Деканат";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.newLine);
            this.panel2.Controls.Add(this.newDocument);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(201, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 108);
            this.panel2.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(249, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Location = new System.Drawing.Point(112, 64);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(131, 32);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(112, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 32);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(780, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 23);
            this.labelId.TabIndex = 5;
            this.labelId.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(6, 64);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 32);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newLine
            // 
            this.newLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newLine.Location = new System.Drawing.Point(249, 8);
            this.newLine.Name = "newLine";
            this.newLine.Size = new System.Drawing.Size(122, 32);
            this.newLine.TabIndex = 3;
            this.newLine.Text = "Добавить";
            this.newLine.UseVisualStyleBackColor = true;
            this.newLine.Click += new System.EventHandler(this.newLine_Click);
            // 
            // newDocument
            // 
            this.newDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newDocument.Location = new System.Drawing.Point(6, 8);
            this.newDocument.Name = "newDocument";
            this.newDocument.Size = new System.Drawing.Size(100, 32);
            this.newDocument.TabIndex = 1;
            this.newDocument.Text = "Новый";
            this.newDocument.UseVisualStyleBackColor = true;
            this.newDocument.Click += new System.EventHandler(this.newDocument_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(780, 64);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToResizeColumns = false;
            this.dataGridViewStudents.AllowUserToResizeRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lastName,
            this.name,
            this.surName,
            this.recordBookNumber,
            this.specialization,
            this.performance});
            this.dataGridViewStudents.Location = new System.Drawing.Point(201, 0);
            this.dataGridViewStudents.Name = "dataGridView1";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(893, 513);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // surName
            // 
            this.surName.HeaderText = "Отчество";
            this.surName.MinimumWidth = 6;
            this.surName.Name = "surName";
            this.surName.Width = 150;
            // 
            // recordBookNumber
            // 
            this.recordBookNumber.HeaderText = "№ Зачетки";
            this.recordBookNumber.MinimumWidth = 6;
            this.recordBookNumber.Name = "recordBookNumber";
            this.recordBookNumber.Width = 150;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "Специальность";
            this.specialization.Items.AddRange(new object[] {
            "Программист",
            "Бухгалтер",
            "Повар"});
            this.specialization.MinimumWidth = 6;
            this.specialization.Name = "specialization";
            this.specialization.Width = 140;
            // 
            // performance
            // 
            this.performance.HeaderText = "Успеваемость";
            this.performance.MinimumWidth = 6;
            this.performance.Name = "performance";
            this.performance.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridViewValues.AllowUserToAddRows = false;
            this.dataGridViewValues.AllowUserToDeleteRows = false;
            this.dataGridViewValues.AllowUserToResizeColumns = false;
            this.dataGridViewValues.AllowUserToResizeRows = false;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordNumber,
            this.subject,
            this.session,
            this.year,
            this.value});
            this.dataGridViewValues.Location = new System.Drawing.Point(201, 0);
            this.dataGridViewValues.Name = "dataGridView2";
            this.dataGridViewValues.RowHeadersWidth = 51;
            this.dataGridViewValues.RowTemplate.Height = 24;
            this.dataGridViewValues.Size = new System.Drawing.Size(893, 513);
            this.dataGridViewValues.TabIndex = 3;
            this.dataGridViewValues.Visible = false;
            // 
            // recordNumber
            // 
            this.recordNumber.HeaderText = "id";
            this.recordNumber.MinimumWidth = 6;
            this.recordNumber.Name = "recordNumber";
            this.recordNumber.Visible = false;
            this.recordNumber.Width = 125;
            // 
            // subject
            // 
            this.subject.HeaderText = "Предмет";
            this.subject.Items.AddRange(new object[] {
            "Математика",
            "Информатика",
            "Русский",
            "Английский",
            "Философия"});
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.Width = 175;
            // 
            // session
            // 
            this.session.HeaderText = "Сессия";
            this.session.Items.AddRange(new object[] {
            "Летняя",
            "Зимняя"});
            this.session.MinimumWidth = 6;
            this.session.Name = "session";
            this.session.Width = 125;
            // 
            // year
            // 
            this.year.HeaderText = "Год";
            this.year.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Width = 125;
            // 
            // value
            // 
            this.value.HeaderText = "Оценка";
            this.value.Items.AddRange(new object[] {
            "Отсутсвует",
            "Удовлитворительно",
            "Хорошо",
            "Отлично",
            "Зачтено"});
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            this.value.Width = 200;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1093, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.dataGridViewValues);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Деканат";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button newDocument;
        private System.Windows.Forms.Button newLine;
        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelId;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surName;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordBookNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn specialization;
        private System.Windows.Forms.DataGridViewButtonColumn performance;
        private System.Windows.Forms.Button debtors;
        private System.Windows.Forms.Button buttonUpperStep;
        private System.Windows.Forms.Button buttonDiagram;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonDiagrams;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn subject;
        private System.Windows.Forms.DataGridViewComboBoxColumn session;
        private System.Windows.Forms.DataGridViewComboBoxColumn year;
        private System.Windows.Forms.DataGridViewComboBoxColumn value;
        private System.Windows.Forms.Button buttonDelete;
    }
}

