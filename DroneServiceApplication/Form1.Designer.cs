namespace DroneServiceApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.rdoExpress = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnDelRegular = new System.Windows.Forms.Button();
            this.btnDelExpress = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stsStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitbtn = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.grp1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUpDown
            // 
            this.numUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown.Location = new System.Drawing.Point(158, 25);
            this.numUpDown.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(135, 26);
            this.numUpDown.TabIndex = 0;
            this.numUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(60, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(92, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Service Tag";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.rdoExpress);
            this.grp1.Controls.Add(this.rdoRegular);
            this.grp1.Location = new System.Drawing.Point(158, 57);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(135, 75);
            this.grp1.TabIndex = 3;
            this.grp1.TabStop = false;
            this.grp1.Text = "Service Priority";
            // 
            // rdoExpress
            // 
            this.rdoExpress.AutoSize = true;
            this.rdoExpress.Location = new System.Drawing.Point(6, 43);
            this.rdoExpress.Name = "rdoExpress";
            this.rdoExpress.Size = new System.Drawing.Size(84, 24);
            this.rdoExpress.TabIndex = 1;
            this.rdoExpress.TabStop = true;
            this.rdoExpress.Text = "Express";
            this.rdoExpress.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(6, 20);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(83, 24);
            this.rdoRegular.TabIndex = 0;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(29, 297);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(123, 20);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Service Problem";
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(10, 320);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(327, 145);
            this.txtProblem.TabIndex = 5;
            // 
            // lstView
            // 
            this.lstView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(402, 69);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(355, 504);
            this.lstView.TabIndex = 6;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // lstBox
            // 
            this.lstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 20;
            this.lstBox.Location = new System.Drawing.Point(784, 69);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(216, 504);
            this.lstBox.TabIndex = 7;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(398, 46);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(135, 20);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "Drones In Service";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(780, 46);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(125, 20);
            this.lbl7.TabIndex = 9;
            this.lbl7.Text = "Finished Service";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(57, 155);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(95, 20);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Client Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 26);
            this.txtName.TabIndex = 11;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(52, 201);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 20);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Drone Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(158, 200);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(135, 26);
            this.txtModel.TabIndex = 13;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(158, 247);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(135, 26);
            this.txtCost.TabIndex = 14;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(54, 247);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(98, 20);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Service Cost";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(129, 489);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(89, 66);
            this.btnAddNewItem.TabIndex = 16;
            this.btnAddNewItem.Text = "ADD";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.AddNewItem);
            // 
            // btnDelRegular
            // 
            this.btnDelRegular.Location = new System.Drawing.Point(248, 489);
            this.btnDelRegular.Name = "btnDelRegular";
            this.btnDelRegular.Size = new System.Drawing.Size(89, 66);
            this.btnDelRegular.TabIndex = 17;
            this.btnDelRegular.Text = "Remove Regular";
            this.btnDelRegular.UseVisualStyleBackColor = true;
            // 
            // btnDelExpress
            // 
            this.btnDelExpress.Location = new System.Drawing.Point(10, 489);
            this.btnDelExpress.Name = "btnDelExpress";
            this.btnDelExpress.Size = new System.Drawing.Size(89, 66);
            this.btnDelExpress.TabIndex = 18;
            this.btnDelExpress.Text = "Remove Express";
            this.btnDelExpress.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.btnDelExpress);
            this.groupBox2.Controls.Add(this.numUpDown);
            this.groupBox2.Controls.Add(this.btnDelRegular);
            this.groupBox2.Controls.Add(this.grp1);
            this.groupBox2.Controls.Add(this.btnAddNewItem);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.lbl5);
            this.groupBox2.Controls.Add(this.txtProblem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 577);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data of Drone";
            // 
            // stsStrip
            // 
            this.stsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitbtn});
            this.stsStrip.Location = new System.Drawing.Point(0, 615);
            this.stsStrip.Name = "stsStrip";
            this.stsStrip.Size = new System.Drawing.Size(1012, 22);
            this.stsStrip.TabIndex = 20;
            this.stsStrip.Text = "Error";
            // 
            // toolStripSplitbtn
            // 
            this.toolStripSplitbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitbtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitbtn.Image")));
            this.toolStripSplitbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitbtn.Name = "toolStripSplitbtn";
            this.toolStripSplitbtn.Size = new System.Drawing.Size(48, 20);
            this.toolStripSplitbtn.Text = "Error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 637);
            this.Controls.Add(this.stsStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.lstView);
            this.Name = "Form1";
            this.Text = "Drone Service Application";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stsStrip.ResumeLayout(false);
            this.stsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RadioButton rdoExpress;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnDelRegular;
        private System.Windows.Forms.Button btnDelExpress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip stsStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitbtn;
    }
}

