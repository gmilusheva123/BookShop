namespace BookShop
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
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Author = new System.Windows.Forms.Button();
            this.btn_Genre = new System.Windows.Forms.Button();
            this.btn_BookAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "КНИЖАРНИЦА";
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Book.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Book.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Book.Location = new System.Drawing.Point(78, 103);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(164, 45);
            this.btn_Book.TabIndex = 1;
            this.btn_Book.Text = "Книги";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Author
            // 
            this.btn_Author.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Author.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Author.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Author.Location = new System.Drawing.Point(78, 171);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Size = new System.Drawing.Size(164, 45);
            this.btn_Author.TabIndex = 2;
            this.btn_Author.Text = "Автори";
            this.btn_Author.UseVisualStyleBackColor = false;
            this.btn_Author.Click += new System.EventHandler(this.btn_Author_Click);
            // 
            // btn_Genre
            // 
            this.btn_Genre.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Genre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Genre.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Genre.Location = new System.Drawing.Point(78, 240);
            this.btn_Genre.Name = "btn_Genre";
            this.btn_Genre.Size = new System.Drawing.Size(164, 45);
            this.btn_Genre.TabIndex = 3;
            this.btn_Genre.Text = "Жанрове";
            this.btn_Genre.UseVisualStyleBackColor = false;
            this.btn_Genre.Click += new System.EventHandler(this.btn_Genre_Click);
            // 
            // btn_BookAuthor
            // 
            this.btn_BookAuthor.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_BookAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BookAuthor.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BookAuthor.Location = new System.Drawing.Point(78, 308);
            this.btn_BookAuthor.Name = "btn_BookAuthor";
            this.btn_BookAuthor.Size = new System.Drawing.Size(164, 45);
            this.btn_BookAuthor.TabIndex = 4;
            this.btn_BookAuthor.Text = "Книги и автори";
            this.btn_BookAuthor.UseVisualStyleBackColor = false;
            this.btn_BookAuthor.Click += new System.EventHandler(this.btn_BookAuthor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(317, 377);
            this.Controls.Add(this.btn_BookAuthor);
            this.Controls.Add(this.btn_Genre);
            this.Controls.Add(this.btn_Author);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BookShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Button btn_Genre;
        private System.Windows.Forms.Button btn_BookAuthor;
    }
}

