namespace QL_DT_LK.View
{
    partial class k_mean
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInitializeCluster = new System.Windows.Forms.Button();
            this.btnFindTheResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tfNumberOfCluster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 627);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnInitializeCluster
            // 
            this.btnInitializeCluster.Location = new System.Drawing.Point(854, 55);
            this.btnInitializeCluster.Name = "btnInitializeCluster";
            this.btnInitializeCluster.Size = new System.Drawing.Size(183, 23);
            this.btnInitializeCluster.TabIndex = 15;
            this.btnInitializeCluster.Text = "Khởi tạo khu vực tự động";
            this.btnInitializeCluster.UseVisualStyleBackColor = true;
            this.btnInitializeCluster.Click += new System.EventHandler(this.btnInitializeCluster_Click);
            // 
            // btnFindTheResult
            // 
            this.btnFindTheResult.Location = new System.Drawing.Point(854, 99);
            this.btnFindTheResult.Name = "btnFindTheResult";
            this.btnFindTheResult.Size = new System.Drawing.Size(183, 23);
            this.btnFindTheResult.TabIndex = 22;
            this.btnFindTheResult.Text = "Tìm kết quả";
            this.btnFindTheResult.UseVisualStyleBackColor = true;
            this.btnFindTheResult.Click += new System.EventHandler(this.btnFindTheResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số lượng khu vực :";
            // 
            // tfNumberOfCluster
            // 
            this.tfNumberOfCluster.Location = new System.Drawing.Point(991, 19);
            this.tfNumberOfCluster.Name = "tfNumberOfCluster";
            this.tfNumberOfCluster.Size = new System.Drawing.Size(39, 20);
            this.tfNumberOfCluster.TabIndex = 20;
            this.tfNumberOfCluster.Text = "4";
            this.tfNumberOfCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // k_mean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInitializeCluster);
            this.Controls.Add(this.btnFindTheResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfNumberOfCluster);
            this.Name = "k_mean";
            this.Text = "k_mean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInitializeCluster;
        private System.Windows.Forms.Button btnFindTheResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfNumberOfCluster;
    }
}