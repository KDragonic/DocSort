namespace DocSort
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
            this.listFile = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.listFile.Location = new System.Drawing.Point(0, 79);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(981, 483);
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
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(11, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(235, 61);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(252, 10);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(235, 61);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // openButton
            // 
            this.openButton.AutoSize = true;
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(56)))));
            this.openButton.Enabled = false;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(493, 10);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(235, 61);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = true;
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.removeButton.Enabled = false;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(734, 10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(235, 61);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSearch.Location = new System.Drawing.Point(0, 560);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(981, 30);
            this.inputSearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(981, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Переиндексация файлов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listFile);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button button1;
    }
}

