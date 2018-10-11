namespace Citesoft.AnnotationTools.Presentacion
{
    partial class AnnotationTool
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateSystemDirectory = new System.Windows.Forms.Button();
            this.btnSearchSystemDirectory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSystemDirectory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bStart_SelectAnotateImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSystemFile = new System.Windows.Forms.TextBox();
            this.btnSearchSystemFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCacheDirectory = new System.Windows.Forms.TextBox();
            this.btnSearchCacheDirectory = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateSystemDirectory);
            this.groupBox2.Controls.Add(this.btnSearchSystemDirectory);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSystemDirectory);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 71);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Workspace";
            // 
            // btnCreateSystemDirectory
            // 
            this.btnCreateSystemDirectory.Location = new System.Drawing.Point(626, 19);
            this.btnCreateSystemDirectory.Name = "btnCreateSystemDirectory";
            this.btnCreateSystemDirectory.Size = new System.Drawing.Size(85, 23);
            this.btnCreateSystemDirectory.TabIndex = 3;
            this.btnCreateSystemDirectory.Text = "Create";
            this.btnCreateSystemDirectory.UseVisualStyleBackColor = true;
            this.btnCreateSystemDirectory.Click += new System.EventHandler(this.btnCreateSystemDirectory_Click);
            // 
            // btnSearchSystemDirectory
            // 
            this.btnSearchSystemDirectory.Location = new System.Drawing.Point(544, 18);
            this.btnSearchSystemDirectory.Name = "btnSearchSystemDirectory";
            this.btnSearchSystemDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSystemDirectory.TabIndex = 2;
            this.btnSearchSystemDirectory.Text = "Search";
            this.btnSearchSystemDirectory.UseVisualStyleBackColor = true;
            this.btnSearchSystemDirectory.Click += new System.EventHandler(this.btnSearchSystemDirectory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create System Directory:";
            // 
            // txtSystemDirectory
            // 
            this.txtSystemDirectory.Location = new System.Drawing.Point(169, 19);
            this.txtSystemDirectory.Name = "txtSystemDirectory";
            this.txtSystemDirectory.Size = new System.Drawing.Size(360, 20);
            this.txtSystemDirectory.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bStart_SelectAnotateImages);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSystemFile);
            this.groupBox1.Controls.Add(this.btnSearchSystemFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Workspace";
            // 
            // bStart_SelectAnotateImages
            // 
            this.bStart_SelectAnotateImages.Location = new System.Drawing.Point(625, 30);
            this.bStart_SelectAnotateImages.Name = "bStart_SelectAnotateImages";
            this.bStart_SelectAnotateImages.Size = new System.Drawing.Size(85, 23);
            this.bStart_SelectAnotateImages.TabIndex = 9;
            this.bStart_SelectAnotateImages.Text = "Start";
            this.bStart_SelectAnotateImages.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select System File:";
            // 
            // txtSystemFile
            // 
            this.txtSystemFile.Location = new System.Drawing.Point(169, 33);
            this.txtSystemFile.Name = "txtSystemFile";
            this.txtSystemFile.Size = new System.Drawing.Size(359, 20);
            this.txtSystemFile.TabIndex = 4;
            // 
            // btnSearchSystemFile
            // 
            this.btnSearchSystemFile.Location = new System.Drawing.Point(543, 30);
            this.btnSearchSystemFile.Name = "btnSearchSystemFile";
            this.btnSearchSystemFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSystemFile.TabIndex = 5;
            this.btnSearchSystemFile.Text = "Search";
            this.btnSearchSystemFile.UseVisualStyleBackColor = true;
            this.btnSearchSystemFile.Click += new System.EventHandler(this.btnSearchSystemFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCacheDirectory);
            this.groupBox3.Controls.Add(this.btnSearchCacheDirectory);
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 81);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cache Directory:";
            // 
            // txtCacheDirectory
            // 
            this.txtCacheDirectory.Location = new System.Drawing.Point(169, 33);
            this.txtCacheDirectory.Name = "txtCacheDirectory";
            this.txtCacheDirectory.Size = new System.Drawing.Size(359, 20);
            this.txtCacheDirectory.TabIndex = 4;
            // 
            // btnSearchCacheDirectory
            // 
            this.btnSearchCacheDirectory.Location = new System.Drawing.Point(543, 30);
            this.btnSearchCacheDirectory.Name = "btnSearchCacheDirectory";
            this.btnSearchCacheDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCacheDirectory.TabIndex = 5;
            this.btnSearchCacheDirectory.Text = "Search";
            this.btnSearchCacheDirectory.UseVisualStyleBackColor = true;
            this.btnSearchCacheDirectory.Click += new System.EventHandler(this.btnSearchCacheDirectory_Click);
            // 
            // AnnotationTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 274);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AnnotationTool";
            this.Text = "Annotation Tool";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateSystemDirectory;
        private System.Windows.Forms.Button btnSearchSystemDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSystemDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bStart_SelectAnotateImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSystemFile;
        private System.Windows.Forms.Button btnSearchSystemFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCacheDirectory;
        private System.Windows.Forms.Button btnSearchCacheDirectory;
    }
}

