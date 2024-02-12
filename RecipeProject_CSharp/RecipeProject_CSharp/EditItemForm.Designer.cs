namespace RecipeProject_CSharp
{
    partial class EditItemForm
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
            this.btn_ei_ok = new System.Windows.Forms.Button();
            this.tb_ei_ingred = new System.Windows.Forms.TextBox();
            this.tb_ei_quan = new System.Windows.Forms.TextBox();
            this.lbl_ei_ingred = new System.Windows.Forms.Label();
            this.lbl_ei_quan = new System.Windows.Forms.Label();
            this.btn_ei_quit = new System.Windows.Forms.Button();
            this.cb_ei_unit = new System.Windows.Forms.ComboBox();
            this.lbl_ei_unit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ei_ok
            // 
            this.btn_ei_ok.Location = new System.Drawing.Point(108, 294);
            this.btn_ei_ok.Name = "btn_ei_ok";
            this.btn_ei_ok.Size = new System.Drawing.Size(132, 76);
            this.btn_ei_ok.TabIndex = 0;
            this.btn_ei_ok.Text = "Ok";
            this.btn_ei_ok.UseVisualStyleBackColor = true;
            this.btn_ei_ok.Click += new System.EventHandler(this.btn_ei_ok_Click);
            // 
            // tb_ei_ingred
            // 
            this.tb_ei_ingred.Location = new System.Drawing.Point(260, 117);
            this.tb_ei_ingred.Name = "tb_ei_ingred";
            this.tb_ei_ingred.Size = new System.Drawing.Size(100, 26);
            this.tb_ei_ingred.TabIndex = 1;
            // 
            // tb_ei_quan
            // 
            this.tb_ei_quan.Location = new System.Drawing.Point(260, 225);
            this.tb_ei_quan.Name = "tb_ei_quan";
            this.tb_ei_quan.Size = new System.Drawing.Size(100, 26);
            this.tb_ei_quan.TabIndex = 2;
            // 
            // lbl_ei_ingred
            // 
            this.lbl_ei_ingred.AutoSize = true;
            this.lbl_ei_ingred.Location = new System.Drawing.Point(155, 120);
            this.lbl_ei_ingred.Name = "lbl_ei_ingred";
            this.lbl_ei_ingred.Size = new System.Drawing.Size(85, 20);
            this.lbl_ei_ingred.TabIndex = 3;
            this.lbl_ei_ingred.Text = "Ingredient:";
            // 
            // lbl_ei_quan
            // 
            this.lbl_ei_quan.AutoSize = true;
            this.lbl_ei_quan.Location = new System.Drawing.Point(155, 228);
            this.lbl_ei_quan.Name = "lbl_ei_quan";
            this.lbl_ei_quan.Size = new System.Drawing.Size(72, 20);
            this.lbl_ei_quan.TabIndex = 4;
            this.lbl_ei_quan.Text = "Quantity:";
            // 
            // btn_ei_quit
            // 
            this.btn_ei_quit.Location = new System.Drawing.Point(246, 294);
            this.btn_ei_quit.Name = "btn_ei_quit";
            this.btn_ei_quit.Size = new System.Drawing.Size(132, 76);
            this.btn_ei_quit.TabIndex = 5;
            this.btn_ei_quit.Text = "Close (Don\'t Save)";
            this.btn_ei_quit.UseVisualStyleBackColor = true;
            this.btn_ei_quit.Click += new System.EventHandler(this.btn_ei_quit_Click);
            // 
            // cb_ei_unit
            // 
            this.cb_ei_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ei_unit.FormattingEnabled = true;
            this.cb_ei_unit.Items.AddRange(new object[] {
            "Pound(s)",
            "Gram(s)",
            "Ounce(s)",
            "Gallon(s)",
            "Cup(s)",
            "TBSP(s)",
            "TSP(s)",
            "Whole"});
            this.cb_ei_unit.Location = new System.Drawing.Point(260, 173);
            this.cb_ei_unit.Name = "cb_ei_unit";
            this.cb_ei_unit.Size = new System.Drawing.Size(121, 28);
            this.cb_ei_unit.TabIndex = 6;
            // 
            // lbl_ei_unit
            // 
            this.lbl_ei_unit.AutoSize = true;
            this.lbl_ei_unit.Location = new System.Drawing.Point(159, 180);
            this.lbl_ei_unit.Name = "lbl_ei_unit";
            this.lbl_ei_unit.Size = new System.Drawing.Size(42, 20);
            this.lbl_ei_unit.TabIndex = 7;
            this.lbl_ei_unit.Text = "Unit:";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 455);
            this.Controls.Add(this.lbl_ei_unit);
            this.Controls.Add(this.cb_ei_unit);
            this.Controls.Add(this.btn_ei_quit);
            this.Controls.Add(this.lbl_ei_quan);
            this.Controls.Add(this.lbl_ei_ingred);
            this.Controls.Add(this.tb_ei_quan);
            this.Controls.Add(this.tb_ei_ingred);
            this.Controls.Add(this.btn_ei_ok);
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ei_ok;
        private System.Windows.Forms.TextBox tb_ei_ingred;
        private System.Windows.Forms.TextBox tb_ei_quan;
        private System.Windows.Forms.Label lbl_ei_ingred;
        private System.Windows.Forms.Label lbl_ei_quan;
        private System.Windows.Forms.Button btn_ei_quit;
        private System.Windows.Forms.ComboBox cb_ei_unit;
        private System.Windows.Forms.Label lbl_ei_unit;
    }
}