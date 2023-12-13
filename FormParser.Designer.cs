namespace SergeyParcesr {
    partial class FormParser {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            NameGetParserFile = new Label();
            ParsingFile = new TextBox();
            GetParserFile = new Button();
            LabelTextOutput = new Label();
            RichTextOutput = new RichTextBox();
            ReadParserFile = new Button();
            LabelFilterSenderName = new Label();
            LabelFilterReceiverName = new Label();
            LabelFilterAttributeName = new Label();
            LabelFilterCodeName = new Label();
            StopButton = new Button();
            ClearButton = new Button();
            LabelFilterName = new Label();
            OutputDataGrid = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            CD = new DataGridViewTextBoxColumn();
            Sender = new DataGridViewTextBoxColumn();
            Receiver = new DataGridViewTextBoxColumn();
            Attribute = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            FilterButton = new Button();
            FilterComBoxSenderName = new ComboBox();
            FilterComBoxReceiverName = new ComboBox();
            FilterComBoxAttributeName = new ComboBox();
            FilterComBoxCodeName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)OutputDataGrid).BeginInit();
            SuspendLayout();
            // 
            // NameGetParserFile
            // 
            NameGetParserFile.AutoSize = true;
            NameGetParserFile.Location = new Point(12, 9);
            NameGetParserFile.Name = "NameGetParserFile";
            NameGetParserFile.Size = new Size(173, 15);
            NameGetParserFile.TabIndex = 0;
            NameGetParserFile.Text = "Название файла для парсинга";
            // 
            // ParsingFile
            // 
            ParsingFile.Location = new Point(12, 27);
            ParsingFile.Name = "ParsingFile";
            ParsingFile.ReadOnly = true;
            ParsingFile.Size = new Size(173, 23);
            ParsingFile.TabIndex = 1;
            // 
            // GetParserFile
            // 
            GetParserFile.Location = new Point(12, 56);
            GetParserFile.Name = "GetParserFile";
            GetParserFile.Size = new Size(173, 39);
            GetParserFile.TabIndex = 2;
            GetParserFile.Text = "Получить файл для парсинга";
            GetParserFile.UseVisualStyleBackColor = true;
            GetParserFile.Click += GetParserFile_Click;
            // 
            // LabelTextOutput
            // 
            LabelTextOutput.AutoSize = true;
            LabelTextOutput.Location = new Point(12, 128);
            LabelTextOutput.Name = "LabelTextOutput";
            LabelTextOutput.Size = new Size(79, 15);
            LabelTextOutput.TabIndex = 4;
            LabelTextOutput.Text = "Вывод текста";
            // 
            // RichTextOutput
            // 
            RichTextOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RichTextOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RichTextOutput.Location = new Point(12, 146);
            RichTextOutput.Name = "RichTextOutput";
            RichTextOutput.Size = new Size(1073, 63);
            RichTextOutput.TabIndex = 5;
            RichTextOutput.Text = "";
            // 
            // ReadParserFile
            // 
            ReadParserFile.Enabled = false;
            ReadParserFile.Location = new Point(12, 101);
            ReadParserFile.Name = "ReadParserFile";
            ReadParserFile.Size = new Size(173, 24);
            ReadParserFile.TabIndex = 6;
            ReadParserFile.Text = "Прочитать файл";
            ReadParserFile.UseVisualStyleBackColor = true;
            ReadParserFile.Click += ReadParserFile_Click;
            // 
            // LabelFilterSenderName
            // 
            LabelFilterSenderName.AutoSize = true;
            LabelFilterSenderName.Location = new Point(241, 99);
            LabelFilterSenderName.Name = "LabelFilterSenderName";
            LabelFilterSenderName.Size = new Size(78, 15);
            LabelFilterSenderName.TabIndex = 9;
            LabelFilterSenderName.Text = "Отправитель";
            // 
            // LabelFilterReceiverName
            // 
            LabelFilterReceiverName.AutoSize = true;
            LabelFilterReceiverName.Location = new Point(325, 99);
            LabelFilterReceiverName.Name = "LabelFilterReceiverName";
            LabelFilterReceiverName.Size = new Size(83, 15);
            LabelFilterReceiverName.TabIndex = 11;
            LabelFilterReceiverName.Text = "Приниматель";
            // 
            // LabelFilterAttributeName
            // 
            LabelFilterAttributeName.AutoSize = true;
            LabelFilterAttributeName.Location = new Point(414, 99);
            LabelFilterAttributeName.Name = "LabelFilterAttributeName";
            LabelFilterAttributeName.Size = new Size(57, 15);
            LabelFilterAttributeName.TabIndex = 13;
            LabelFilterAttributeName.Text = "Аттрибут";
            // 
            // LabelFilterCodeName
            // 
            LabelFilterCodeName.AutoSize = true;
            LabelFilterCodeName.Location = new Point(505, 98);
            LabelFilterCodeName.Name = "LabelFilterCodeName";
            LabelFilterCodeName.Size = new Size(27, 15);
            LabelFilterCodeName.TabIndex = 15;
            LabelFilterCodeName.Text = "Код";
            // 
            // StopButton
            // 
            StopButton.Location = new Point(191, 101);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(44, 23);
            StopButton.TabIndex = 17;
            StopButton.Text = "STOP";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearButton.Location = new Point(1035, 117);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(50, 23);
            ClearButton.TabIndex = 18;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // LabelFilterName
            // 
            LabelFilterName.AutoSize = true;
            LabelFilterName.Location = new Point(348, 80);
            LabelFilterName.Name = "LabelFilterName";
            LabelFilterName.Size = new Size(91, 15);
            LabelFilterName.TabIndex = 19;
            LabelFilterName.Text = "Фильтрация по";
            // 
            // OutputDataGrid
            // 
            OutputDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputDataGrid.Columns.AddRange(new DataGridViewColumn[] { Number, Type, CD, Sender, Receiver, Attribute, Code, Data });
            OutputDataGrid.Location = new Point(12, 215);
            OutputDataGrid.Name = "OutputDataGrid";
            OutputDataGrid.RowTemplate.Height = 25;
            OutputDataGrid.Size = new Size(1073, 429);
            OutputDataGrid.TabIndex = 20;
            // 
            // Number
            // 
            Number.HeaderText = "Номер";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // CD
            // 
            CD.HeaderText = "C/D";
            CD.Name = "CD";
            CD.ReadOnly = true;
            // 
            // Sender
            // 
            Sender.HeaderText = "Отправитель";
            Sender.Name = "Sender";
            Sender.ReadOnly = true;
            // 
            // Receiver
            // 
            Receiver.HeaderText = "Приниматель";
            Receiver.Name = "Receiver";
            Receiver.ReadOnly = true;
            // 
            // Attribute
            // 
            Attribute.HeaderText = "Аттрибут";
            Attribute.Name = "Attribute";
            Attribute.ReadOnly = true;
            // 
            // Code
            // 
            Code.HeaderText = "Код";
            Code.Name = "Code";
            Code.ReadOnly = true;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data.HeaderText = "Данные";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // FilterButton
            // 
            FilterButton.Enabled = false;
            FilterButton.Location = new Point(445, 72);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(44, 23);
            FilterButton.TabIndex = 21;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // FilterComBoxSenderName
            // 
            FilterComBoxSenderName.Enabled = false;
            FilterComBoxSenderName.FormattingEnabled = true;
            FilterComBoxSenderName.Location = new Point(241, 117);
            FilterComBoxSenderName.Name = "FilterComBoxSenderName";
            FilterComBoxSenderName.Size = new Size(78, 23);
            FilterComBoxSenderName.TabIndex = 22;
            // 
            // FilterComBoxReceiverName
            // 
            FilterComBoxReceiverName.Enabled = false;
            FilterComBoxReceiverName.FormattingEnabled = true;
            FilterComBoxReceiverName.Location = new Point(325, 117);
            FilterComBoxReceiverName.Name = "FilterComBoxReceiverName";
            FilterComBoxReceiverName.Size = new Size(83, 23);
            FilterComBoxReceiverName.TabIndex = 23;
            // 
            // FilterComBoxAttributeName
            // 
            FilterComBoxAttributeName.Enabled = false;
            FilterComBoxAttributeName.FormattingEnabled = true;
            FilterComBoxAttributeName.Location = new Point(414, 117);
            FilterComBoxAttributeName.Name = "FilterComBoxAttributeName";
            FilterComBoxAttributeName.Size = new Size(85, 23);
            FilterComBoxAttributeName.TabIndex = 24;
            // 
            // FilterComBoxCodeName
            // 
            FilterComBoxCodeName.Enabled = false;
            FilterComBoxCodeName.FormattingEnabled = true;
            FilterComBoxCodeName.Location = new Point(505, 117);
            FilterComBoxCodeName.Name = "FilterComBoxCodeName";
            FilterComBoxCodeName.Size = new Size(65, 23);
            FilterComBoxCodeName.TabIndex = 25;
            // 
            // FormParser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 656);
            Controls.Add(FilterComBoxCodeName);
            Controls.Add(FilterComBoxAttributeName);
            Controls.Add(FilterComBoxReceiverName);
            Controls.Add(FilterComBoxSenderName);
            Controls.Add(FilterButton);
            Controls.Add(OutputDataGrid);
            Controls.Add(LabelFilterName);
            Controls.Add(ClearButton);
            Controls.Add(StopButton);
            Controls.Add(LabelFilterCodeName);
            Controls.Add(LabelFilterAttributeName);
            Controls.Add(LabelFilterReceiverName);
            Controls.Add(LabelFilterSenderName);
            Controls.Add(ReadParserFile);
            Controls.Add(RichTextOutput);
            Controls.Add(LabelTextOutput);
            Controls.Add(GetParserFile);
            Controls.Add(ParsingFile);
            Controls.Add(NameGetParserFile);
            Name = "FormParser";
            Text = "Parser";
            ((System.ComponentModel.ISupportInitialize)OutputDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameGetParserFile;
        private TextBox ParsingFile;
        private Button GetParserFile;
        private Label LabelTextOutput;
        private RichTextBox RichTextOutput;
        private Button ReadParserFile;
        private Label LabelFilterSenderName;
        private Label LabelFilterReceiverName;
        private Label LabelFilterAttributeName;
        private Label LabelFilterCodeName;
        private Button StopButton;
        private Button ClearButton;
        private Label LabelFilterName;
        private DataGridView OutputDataGrid;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn CD;
        private DataGridViewTextBoxColumn Sender;
        private DataGridViewTextBoxColumn Receiver;
        private DataGridViewTextBoxColumn Attribute;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Data;
        private Button FilterButton;
        private ComboBox FilterComBoxSenderName;
        private ComboBox FilterComBoxReceiverName;
        private ComboBox FilterComBoxAttributeName;
        private ComboBox FilterComBoxCodeName;
    }
}