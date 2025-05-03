namespace BookShop.Forms
{
    partial class Form6
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Query1 = new System.Windows.Forms.ComboBox();
            this.btn_OutputQuery1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Query2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_GenreQuery3 = new System.Windows.Forms.ComboBox();
            this.btn_Query3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Query = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "1) Извеждане на всички книги на конкретен автор:";
            // 
            // cbx_Query1
            // 
            this.cbx_Query1.FormattingEnabled = true;
            this.cbx_Query1.Location = new System.Drawing.Point(591, 110);
            this.cbx_Query1.Name = "cbx_Query1";
            this.cbx_Query1.Size = new System.Drawing.Size(112, 21);
            this.cbx_Query1.TabIndex = 5;
            // 
            // btn_OutputQuery1
            // 
            this.btn_OutputQuery1.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_OutputQuery1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OutputQuery1.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OutputQuery1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_OutputQuery1.Location = new System.Drawing.Point(718, 103);
            this.btn_OutputQuery1.Name = "btn_OutputQuery1";
            this.btn_OutputQuery1.Size = new System.Drawing.Size(98, 30);
            this.btn_OutputQuery1.TabIndex = 11;
            this.btn_OutputQuery1.Text = "Изведи";
            this.btn_OutputQuery1.UseVisualStyleBackColor = false;
            this.btn_OutputQuery1.Click += new System.EventHandler(this.btn_OutputQuery1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "2) Извеждане на всички книги с цена над 10 лв";
            // 
            // btn_Query2
            // 
            this.btn_Query2.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Query2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Query2.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Query2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Query2.Location = new System.Drawing.Point(543, 157);
            this.btn_Query2.Name = "btn_Query2";
            this.btn_Query2.Size = new System.Drawing.Size(98, 30);
            this.btn_Query2.TabIndex = 13;
            this.btn_Query2.Text = "Изведи";
            this.btn_Query2.UseVisualStyleBackColor = false;
            this.btn_Query2.Click += new System.EventHandler(this.btn_Query2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "3) Извличане на всички книги по жанр:\r\n";
            // 
            // cbx_GenreQuery3
            // 
            this.cbx_GenreQuery3.FormattingEnabled = true;
            this.cbx_GenreQuery3.Location = new System.Drawing.Point(458, 222);
            this.cbx_GenreQuery3.Name = "cbx_GenreQuery3";
            this.cbx_GenreQuery3.Size = new System.Drawing.Size(112, 21);
            this.cbx_GenreQuery3.TabIndex = 15;
            // 
            // btn_Query3
            // 
            this.btn_Query3.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Query3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Query3.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Query3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Query3.Location = new System.Drawing.Point(588, 215);
            this.btn_Query3.Name = "btn_Query3";
            this.btn_Query3.Size = new System.Drawing.Size(98, 30);
            this.btn_Query3.TabIndex = 16;
            this.btn_Query3.Text = "Изведи";
            this.btn_Query3.UseVisualStyleBackColor = false;
            this.btn_Query3.Click += new System.EventHandler(this.btn_Query3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(349, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "ЗАЯВКИ";
            // 
            // dgv_Query
            // 
            this.dgv_Query.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgv_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query.Location = new System.Drawing.Point(86, 274);
            this.dgv_Query.Name = "dgv_Query";
            this.dgv_Query.Size = new System.Drawing.Size(667, 145);
            this.dgv_Query.TabIndex = 18;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.dgv_Query);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Query3);
            this.Controls.Add(this.cbx_GenreQuery3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Query2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OutputQuery1);
            this.Controls.Add(this.cbx_Query1);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Query1;
        private System.Windows.Forms.Button btn_OutputQuery1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Query2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_GenreQuery3;
        private System.Windows.Forms.Button btn_Query3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Query;
    }
}