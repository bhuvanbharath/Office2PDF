
namespace OfficeToPDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            location_text_box = new System.Windows.Forms.TextBox();
            browse_btn = new System.Windows.Forms.Button();
            word_cb = new System.Windows.Forms.CheckBox();
            ppt_cb = new System.Windows.Forms.CheckBox();
            excel_cb = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            convert_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // location_text_box
            // 
            location_text_box.Location = new System.Drawing.Point(15, 70);
            location_text_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            location_text_box.Name = "location_text_box";
            location_text_box.PlaceholderText = "Enter the location";
            location_text_box.Size = new System.Drawing.Size(347, 27);
            location_text_box.TabIndex = 0;
            location_text_box.TextChanged += textBox1_TextChanged;
            // 
            // browse_btn
            // 
            browse_btn.Location = new System.Drawing.Point(369, 70);
            browse_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            browse_btn.Name = "browse_btn";
            browse_btn.Size = new System.Drawing.Size(86, 31);
            browse_btn.TabIndex = 1;
            browse_btn.Text = "Browse";
            browse_btn.UseVisualStyleBackColor = true;
            browse_btn.Click += button1_Click;
            // 
            // word_cb
            // 
            word_cb.AutoSize = true;
            word_cb.Checked = true;
            word_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            word_cb.Location = new System.Drawing.Point(16, 112);
            word_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            word_cb.Name = "word_cb";
            word_cb.Size = new System.Drawing.Size(67, 24);
            word_cb.TabIndex = 2;
            word_cb.Text = "Word";
            word_cb.UseVisualStyleBackColor = true;
            word_cb.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ppt_cb
            // 
            ppt_cb.AutoSize = true;
            ppt_cb.Checked = true;
            ppt_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            ppt_cb.Location = new System.Drawing.Point(16, 145);
            ppt_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ppt_cb.Name = "ppt_cb";
            ppt_cb.Size = new System.Drawing.Size(104, 24);
            ppt_cb.TabIndex = 3;
            ppt_cb.Text = "PowerPoint";
            ppt_cb.UseVisualStyleBackColor = true;
            // 
            // excel_cb
            // 
            excel_cb.AutoSize = true;
            excel_cb.Checked = true;
            excel_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            excel_cb.Location = new System.Drawing.Point(16, 179);
            excel_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            excel_cb.Name = "excel_cb";
            excel_cb.Size = new System.Drawing.Size(65, 24);
            excel_cb.TabIndex = 4;
            excel_cb.Text = "Excel";
            excel_cb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Honeydew;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(335, 25);
            label1.TabIndex = 5;
            label1.Text = "Convert Office documents to PDF files!";
            //label1.Click += label1_Click;
            // 
            // convert_btn
            // 
            convert_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            convert_btn.Location = new System.Drawing.Point(368, 166);
            convert_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            convert_btn.Name = "convert_btn";
            convert_btn.Size = new System.Drawing.Size(86, 37);
            convert_btn.TabIndex = 6;
            convert_btn.Text = "Convert";
            convert_btn.UseVisualStyleBackColor = false;
            convert_btn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(472, 219);
            Controls.Add(convert_btn);
            Controls.Add(label1);
            Controls.Add(excel_cb);
            Controls.Add(ppt_cb);
            Controls.Add(word_cb);
            Controls.Add(browse_btn);
            Controls.Add(location_text_box);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Office to PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox location_text_box;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.CheckBox word_cb;
        private System.Windows.Forms.CheckBox ppt_cb;
        private System.Windows.Forms.CheckBox excel_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convert_btn;
    }
}

