namespace CreateService
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRepository = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowRepoFolder = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.Service = new System.Windows.Forms.Label();
            this.btnShowServiceFolder = new System.Windows.Forms.Button();
            this.txtUnitTestRepository = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowURepFolder = new System.Windows.Forms.Button();
            this.txtUnitTestService = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowUServiceFolder = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowModelFolder = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(597, 724);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(707, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(597, 724);
            this.listBox2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(618, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(618, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRepository
            // 
            this.txtRepository.Location = new System.Drawing.Point(168, 779);
            this.txtRepository.Name = "txtRepository";
            this.txtRepository.Size = new System.Drawing.Size(389, 22);
            this.txtRepository.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 784);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repository";
            // 
            // btnShowRepoFolder
            // 
            this.btnShowRepoFolder.Location = new System.Drawing.Point(567, 779);
            this.btnShowRepoFolder.Name = "btnShowRepoFolder";
            this.btnShowRepoFolder.Size = new System.Drawing.Size(43, 23);
            this.btnShowRepoFolder.TabIndex = 4;
            this.btnShowRepoFolder.Text = "....";
            this.btnShowRepoFolder.UseVisualStyleBackColor = true;
            this.btnShowRepoFolder.Click += new System.EventHandler(this.btnShowRepoFolder_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(168, 818);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(389, 22);
            this.txtService.TabIndex = 2;
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Location = new System.Drawing.Point(29, 823);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(55, 17);
            this.Service.TabIndex = 3;
            this.Service.Text = "Service";
            // 
            // btnShowServiceFolder
            // 
            this.btnShowServiceFolder.Location = new System.Drawing.Point(567, 818);
            this.btnShowServiceFolder.Name = "btnShowServiceFolder";
            this.btnShowServiceFolder.Size = new System.Drawing.Size(43, 23);
            this.btnShowServiceFolder.TabIndex = 4;
            this.btnShowServiceFolder.Text = "....";
            this.btnShowServiceFolder.UseVisualStyleBackColor = true;
            this.btnShowServiceFolder.Click += new System.EventHandler(this.btnShowServiceFolder_Click);
            // 
            // txtUnitTestRepository
            // 
            this.txtUnitTestRepository.Location = new System.Drawing.Point(168, 855);
            this.txtUnitTestRepository.Name = "txtUnitTestRepository";
            this.txtUnitTestRepository.Size = new System.Drawing.Size(389, 22);
            this.txtUnitTestRepository.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 860);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "UnitTest.Repository";
            // 
            // btnShowURepFolder
            // 
            this.btnShowURepFolder.Location = new System.Drawing.Point(567, 855);
            this.btnShowURepFolder.Name = "btnShowURepFolder";
            this.btnShowURepFolder.Size = new System.Drawing.Size(43, 23);
            this.btnShowURepFolder.TabIndex = 4;
            this.btnShowURepFolder.Text = "....";
            this.btnShowURepFolder.UseVisualStyleBackColor = true;
            // 
            // txtUnitTestService
            // 
            this.txtUnitTestService.Location = new System.Drawing.Point(168, 892);
            this.txtUnitTestService.Name = "txtUnitTestService";
            this.txtUnitTestService.Size = new System.Drawing.Size(389, 22);
            this.txtUnitTestService.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 897);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "UnitTest.Service";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnShowUServiceFolder
            // 
            this.btnShowUServiceFolder.Location = new System.Drawing.Point(567, 892);
            this.btnShowUServiceFolder.Name = "btnShowUServiceFolder";
            this.btnShowUServiceFolder.Size = new System.Drawing.Size(43, 23);
            this.btnShowUServiceFolder.TabIndex = 4;
            this.btnShowUServiceFolder.Text = "....";
            this.btnShowUServiceFolder.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(168, 742);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(389, 22);
            this.txtModel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 747);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // btnShowModelFolder
            // 
            this.btnShowModelFolder.Location = new System.Drawing.Point(567, 742);
            this.btnShowModelFolder.Name = "btnShowModelFolder";
            this.btnShowModelFolder.Size = new System.Drawing.Size(43, 23);
            this.btnShowModelFolder.TabIndex = 4;
            this.btnShowModelFolder.Text = "....";
            this.btnShowModelFolder.UseVisualStyleBackColor = true;
            this.btnShowModelFolder.Click += new System.EventHandler(this.btnShowModelFolder_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(618, 251);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(74, 34);
            this.btnAddAll.TabIndex = 1;
            this.btnAddAll.Text = ">>>>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(1229, 747);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 34);
            this.btnMake.TabIndex = 1;
            this.btnMake.Text = "Hazırla";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 939);
            this.Controls.Add(this.btnShowUServiceFolder);
            this.Controls.Add(this.btnShowURepFolder);
            this.Controls.Add(this.btnShowServiceFolder);
            this.Controls.Add(this.btnShowModelFolder);
            this.Controls.Add(this.btnShowRepoFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitTestService);
            this.Controls.Add(this.txtUnitTestRepository);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtRepository);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRepository;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowRepoFolder;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label Service;
        private System.Windows.Forms.Button btnShowServiceFolder;
        private System.Windows.Forms.TextBox txtUnitTestRepository;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowURepFolder;
        private System.Windows.Forms.TextBox txtUnitTestService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowUServiceFolder;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowModelFolder;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnMake;
    }
}

