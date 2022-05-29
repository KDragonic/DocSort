namespace DocSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listFile = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.button_reindexing = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.openInFolderButton = new System.Windows.Forms.Button();
            this.ReportAllButton = new System.Windows.Forms.Button();
            this.input_FastSearch = new System.Windows.Forms.TextBox();
            this.button_ExpandedOutput = new System.Windows.Forms.Button();
            this.ReportOutputButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переиндексацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьВыделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвертироватьВыделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьФилтрациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлВПапкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFile
            // 
            this.listFile.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listFile.FullRowSelect = true;
            this.listFile.HideSelection = false;
            this.listFile.Location = new System.Drawing.Point(0, 93);
            this.listFile.Margin = new System.Windows.Forms.Padding(2);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(1220, 400);
            this.listFile.TabIndex = 0;
            this.listFile.UseCompatibleStateImageBehavior = false;
            this.listFile.View = System.Windows.Forms.View.Details;
            this.listFile.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listFile_ColumnWidthChanged);
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(4, 25);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 64);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.editButton.Enabled = false;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(184, 25);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(176, 64);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // openButton
            // 
            this.openButton.AutoSize = true;
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(56)))));
            this.openButton.Enabled = false;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(365, 25);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(176, 64);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = true;
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.removeButton.Enabled = false;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(727, 25);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(176, 64);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // button_reindexing
            // 
            this.button_reindexing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reindexing.AutoSize = true;
            this.button_reindexing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button_reindexing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reindexing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reindexing.ForeColor = System.Drawing.Color.White;
            this.button_reindexing.Location = new System.Drawing.Point(0, 517);
            this.button_reindexing.Margin = new System.Windows.Forms.Padding(2);
            this.button_reindexing.Name = "button_reindexing";
            this.button_reindexing.Size = new System.Drawing.Size(997, 29);
            this.button_reindexing.TabIndex = 3;
            this.button_reindexing.Text = "Переиндексация файлов";
            this.button_reindexing.UseVisualStyleBackColor = false;
            this.button_reindexing.Click += new System.EventHandler(this.button_reindexing_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Location = new System.Drawing.Point(1148, 25);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(66, 64);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // openInFolderButton
            // 
            this.openInFolderButton.AutoSize = true;
            this.openInFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(222)))), ((int)(((byte)(164)))), ((int)(((byte)(113)))));
            this.openInFolderButton.Enabled = false;
            this.openInFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openInFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openInFolderButton.ForeColor = System.Drawing.Color.White;
            this.openInFolderButton.Location = new System.Drawing.Point(546, 25);
            this.openInFolderButton.Margin = new System.Windows.Forms.Padding(2);
            this.openInFolderButton.Name = "openInFolderButton";
            this.openInFolderButton.Size = new System.Drawing.Size(176, 64);
            this.openInFolderButton.TabIndex = 5;
            this.openInFolderButton.Text = "Открыть в папке";
            this.openInFolderButton.UseVisualStyleBackColor = false;
            this.openInFolderButton.Click += new System.EventHandler(this.openInFolderButton_Click);
            // 
            // ReportAllButton
            // 
            this.ReportAllButton.AutoSize = true;
            this.ReportAllButton.BackColor = System.Drawing.Color.Gray;
            this.ReportAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportAllButton.ForeColor = System.Drawing.Color.White;
            this.ReportAllButton.Location = new System.Drawing.Point(908, 27);
            this.ReportAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReportAllButton.Name = "ReportAllButton";
            this.ReportAllButton.Size = new System.Drawing.Size(236, 29);
            this.ReportAllButton.TabIndex = 6;
            this.ReportAllButton.Text = "Отчёт: все записи";
            this.ReportAllButton.UseVisualStyleBackColor = false;
            this.ReportAllButton.Click += new System.EventHandler(this.ReportAllButton_Click);
            // 
            // input_FastSearch
            // 
            this.input_FastSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_FastSearch.BackColor = System.Drawing.Color.White;
            this.input_FastSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_FastSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_FastSearch.Location = new System.Drawing.Point(0, 493);
            this.input_FastSearch.Margin = new System.Windows.Forms.Padding(0);
            this.input_FastSearch.Name = "input_FastSearch";
            this.input_FastSearch.Size = new System.Drawing.Size(997, 21);
            this.input_FastSearch.TabIndex = 7;
            this.input_FastSearch.TextChanged += new System.EventHandler(this.input_FastSearch_TextChanged);
            // 
            // button_ExpandedOutput
            // 
            this.button_ExpandedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExpandedOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.button_ExpandedOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExpandedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_ExpandedOutput.Location = new System.Drawing.Point(997, 492);
            this.button_ExpandedOutput.Margin = new System.Windows.Forms.Padding(0);
            this.button_ExpandedOutput.Name = "button_ExpandedOutput";
            this.button_ExpandedOutput.Size = new System.Drawing.Size(223, 54);
            this.button_ExpandedOutput.TabIndex = 8;
            this.button_ExpandedOutput.Text = "Раширеный вывод";
            this.button_ExpandedOutput.UseVisualStyleBackColor = false;
            this.button_ExpandedOutput.Click += new System.EventHandler(this.button_ExpandedOutput_Click);
            // 
            // ReportOutputButton
            // 
            this.ReportOutputButton.AutoSize = true;
            this.ReportOutputButton.BackColor = System.Drawing.Color.Gray;
            this.ReportOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportOutputButton.ForeColor = System.Drawing.Color.White;
            this.ReportOutputButton.Location = new System.Drawing.Point(908, 60);
            this.ReportOutputButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReportOutputButton.Name = "ReportOutputButton";
            this.ReportOutputButton.Size = new System.Drawing.Size(236, 29);
            this.ReportOutputButton.TabIndex = 6;
            this.ReportOutputButton.Text = "Отчёт: выведеные";
            this.ReportOutputButton.UseVisualStyleBackColor = false;
            this.ReportOutputButton.Click += new System.EventHandler(this.ReportOutputButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem,
            this.файлыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переиндексацияToolStripMenuItem,
            this.выделитьВсёToolStripMenuItem,
            this.убратьВыделенияToolStripMenuItem,
            this.инвертироватьВыделенияToolStripMenuItem,
            this.убратьФилтрациюToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // переиндексацияToolStripMenuItem
            // 
            this.переиндексацияToolStripMenuItem.Name = "переиндексацияToolStripMenuItem";
            this.переиндексацияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.переиндексацияToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.переиндексацияToolStripMenuItem.Text = "Переиндексация";
            this.переиндексацияToolStripMenuItem.Click += new System.EventHandler(this.переиндексацияToolStripMenuItem_Click);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // убратьВыделенияToolStripMenuItem
            // 
            this.убратьВыделенияToolStripMenuItem.Name = "убратьВыделенияToolStripMenuItem";
            this.убратьВыделенияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.убратьВыделенияToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.убратьВыделенияToolStripMenuItem.Text = "Убрать выделения";
            this.убратьВыделенияToolStripMenuItem.Click += new System.EventHandler(this.убратьВыделенияToolStripMenuItem_Click);
            // 
            // инвертироватьВыделенияToolStripMenuItem
            // 
            this.инвертироватьВыделенияToolStripMenuItem.Name = "инвертироватьВыделенияToolStripMenuItem";
            this.инвертироватьВыделенияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.инвертироватьВыделенияToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.инвертироватьВыделенияToolStripMenuItem.Text = "Инвертировать выделения";
            this.инвертироватьВыделенияToolStripMenuItem.Click += new System.EventHandler(this.инвертироватьВыделенияToolStripMenuItem_Click);
            // 
            // убратьФилтрациюToolStripMenuItem
            // 
            this.убратьФилтрациюToolStripMenuItem.Name = "убратьФилтрациюToolStripMenuItem";
            this.убратьФилтрациюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.убратьФилтрациюToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.убратьФилтрациюToolStripMenuItem.Text = "Убрать филтрацию";
            this.убратьФилтрациюToolStripMenuItem.Click += new System.EventHandler(this.убратьФилтрациюToolStripMenuItem_Click);
            // 
            // файлыToolStripMenuItem
            // 
            this.файлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФайлToolStripMenuItem,
            this.удалитьФайлToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.открытьФайлВПапкеToolStripMenuItem});
            this.файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            this.файлыToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлыToolStripMenuItem.Text = "Файлы";
            // 
            // добавитьФайлToolStripMenuItem
            // 
            this.добавитьФайлToolStripMenuItem.Name = "добавитьФайлToolStripMenuItem";
            this.добавитьФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.добавитьФайлToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.добавитьФайлToolStripMenuItem.Text = "Добавить файл";
            this.добавитьФайлToolStripMenuItem.Click += new System.EventHandler(this.добавитьФайлToolStripMenuItem_Click);
            // 
            // удалитьФайлToolStripMenuItem
            // 
            this.удалитьФайлToolStripMenuItem.Name = "удалитьФайлToolStripMenuItem";
            this.удалитьФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.удалитьФайлToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.удалитьФайлToolStripMenuItem.Text = "Удалить файл";
            this.удалитьФайлToolStripMenuItem.Click += new System.EventHandler(this.удалитьФайлToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // открытьФайлВПапкеToolStripMenuItem
            // 
            this.открытьФайлВПапкеToolStripMenuItem.Name = "открытьФайлВПапкеToolStripMenuItem";
            this.открытьФайлВПапкеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.открытьФайлВПапкеToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.открытьФайлВПапкеToolStripMenuItem.Text = "Открыть файл в папке";
            this.открытьФайлВПапкеToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлВПапкеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1220, 546);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_ExpandedOutput);
            this.Controls.Add(this.input_FastSearch);
            this.Controls.Add(this.ReportOutputButton);
            this.Controls.Add(this.ReportAllButton);
            this.Controls.Add(this.openInFolderButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.button_reindexing);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listFile);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "SortDoc";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listFile;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button button_reindexing;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button openInFolderButton;
        private System.Windows.Forms.Button ReportAllButton;
        private System.Windows.Forms.TextBox input_FastSearch;
        private System.Windows.Forms.Button button_ExpandedOutput;
        private System.Windows.Forms.Button ReportOutputButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переиндексацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убратьВыделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инвертироватьВыделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убратьФилтрациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлВПапкеToolStripMenuItem;
    }
}

