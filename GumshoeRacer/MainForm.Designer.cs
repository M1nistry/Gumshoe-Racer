namespace GumshoeRacer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimizePanel = new System.Windows.Forms.Panel();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.classLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankSuffixLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rankListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.experienceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewPanel = new System.Windows.Forms.Panel();
            this.levelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.minimizePanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleLabel.Location = new System.Drawing.Point(11, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Gumshoe Racer - 0.1";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // minimizePanel
            // 
            this.minimizePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimizePanel.Controls.Add(this.minimizeLabel);
            this.minimizePanel.Location = new System.Drawing.Point(243, 2);
            this.minimizePanel.Name = "minimizePanel";
            this.minimizePanel.Size = new System.Drawing.Size(16, 16);
            this.minimizePanel.TabIndex = 3;
            this.minimizePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.minimizePanel_Paint);
            this.minimizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizePanel_MouseClick);
            this.minimizePanel.MouseEnter += new System.EventHandler(this.minimizePanel_MouseEnter);
            this.minimizePanel.MouseLeave += new System.EventHandler(this.minimizePanel_MouseLeave);
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimizeLabel.Location = new System.Drawing.Point(2, -1);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(12, 13);
            this.minimizeLabel.TabIndex = 4;
            this.minimizeLabel.Text = "_";
            // 
            // closePanel
            // 
            this.closePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closePanel.Controls.Add(this.closeLabel);
            this.closePanel.Location = new System.Drawing.Point(263, 2);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(16, 16);
            this.closePanel.TabIndex = 5;
            this.closePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.closePanel_Paint);
            this.closePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closePanel_MouseClick);
            this.closePanel.MouseEnter += new System.EventHandler(this.closePanel_MouseEnter);
            this.closePanel.MouseLeave += new System.EventHandler(this.closePanel_MouseLeave);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.closeLabel.Location = new System.Drawing.Point(1, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(11, 11);
            this.closeLabel.TabIndex = 6;
            this.closeLabel.Text = "x";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.titlePanel.Controls.Add(this.minimizePanel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.closePanel);
            this.titlePanel.Location = new System.Drawing.Point(0, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(284, 20);
            this.titlePanel.TabIndex = 6;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(12, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameTextBox.Location = new System.Drawing.Point(57, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(131, 22);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            this.nameTextBox.MouseEnter += new System.EventHandler(this.nameTextBox_MouseEnter);
            this.nameTextBox.MouseLeave += new System.EventHandler(this.nameTextBox_MouseLeave);
            // 
            // namePanel
            // 
            this.namePanel.Location = new System.Drawing.Point(56, 58);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(133, 24);
            this.namePanel.TabIndex = 9;
            this.namePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.namePanel_Paint);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.classLabel.Location = new System.Drawing.Point(206, 63);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(52, 13);
            this.classLabel.TabIndex = 10;
            this.classLabel.Text = "Marauder";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rankLabel.Location = new System.Drawing.Point(13, 83);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(84, 65);
            this.rankLabel.TabIndex = 11;
            this.rankLabel.Text = "22";
            // 
            // rankSuffixLabel
            // 
            this.rankSuffixLabel.AutoSize = true;
            this.rankSuffixLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankSuffixLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rankSuffixLabel.Location = new System.Drawing.Point(77, 111);
            this.rankSuffixLabel.Name = "rankSuffixLabel";
            this.rankSuffixLabel.Size = new System.Drawing.Size(37, 30);
            this.rankSuffixLabel.TabIndex = 12;
            this.rankSuffixLabel.Text = "nd";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLabel.Location = new System.Drawing.Point(128, 124);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(47, 13);
            this.levelLabel.TabIndex = 13;
            this.levelLabel.Text = "Level 16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(194, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "425, 451 xp";
            // 
            // rankListView
            // 
            this.rankListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.rankListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.levelColumn,
            this.experienceColumn});
            this.rankListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankListView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rankListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.rankListView.Location = new System.Drawing.Point(24, 152);
            this.rankListView.MultiSelect = false;
            this.rankListView.Name = "rankListView";
            this.rankListView.Scrollable = false;
            this.rankListView.Size = new System.Drawing.Size(234, 243);
            this.rankListView.TabIndex = 15;
            this.rankListView.UseCompatibleStateImageBehavior = false;
            this.rankListView.View = System.Windows.Forms.View.Details;
            this.rankListView.SelectedIndexChanged += new System.EventHandler(this.rankListView_SelectedIndexChanged);
            this.rankListView.MouseEnter += new System.EventHandler(this.rankListView_MouseEnter);
            this.rankListView.MouseLeave += new System.EventHandler(this.rankListView_MouseLeave);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 80;
            // 
            // experienceColumn
            // 
            this.experienceColumn.DisplayIndex = 1;
            this.experienceColumn.Text = "Experience";
            this.experienceColumn.Width = 85;
            // 
            // listviewPanel
            // 
            this.listviewPanel.Location = new System.Drawing.Point(23, 151);
            this.listviewPanel.Name = "listviewPanel";
            this.listviewPanel.Size = new System.Drawing.Size(236, 245);
            this.listviewPanel.TabIndex = 16;
            this.listviewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.listviewPanel_Paint);
            // 
            // levelColumn
            // 
            this.levelColumn.DisplayIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Race:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(284, 414);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rankListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.rankSuffixLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.listviewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Gumshoe Racer";
            this.minimizePanel.ResumeLayout(false);
            this.minimizePanel.PerformLayout();
            this.closePanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel minimizePanel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label rankSuffixLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView rankListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader experienceColumn;
        private System.Windows.Forms.Panel listviewPanel;
        private System.Windows.Forms.ColumnHeader levelColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

