namespace DocSort
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView_types = new System.Windows.Forms.ListView();
            this.listView_authors = new System.Windows.Forms.ListView();
            this.button_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add_types = new System.Windows.Forms.Button();
            this.button_remove_types = new System.Windows.Forms.Button();
            this.button_add_author = new System.Windows.Forms.Button();
            this.button_remove_author = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetSettingButton = new System.Windows.Forms.Button();
            this.ResetALLSettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_types
            // 
            this.listView_types.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_types.HideSelection = false;
            this.listView_types.Location = new System.Drawing.Point(4, 67);
            this.listView_types.Margin = new System.Windows.Forms.Padding(2);
            this.listView_types.Name = "listView_types";
            this.listView_types.Size = new System.Drawing.Size(160, 326);
            this.listView_types.TabIndex = 1;
            this.listView_types.UseCompatibleStateImageBehavior = false;
            this.listView_types.View = System.Windows.Forms.View.List;
            // 
            // listView_authors
            // 
            this.listView_authors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_authors.HideSelection = false;
            this.listView_authors.Location = new System.Drawing.Point(169, 67);
            this.listView_authors.Margin = new System.Windows.Forms.Padding(2);
            this.listView_authors.Name = "listView_authors";
            this.listView_authors.Size = new System.Drawing.Size(160, 326);
            this.listView_authors.TabIndex = 2;
            this.listView_authors.UseCompatibleStateImageBehavior = false;
            this.listView_authors.View = System.Windows.Forms.View.List;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(4, 429);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(532, 51);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Закрыть и сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Типы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(218, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Авторы";
            // 
            // button_add_types
            // 
            this.button_add_types.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add_types.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.button_add_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_types.ForeColor = System.Drawing.Color.White;
            this.button_add_types.Location = new System.Drawing.Point(4, 397);
            this.button_add_types.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_types.Name = "button_add_types";
            this.button_add_types.Size = new System.Drawing.Size(80, 27);
            this.button_add_types.TabIndex = 5;
            this.button_add_types.Text = "Добавить";
            this.button_add_types.UseVisualStyleBackColor = false;
            this.button_add_types.Click += new System.EventHandler(this.button_add_types_Click);
            // 
            // button_remove_types
            // 
            this.button_remove_types.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_remove_types.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button_remove_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove_types.ForeColor = System.Drawing.Color.White;
            this.button_remove_types.Location = new System.Drawing.Point(88, 397);
            this.button_remove_types.Margin = new System.Windows.Forms.Padding(2);
            this.button_remove_types.Name = "button_remove_types";
            this.button_remove_types.Size = new System.Drawing.Size(76, 27);
            this.button_remove_types.TabIndex = 6;
            this.button_remove_types.Text = "Удалить";
            this.button_remove_types.UseVisualStyleBackColor = false;
            this.button_remove_types.Click += new System.EventHandler(this.button_remove_types_Click);
            // 
            // button_add_author
            // 
            this.button_add_author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.button_add_author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_author.ForeColor = System.Drawing.Color.White;
            this.button_add_author.Location = new System.Drawing.Point(169, 397);
            this.button_add_author.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_author.Name = "button_add_author";
            this.button_add_author.Size = new System.Drawing.Size(80, 27);
            this.button_add_author.TabIndex = 5;
            this.button_add_author.Text = "Добавить";
            this.button_add_author.UseVisualStyleBackColor = false;
            this.button_add_author.Click += new System.EventHandler(this.button_add_author_Click);
            // 
            // button_remove_author
            // 
            this.button_remove_author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_remove_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button_remove_author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove_author.ForeColor = System.Drawing.Color.White;
            this.button_remove_author.Location = new System.Drawing.Point(252, 397);
            this.button_remove_author.Margin = new System.Windows.Forms.Padding(2);
            this.button_remove_author.Name = "button_remove_author";
            this.button_remove_author.Size = new System.Drawing.Size(76, 27);
            this.button_remove_author.TabIndex = 6;
            this.button_remove_author.Text = "Удалить";
            this.button_remove_author.UseVisualStyleBackColor = false;
            this.button_remove_author.Click += new System.EventHandler(this.button_remove_author_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(381, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Прочие";
            // 
            // ResetSettingButton
            // 
            this.ResetSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetSettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ResetSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetSettingButton.ForeColor = System.Drawing.Color.White;
            this.ResetSettingButton.Location = new System.Drawing.Point(339, 67);
            this.ResetSettingButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetSettingButton.Name = "ResetSettingButton";
            this.ResetSettingButton.Size = new System.Drawing.Size(197, 53);
            this.ResetSettingButton.TabIndex = 18;
            this.ResetSettingButton.Text = "Сбросить настройки";
            this.ResetSettingButton.UseVisualStyleBackColor = false;
            this.ResetSettingButton.Click += new System.EventHandler(this.ResetSettingButton_Click);
            // 
            // ResetALLSettingButton
            // 
            this.ResetALLSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetALLSettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ResetALLSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetALLSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetALLSettingButton.ForeColor = System.Drawing.Color.White;
            this.ResetALLSettingButton.Location = new System.Drawing.Point(339, 126);
            this.ResetALLSettingButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetALLSettingButton.Name = "ResetALLSettingButton";
            this.ResetALLSettingButton.Size = new System.Drawing.Size(197, 53);
            this.ResetALLSettingButton.TabIndex = 19;
            this.ResetALLSettingButton.Text = "Сбросить ВСЕ настройки";
            this.ResetALLSettingButton.UseVisualStyleBackColor = false;
            this.ResetALLSettingButton.Click += new System.EventHandler(this.ResetALLSettingButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 484);
            this.Controls.Add(this.ResetALLSettingButton);
            this.Controls.Add(this.ResetSettingButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_remove_author);
            this.Controls.Add(this.button_add_author);
            this.Controls.Add(this.button_remove_types);
            this.Controls.Add(this.button_add_types);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.listView_authors);
            this.Controls.Add(this.listView_types);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_types;
        private System.Windows.Forms.ListView listView_authors;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add_types;
        private System.Windows.Forms.Button button_remove_types;
        private System.Windows.Forms.Button button_add_author;
        private System.Windows.Forms.Button button_remove_author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetSettingButton;
        private System.Windows.Forms.Button ResetALLSettingButton;
    }
}