namespace RecipeProject_CSharp
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
            this.btn_mf_add = new System.Windows.Forms.Button();
            this.btn_mf_quit = new System.Windows.Forms.Button();
            this.lbl_mf_header = new System.Windows.Forms.Label();
            this.btn_mf_save = new System.Windows.Forms.Button();
            this.btn_mf_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mf_add
            // 
            this.btn_mf_add.Location = new System.Drawing.Point(491, 177);
            this.btn_mf_add.Name = "btn_mf_add";
            this.btn_mf_add.Size = new System.Drawing.Size(115, 90);
            this.btn_mf_add.TabIndex = 0;
            this.btn_mf_add.Text = "Add Ingredients";
            this.btn_mf_add.UseVisualStyleBackColor = true;
            this.btn_mf_add.Click += new System.EventHandler(this.btn_mf_add_Click);
            // 
            // btn_mf_quit
            // 
            this.btn_mf_quit.Location = new System.Drawing.Point(491, 481);
            this.btn_mf_quit.Name = "btn_mf_quit";
            this.btn_mf_quit.Size = new System.Drawing.Size(115, 90);
            this.btn_mf_quit.TabIndex = 1;
            this.btn_mf_quit.Text = "Quit";
            this.btn_mf_quit.UseVisualStyleBackColor = true;
            // 
            // lbl_mf_header
            // 
            this.lbl_mf_header.AutoSize = true;
            this.lbl_mf_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_mf_header.Location = new System.Drawing.Point(361, 72);
            this.lbl_mf_header.Name = "lbl_mf_header";
            this.lbl_mf_header.Size = new System.Drawing.Size(323, 55);
            this.lbl_mf_header.TabIndex = 2;
            this.lbl_mf_header.Text = "Recipe Finder";
            // 
            // btn_mf_save
            // 
            this.btn_mf_save.Location = new System.Drawing.Point(491, 273);
            this.btn_mf_save.Name = "btn_mf_save";
            this.btn_mf_save.Size = new System.Drawing.Size(115, 90);
            this.btn_mf_save.TabIndex = 3;
            this.btn_mf_save.Text = "Save Ingredients";
            this.btn_mf_save.UseVisualStyleBackColor = true;
            this.btn_mf_save.Click += new System.EventHandler(this.btn_mf_save_Click);
            // 
            // btn_mf_load
            // 
            this.btn_mf_load.Location = new System.Drawing.Point(491, 369);
            this.btn_mf_load.Name = "btn_mf_load";
            this.btn_mf_load.Size = new System.Drawing.Size(115, 90);
            this.btn_mf_load.TabIndex = 4;
            this.btn_mf_load.Text = "Load Ingredients";
            this.btn_mf_load.UseVisualStyleBackColor = true;
            this.btn_mf_load.Click += new System.EventHandler(this.btn_mf_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 752);
            this.Controls.Add(this.btn_mf_load);
            this.Controls.Add(this.btn_mf_save);
            this.Controls.Add(this.lbl_mf_header);
            this.Controls.Add(this.btn_mf_quit);
            this.Controls.Add(this.btn_mf_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mf_add;
        private System.Windows.Forms.Button btn_mf_quit;
        private System.Windows.Forms.Label lbl_mf_header;
        private System.Windows.Forms.Button btn_mf_save;
        private System.Windows.Forms.Button btn_mf_load;
    }
}

