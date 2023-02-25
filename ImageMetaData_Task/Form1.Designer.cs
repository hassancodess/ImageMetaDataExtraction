namespace ImageMetaData_Task
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_chooseImage = new System.Windows.Forms.Button();
            this.txt_people = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_event = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_long = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_metadate = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btn_chooseImage
            // 
            this.btn_chooseImage.Location = new System.Drawing.Point(12, 201);
            this.btn_chooseImage.Name = "btn_chooseImage";
            this.btn_chooseImage.Size = new System.Drawing.Size(172, 23);
            this.btn_chooseImage.TabIndex = 2;
            this.btn_chooseImage.Text = "Choose Image";
            this.btn_chooseImage.UseVisualStyleBackColor = true;
            this.btn_chooseImage.Click += new System.EventHandler(this.btn_chooseImage_Click);
            // 
            // txt_people
            // 
            this.txt_people.Location = new System.Drawing.Point(58, 261);
            this.txt_people.Name = "txt_people";
            this.txt_people.Size = new System.Drawing.Size(126, 20);
            this.txt_people.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Event";
            // 
            // txt_event
            // 
            this.txt_event.Location = new System.Drawing.Point(58, 298);
            this.txt_event.Name = "txt_event";
            this.txt_event.Size = new System.Drawing.Size(126, 20);
            this.txt_event.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lat";
            // 
            // txt_lat
            // 
            this.txt_lat.Location = new System.Drawing.Point(58, 343);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(77, 20);
            this.txt_lat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Long";
            // 
            // txt_long
            // 
            this.txt_long.Location = new System.Drawing.Point(197, 346);
            this.txt_long.Name = "txt_long";
            this.txt_long.Size = new System.Drawing.Size(77, 20);
            this.txt_long.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(58, 382);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 13;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(329, 379);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(137, 23);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "Insert Metadata";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(484, 378);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(137, 23);
            this.btn_view.TabIndex = 15;
            this.btn_view.Text = "View Metadata";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(634, 378);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(137, 23);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit Metadata";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Metadata";
            // 
            // lv_metadate
            // 
            this.lv_metadate.HideSelection = false;
            this.lv_metadate.Location = new System.Drawing.Point(241, 25);
            this.lv_metadate.Name = "lv_metadate";
            this.lv_metadate.Size = new System.Drawing.Size(530, 315);
            this.lv_metadate.TabIndex = 18;
            this.lv_metadate.UseCompatibleStateImageBehavior = false;
            this.lv_metadate.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_metadate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_long);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_lat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_event);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_people);
            this.Controls.Add(this.btn_chooseImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_chooseImage;
        private System.Windows.Forms.TextBox txt_people;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_event;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_long;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_metadate;
    }
}

