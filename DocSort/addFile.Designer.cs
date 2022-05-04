namespace DocSort
{
    partial class addFile
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_auther = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_add_auther = new System.Windows.Forms.Button();
            this.button_add_type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(0, 34);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(692, 38);
            this.textBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавления файлы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автор";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(344, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(350, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_auther
            // 
            this.comboBox_auther.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_auther.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_auther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_auther.FormattingEnabled = true;
            this.comboBox_auther.Location = new System.Drawing.Point(0, 107);
            this.comboBox_auther.Name = "comboBox_auther";
            this.comboBox_auther.Size = new System.Drawing.Size(343, 33);
            this.comboBox_auther.TabIndex = 5;
            this.comboBox_auther.TextUpdate += new System.EventHandler(this.comboBox_auther_TextUpdate);
            // 
            // comboBox_type
            // 
            this.comboBox_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(349, 107);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(343, 33);
            this.comboBox_type.TabIndex = 6;
            this.comboBox_type.TextUpdate += new System.EventHandler(this.comboBox_type_TextUpdate);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_add_auther
            // 
            this.button_add_auther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button_add_auther.Enabled = false;
            this.button_add_auther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_auther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_auther.ForeColor = System.Drawing.Color.White;
            this.button_add_auther.Location = new System.Drawing.Point(0, 143);
            this.button_add_auther.Margin = new System.Windows.Forms.Padding(0);
            this.button_add_auther.Name = "button_add_auther";
            this.button_add_auther.Size = new System.Drawing.Size(343, 33);
            this.button_add_auther.TabIndex = 8;
            this.button_add_auther.Text = "Добавить автора";
            this.button_add_auther.UseVisualStyleBackColor = false;
            this.button_add_auther.Click += new System.EventHandler(this.button_add_auther_Click);
            // 
            // button_add_type
            // 
            this.button_add_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(90)))));
            this.button_add_type.Enabled = false;
            this.button_add_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_type.ForeColor = System.Drawing.Color.White;
            this.button_add_type.Location = new System.Drawing.Point(349, 143);
            this.button_add_type.Margin = new System.Windows.Forms.Padding(0);
            this.button_add_type.Name = "button_add_type";
            this.button_add_type.Size = new System.Drawing.Size(344, 33);
            this.button_add_type.TabIndex = 9;
            this.button_add_type.Text = "Добавить тип";
            this.button_add_type.UseVisualStyleBackColor = false;
            this.button_add_type.Click += new System.EventHandler(this.button_add_type_Click);
            // 
            // addFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 229);
            this.Controls.Add(this.button_add_type);
            this.Controls.Add(this.button_add_auther);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox_auther);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addFile";
            this.Text = "Добавления записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_auther;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_add_auther;
        private System.Windows.Forms.Button button_add_type;
    }
}