﻿namespace DocSort
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listFile = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.button_reindexing = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openInFolderButton = new System.Windows.Forms.Button();
            this.ReportAllButton = new System.Windows.Forms.Button();
            this.input_FastSearch = new System.Windows.Forms.TextBox();
            this.button_ExpandedOutput = new System.Windows.Forms.Button();
            this.ReportOutputButton = new System.Windows.Forms.Button();
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
            this.listFile.Location = new System.Drawing.Point(0, 92);
            this.listFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(1612, 513);
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
            this.addButton.Location = new System.Drawing.Point(5, 9);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(235, 79);
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
            this.editButton.Location = new System.Drawing.Point(246, 9);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(235, 79);
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
            this.openButton.Location = new System.Drawing.Point(487, 9);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(235, 79);
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
            this.removeButton.Location = new System.Drawing.Point(969, 9);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(235, 79);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // button_reindexing
            // 
            this.button_reindexing.AutoSize = true;
            this.button_reindexing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button_reindexing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_reindexing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reindexing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reindexing.ForeColor = System.Drawing.Color.White;
            this.button_reindexing.Location = new System.Drawing.Point(0, 639);
            this.button_reindexing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reindexing.Name = "button_reindexing";
            this.button_reindexing.Size = new System.Drawing.Size(1611, 33);
            this.button_reindexing.TabIndex = 3;
            this.button_reindexing.Text = "Переиндексация файлов";
            this.button_reindexing.UseVisualStyleBackColor = false;
            this.button_reindexing.Click += new System.EventHandler(this.button_reindexing_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1530, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 79);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openInFolderButton
            // 
            this.openInFolderButton.AutoSize = true;
            this.openInFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(222)))), ((int)(((byte)(164)))), ((int)(((byte)(113)))));
            this.openInFolderButton.Enabled = false;
            this.openInFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openInFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openInFolderButton.ForeColor = System.Drawing.Color.White;
            this.openInFolderButton.Location = new System.Drawing.Point(728, 9);
            this.openInFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openInFolderButton.Name = "openInFolderButton";
            this.openInFolderButton.Size = new System.Drawing.Size(235, 79);
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
            this.ReportAllButton.Location = new System.Drawing.Point(1210, 11);
            this.ReportAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportAllButton.Name = "ReportAllButton";
            this.ReportAllButton.Size = new System.Drawing.Size(314, 36);
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
            this.input_FastSearch.Location = new System.Drawing.Point(0, 607);
            this.input_FastSearch.Margin = new System.Windows.Forms.Padding(0);
            this.input_FastSearch.Name = "input_FastSearch";
            this.input_FastSearch.Size = new System.Drawing.Size(1243, 27);
            this.input_FastSearch.TabIndex = 7;
            this.input_FastSearch.TextChanged += new System.EventHandler(this.input_FastSearch_TextChanged);
            // 
            // button_ExpandedOutput
            // 
            this.button_ExpandedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExpandedOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.button_ExpandedOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExpandedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_ExpandedOutput.Location = new System.Drawing.Point(1243, 607);
            this.button_ExpandedOutput.Margin = new System.Windows.Forms.Padding(0);
            this.button_ExpandedOutput.Name = "button_ExpandedOutput";
            this.button_ExpandedOutput.Size = new System.Drawing.Size(369, 30);
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
            this.ReportOutputButton.Location = new System.Drawing.Point(1210, 52);
            this.ReportOutputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportOutputButton.Name = "ReportOutputButton";
            this.ReportOutputButton.Size = new System.Drawing.Size(314, 36);
            this.ReportOutputButton.TabIndex = 6;
            this.ReportOutputButton.Text = "Отчёт: выведеные";
            this.ReportOutputButton.UseVisualStyleBackColor = false;
            this.ReportOutputButton.Click += new System.EventHandler(this.ReportOutputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1611, 672);
            this.Controls.Add(this.button_ExpandedOutput);
            this.Controls.Add(this.input_FastSearch);
            this.Controls.Add(this.ReportOutputButton);
            this.Controls.Add(this.ReportAllButton);
            this.Controls.Add(this.openInFolderButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_reindexing);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listFile);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SortDoc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openInFolderButton;
        private System.Windows.Forms.Button ReportAllButton;
        private System.Windows.Forms.TextBox input_FastSearch;
        private System.Windows.Forms.Button button_ExpandedOutput;
        private System.Windows.Forms.Button ReportOutputButton;
    }
}

