
namespace STS_card_randomiser
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxIC = new System.Windows.Forms.CheckBox();
            this.checkBoxSilent = new System.Windows.Forms.CheckBox();
            this.checkBoxDefect = new System.Windows.Forms.CheckBox();
            this.checkBoxWatcher = new System.Windows.Forms.CheckBox();
            this.checkBoxColourless = new System.Windows.Forms.CheckBox();
            this.checkBoxCurses = new System.Windows.Forms.CheckBox();
            this.checkBoxStatuses = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxSkip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Outcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rarity";
            // 
            // checkBoxIC
            // 
            this.checkBoxIC.AutoSize = true;
            this.checkBoxIC.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIC.Location = new System.Drawing.Point(190, 40);
            this.checkBoxIC.Name = "checkBoxIC";
            this.checkBoxIC.Size = new System.Drawing.Size(168, 23);
            this.checkBoxIC.TabIndex = 3;
            this.checkBoxIC.Text = "Ironclad Cards";
            this.checkBoxIC.UseVisualStyleBackColor = true;
            // 
            // checkBoxSilent
            // 
            this.checkBoxSilent.AutoSize = true;
            this.checkBoxSilent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSilent.Location = new System.Drawing.Point(190, 69);
            this.checkBoxSilent.Name = "checkBoxSilent";
            this.checkBoxSilent.Size = new System.Drawing.Size(148, 23);
            this.checkBoxSilent.TabIndex = 4;
            this.checkBoxSilent.Text = "Silent Cards";
            this.checkBoxSilent.UseVisualStyleBackColor = true;
            // 
            // checkBoxDefect
            // 
            this.checkBoxDefect.AutoSize = true;
            this.checkBoxDefect.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDefect.Location = new System.Drawing.Point(190, 98);
            this.checkBoxDefect.Name = "checkBoxDefect";
            this.checkBoxDefect.Size = new System.Drawing.Size(148, 23);
            this.checkBoxDefect.TabIndex = 5;
            this.checkBoxDefect.Text = "Defect Cards";
            this.checkBoxDefect.UseVisualStyleBackColor = true;
            // 
            // checkBoxWatcher
            // 
            this.checkBoxWatcher.AutoSize = true;
            this.checkBoxWatcher.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWatcher.Location = new System.Drawing.Point(190, 127);
            this.checkBoxWatcher.Name = "checkBoxWatcher";
            this.checkBoxWatcher.Size = new System.Drawing.Size(158, 23);
            this.checkBoxWatcher.TabIndex = 6;
            this.checkBoxWatcher.Text = "Watcher Cards";
            this.checkBoxWatcher.UseMnemonic = false;
            this.checkBoxWatcher.UseVisualStyleBackColor = true;
            // 
            // checkBoxColourless
            // 
            this.checkBoxColourless.AutoSize = true;
            this.checkBoxColourless.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxColourless.Location = new System.Drawing.Point(190, 157);
            this.checkBoxColourless.Name = "checkBoxColourless";
            this.checkBoxColourless.Size = new System.Drawing.Size(188, 23);
            this.checkBoxColourless.TabIndex = 7;
            this.checkBoxColourless.Text = "Colourless Cards";
            this.checkBoxColourless.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurses
            // 
            this.checkBoxCurses.AutoSize = true;
            this.checkBoxCurses.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCurses.Location = new System.Drawing.Point(190, 187);
            this.checkBoxCurses.Name = "checkBoxCurses";
            this.checkBoxCurses.Size = new System.Drawing.Size(88, 23);
            this.checkBoxCurses.TabIndex = 8;
            this.checkBoxCurses.Text = "Curses";
            this.checkBoxCurses.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatuses
            // 
            this.checkBoxStatuses.AutoSize = true;
            this.checkBoxStatuses.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStatuses.Location = new System.Drawing.Point(190, 217);
            this.checkBoxStatuses.Name = "checkBoxStatuses";
            this.checkBoxStatuses.Size = new System.Drawing.Size(108, 23);
            this.checkBoxStatuses.TabIndex = 9;
            this.checkBoxStatuses.Text = "Statuses";
            this.checkBoxStatuses.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 81);
            this.button2.TabIndex = 10;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxSkip
            // 
            this.checkBoxSkip.AutoSize = true;
            this.checkBoxSkip.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSkip.Location = new System.Drawing.Point(190, 11);
            this.checkBoxSkip.Name = "checkBoxSkip";
            this.checkBoxSkip.Size = new System.Drawing.Size(128, 23);
            this.checkBoxSkip.TabIndex = 11;
            this.checkBoxSkip.Text = "Skip cards";
            this.checkBoxSkip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 304);
            this.Controls.Add(this.checkBoxSkip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxStatuses);
            this.Controls.Add(this.checkBoxCurses);
            this.Controls.Add(this.checkBoxColourless);
            this.Controls.Add(this.checkBoxWatcher);
            this.Controls.Add(this.checkBoxDefect);
            this.Controls.Add(this.checkBoxSilent);
            this.Controls.Add(this.checkBoxIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxIC;
        private System.Windows.Forms.CheckBox checkBoxSilent;
        private System.Windows.Forms.CheckBox checkBoxDefect;
        private System.Windows.Forms.CheckBox checkBoxWatcher;
        private System.Windows.Forms.CheckBox checkBoxColourless;
        private System.Windows.Forms.CheckBox checkBoxCurses;
        private System.Windows.Forms.CheckBox checkBoxStatuses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxSkip;
    }
}

