namespace RecipeProject_CSharp
{
    partial class AddIngredForm
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
            this.btn_ai_addingred = new System.Windows.Forms.Button();
            this.btn_ai_quit = new System.Windows.Forms.Button();
            this.dgr_ai_currIngreds = new System.Windows.Forms.DataGridView();
            this.lbl_ai_currIngred = new System.Windows.Forms.Label();
            this.lbl_ai_header = new System.Windows.Forms.Label();
            this.lbl_ai_quan = new System.Windows.Forms.Label();
            this.lbl_ai_ingred = new System.Windows.Forms.Label();
            this.tb_ai_ingred = new System.Windows.Forms.TextBox();
            this.tb_ai_quan = new System.Windows.Forms.TextBox();
            this.cb_ai_unit = new System.Windows.Forms.ComboBox();
            this.lbl_ai_unit = new System.Windows.Forms.Label();
            this.ai_quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ai_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ai_ingred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ai_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ai_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_ai_currIngreds)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ai_addingred
            // 
            this.btn_ai_addingred.Location = new System.Drawing.Point(897, 237);
            this.btn_ai_addingred.Name = "btn_ai_addingred";
            this.btn_ai_addingred.Size = new System.Drawing.Size(102, 64);
            this.btn_ai_addingred.TabIndex = 0;
            this.btn_ai_addingred.Text = "Add New Ingredient";
            this.btn_ai_addingred.UseVisualStyleBackColor = true;
            this.btn_ai_addingred.Click += new System.EventHandler(this.btn_ai_addingred_Click);
            // 
            // btn_ai_quit
            // 
            this.btn_ai_quit.Location = new System.Drawing.Point(897, 614);
            this.btn_ai_quit.Name = "btn_ai_quit";
            this.btn_ai_quit.Size = new System.Drawing.Size(116, 76);
            this.btn_ai_quit.TabIndex = 1;
            this.btn_ai_quit.Text = "Quit";
            this.btn_ai_quit.UseVisualStyleBackColor = true;
            this.btn_ai_quit.Click += new System.EventHandler(this.btn_ai_quit_Click);
            // 
            // dgr_ai_currIngreds
            // 
            this.dgr_ai_currIngreds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_ai_currIngreds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ai_quan,
            this.ai_unit,
            this.ai_ingred,
            this.ai_edit,
            this.ai_delete});
            this.dgr_ai_currIngreds.Location = new System.Drawing.Point(47, 213);
            this.dgr_ai_currIngreds.Name = "dgr_ai_currIngreds";
            this.dgr_ai_currIngreds.RowHeadersWidth = 62;
            this.dgr_ai_currIngreds.RowTemplate.Height = 28;
            this.dgr_ai_currIngreds.Size = new System.Drawing.Size(672, 572);
            this.dgr_ai_currIngreds.TabIndex = 2;
            this.dgr_ai_currIngreds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_ai_currIngreds_CellContentClick);
            // 
            // lbl_ai_currIngred
            // 
            this.lbl_ai_currIngred.AutoSize = true;
            this.lbl_ai_currIngred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ai_currIngred.Location = new System.Drawing.Point(266, 173);
            this.lbl_ai_currIngred.Name = "lbl_ai_currIngred";
            this.lbl_ai_currIngred.Size = new System.Drawing.Size(218, 29);
            this.lbl_ai_currIngred.TabIndex = 3;
            this.lbl_ai_currIngred.Text = "Current Ingredients";
            // 
            // lbl_ai_header
            // 
            this.lbl_ai_header.AutoSize = true;
            this.lbl_ai_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lbl_ai_header.Location = new System.Drawing.Point(339, 9);
            this.lbl_ai_header.Name = "lbl_ai_header";
            this.lbl_ai_header.Size = new System.Drawing.Size(419, 64);
            this.lbl_ai_header.TabIndex = 4;
            this.lbl_ai_header.Text = "Add Ingredients";
            // 
            // lbl_ai_quan
            // 
            this.lbl_ai_quan.AutoSize = true;
            this.lbl_ai_quan.Location = new System.Drawing.Point(770, 173);
            this.lbl_ai_quan.Name = "lbl_ai_quan";
            this.lbl_ai_quan.Size = new System.Drawing.Size(72, 20);
            this.lbl_ai_quan.TabIndex = 5;
            this.lbl_ai_quan.Text = "Quantity:";
            // 
            // lbl_ai_ingred
            // 
            this.lbl_ai_ingred.AutoSize = true;
            this.lbl_ai_ingred.Location = new System.Drawing.Point(992, 175);
            this.lbl_ai_ingred.Name = "lbl_ai_ingred";
            this.lbl_ai_ingred.Size = new System.Drawing.Size(85, 20);
            this.lbl_ai_ingred.TabIndex = 6;
            this.lbl_ai_ingred.Text = "Ingredient:";
            // 
            // tb_ai_ingred
            // 
            this.tb_ai_ingred.Location = new System.Drawing.Point(996, 198);
            this.tb_ai_ingred.Name = "tb_ai_ingred";
            this.tb_ai_ingred.Size = new System.Drawing.Size(100, 26);
            this.tb_ai_ingred.TabIndex = 9;
            // 
            // tb_ai_quan
            // 
            this.tb_ai_quan.Location = new System.Drawing.Point(763, 196);
            this.tb_ai_quan.Name = "tb_ai_quan";
            this.tb_ai_quan.Size = new System.Drawing.Size(100, 26);
            this.tb_ai_quan.TabIndex = 7;
            // 
            // cb_ai_unit
            // 
            this.cb_ai_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ai_unit.FormattingEnabled = true;
            this.cb_ai_unit.Items.AddRange(new object[] {
            "Pound(s)",
            "Gram(s)",
            "Ounce(s)",
            "Gallon(s)",
            "Cup(s)",
            "TBSP(s)",
            "TSP(s)",
            "Whole"});
            this.cb_ai_unit.Location = new System.Drawing.Point(869, 196);
            this.cb_ai_unit.Name = "cb_ai_unit";
            this.cb_ai_unit.Size = new System.Drawing.Size(121, 28);
            this.cb_ai_unit.TabIndex = 8;
            // 
            // lbl_ai_unit
            // 
            this.lbl_ai_unit.AutoSize = true;
            this.lbl_ai_unit.Location = new System.Drawing.Point(907, 173);
            this.lbl_ai_unit.Name = "lbl_ai_unit";
            this.lbl_ai_unit.Size = new System.Drawing.Size(38, 20);
            this.lbl_ai_unit.TabIndex = 10;
            this.lbl_ai_unit.Text = "Unit";
            // 
            // ai_quan
            // 
            this.ai_quan.HeaderText = "Quantity";
            this.ai_quan.MinimumWidth = 8;
            this.ai_quan.Name = "ai_quan";
            this.ai_quan.ReadOnly = true;
            this.ai_quan.Width = 50;
            // 
            // ai_unit
            // 
            this.ai_unit.HeaderText = "Unit";
            this.ai_unit.MinimumWidth = 8;
            this.ai_unit.Name = "ai_unit";
            this.ai_unit.ReadOnly = true;
            this.ai_unit.Width = 75;
            // 
            // ai_ingred
            // 
            this.ai_ingred.HeaderText = "Ingredient";
            this.ai_ingred.MinimumWidth = 8;
            this.ai_ingred.Name = "ai_ingred";
            this.ai_ingred.ReadOnly = true;
            this.ai_ingred.Width = 150;
            // 
            // ai_edit
            // 
            this.ai_edit.HeaderText = "Edit";
            this.ai_edit.MinimumWidth = 8;
            this.ai_edit.Name = "ai_edit";
            this.ai_edit.ReadOnly = true;
            this.ai_edit.Width = 50;
            // 
            // ai_delete
            // 
            this.ai_delete.HeaderText = "Delete";
            this.ai_delete.MinimumWidth = 8;
            this.ai_delete.Name = "ai_delete";
            this.ai_delete.ReadOnly = true;
            this.ai_delete.Text = "X";
            this.ai_delete.Width = 50;
            // 
            // AddIngredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 797);
            this.Controls.Add(this.lbl_ai_unit);
            this.Controls.Add(this.cb_ai_unit);
            this.Controls.Add(this.tb_ai_quan);
            this.Controls.Add(this.tb_ai_ingred);
            this.Controls.Add(this.lbl_ai_ingred);
            this.Controls.Add(this.lbl_ai_quan);
            this.Controls.Add(this.lbl_ai_header);
            this.Controls.Add(this.lbl_ai_currIngred);
            this.Controls.Add(this.dgr_ai_currIngreds);
            this.Controls.Add(this.btn_ai_quit);
            this.Controls.Add(this.btn_ai_addingred);
            this.Name = "AddIngredForm";
            this.Text = "AddIngredForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_ai_currIngreds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ai_addingred;
        private System.Windows.Forms.Button btn_ai_quit;
        private System.Windows.Forms.DataGridView dgr_ai_currIngreds;
        private System.Windows.Forms.Label lbl_ai_currIngred;
        private System.Windows.Forms.Label lbl_ai_header;
        private System.Windows.Forms.Label lbl_ai_quan;
        private System.Windows.Forms.Label lbl_ai_ingred;
        private System.Windows.Forms.TextBox tb_ai_ingred;
        private System.Windows.Forms.TextBox tb_ai_quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ai_quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ai_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ai_ingred;
        private System.Windows.Forms.DataGridViewButtonColumn ai_edit;
        private System.Windows.Forms.DataGridViewButtonColumn ai_delete;
        private System.Windows.Forms.ComboBox cb_ai_unit;
        private System.Windows.Forms.Label lbl_ai_unit;
    }
}