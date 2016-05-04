namespace handbook
{
    partial class Add
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disk = new System.Windows.Forms.TextBox();
            this.song = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(38, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Диск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(38, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Песня:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Исполнитель:";
            // 
            // disk
            // 
            this.disk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.disk.Location = new System.Drawing.Point(207, 190);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(142, 31);
            this.disk.TabIndex = 25;
            // 
            // song
            // 
            this.song.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.song.Location = new System.Drawing.Point(207, 121);
            this.song.Name = "song";
            this.song.Size = new System.Drawing.Size(142, 31);
            this.song.TabIndex = 24;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.name.Location = new System.Drawing.Point(207, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(142, 31);
            this.name.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disk);
            this.Controls.Add(this.song);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox disk;
        private System.Windows.Forms.TextBox song;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
    }
}