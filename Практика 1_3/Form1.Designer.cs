namespace Практика_1_3
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чёрныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зелёныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(87, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(171, 88);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(134, 23);
            this.txt.TabIndex = 2;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(317, 24);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чёрныйToolStripMenuItem,
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зелёныйToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // чёрныйToolStripMenuItem
            // 
            this.чёрныйToolStripMenuItem.Name = "чёрныйToolStripMenuItem";
            this.чёрныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.чёрныйToolStripMenuItem.Text = "Чёрный";
            this.чёрныйToolStripMenuItem.Click += new System.EventHandler(this.чёрныйToolStripMenuItem_Click);
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // зелёныйToolStripMenuItem
            // 
            this.зелёныйToolStripMenuItem.Name = "зелёныйToolStripMenuItem";
            this.зелёныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зелёныйToolStripMenuItem.Text = "Зелёный";
            this.зелёныйToolStripMenuItem.Click += new System.EventHandler(this.зелёныйToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 194);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "ListBox and Colors";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnExit;
        private TextBox txt;
        private MenuStrip MenuStrip1;
        private ToolStripMenuItem цветToolStripMenuItem;
        private ToolStripMenuItem чёрныйToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem зелёныйToolStripMenuItem;
    }
}