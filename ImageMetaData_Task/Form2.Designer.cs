namespace ImageMetaData_Task
{
    partial class Form2
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
            this.btn_getAllImageNames = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_viewMetadata = new System.Windows.Forms.Button();
            this.btn_fetchImage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lv_imageNames = new System.Windows.Forms.ListView();
            this.lv_imageMetaData = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image List";
            // 
            // btn_getAllImageNames
            // 
            this.btn_getAllImageNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getAllImageNames.Location = new System.Drawing.Point(15, 409);
            this.btn_getAllImageNames.Name = "btn_getAllImageNames";
            this.btn_getAllImageNames.Size = new System.Drawing.Size(217, 29);
            this.btn_getAllImageNames.TabIndex = 1;
            this.btn_getAllImageNames.Text = "Get All Image Names";
            this.btn_getAllImageNames.UseVisualStyleBackColor = true;
            this.btn_getAllImageNames.Click += new System.EventHandler(this.btn_getAllImageNames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(256, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Metadata";
            // 
            // btn_viewMetadata
            // 
            this.btn_viewMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewMetadata.Location = new System.Drawing.Point(256, 197);
            this.btn_viewMetadata.Name = "btn_viewMetadata";
            this.btn_viewMetadata.Size = new System.Drawing.Size(168, 29);
            this.btn_viewMetadata.TabIndex = 7;
            this.btn_viewMetadata.Text = "View Metadata";
            this.btn_viewMetadata.UseVisualStyleBackColor = true;
            this.btn_viewMetadata.Click += new System.EventHandler(this.btn_viewMetadata_Click);
            // 
            // btn_fetchImage
            // 
            this.btn_fetchImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fetchImage.Location = new System.Drawing.Point(15, 374);
            this.btn_fetchImage.Name = "btn_fetchImage";
            this.btn_fetchImage.Size = new System.Drawing.Size(217, 29);
            this.btn_fetchImage.TabIndex = 8;
            this.btn_fetchImage.Text = "Fetch Image";
            this.btn_fetchImage.UseVisualStyleBackColor = true;
            this.btn_fetchImage.Click += new System.EventHandler(this.btn_fetchImage_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(446, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(342, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Open Form 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lv_imageNames
            // 
            this.lv_imageNames.HideSelection = false;
            this.lv_imageNames.Location = new System.Drawing.Point(15, 28);
            this.lv_imageNames.Name = "lv_imageNames";
            this.lv_imageNames.Size = new System.Drawing.Size(217, 331);
            this.lv_imageNames.TabIndex = 10;
            this.lv_imageNames.UseCompatibleStateImageBehavior = false;
            this.lv_imageNames.View = System.Windows.Forms.View.List;
            // 
            // lv_imageMetaData
            // 
            this.lv_imageMetaData.HideSelection = false;
            this.lv_imageMetaData.Location = new System.Drawing.Point(446, 28);
            this.lv_imageMetaData.Name = "lv_imageMetaData";
            this.lv_imageMetaData.Size = new System.Drawing.Size(342, 375);
            this.lv_imageMetaData.TabIndex = 11;
            this.lv_imageMetaData.UseCompatibleStateImageBehavior = false;
            this.lv_imageMetaData.View = System.Windows.Forms.View.List;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_imageMetaData);
            this.Controls.Add(this.lv_imageNames);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_fetchImage);
            this.Controls.Add(this.btn_viewMetadata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_getAllImageNames);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getAllImageNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_viewMetadata;
        private System.Windows.Forms.Button btn_fetchImage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lv_imageNames;
        private System.Windows.Forms.ListView lv_imageMetaData;
    }
}