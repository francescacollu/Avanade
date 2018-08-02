namespace ImageViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bottoneChiudi = new System.Windows.Forms.Button();
            this.bottoneSfondo = new System.Windows.Forms.Button();
            this.bottoneCancella = new System.Windows.Forms.Button();
            this.bottoneVisualizza = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 271);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(3, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Adatta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bottoneChiudi);
            this.flowLayoutPanel1.Controls.Add(this.bottoneSfondo);
            this.flowLayoutPanel1.Controls.Add(this.bottoneCancella);
            this.flowLayoutPanel1.Controls.Add(this.bottoneVisualizza);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(92, 280);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 25);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bottoneChiudi
            // 
            this.bottoneChiudi.AutoSize = true;
            this.bottoneChiudi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottoneChiudi.Location = new System.Drawing.Point(3, 3);
            this.bottoneChiudi.Name = "bottoneChiudi";
            this.bottoneChiudi.Size = new System.Drawing.Size(64, 23);
            this.bottoneChiudi.TabIndex = 0;
            this.bottoneChiudi.Text = "Chiudi";
            this.bottoneChiudi.UseVisualStyleBackColor = true;
            this.bottoneChiudi.Click += new System.EventHandler(this.bottoneChiudi_Click);
            // 
            // bottoneSfondo
            // 
            this.bottoneSfondo.AutoSize = true;
            this.bottoneSfondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottoneSfondo.Location = new System.Drawing.Point(73, 3);
            this.bottoneSfondo.Name = "bottoneSfondo";
            this.bottoneSfondo.Size = new System.Drawing.Size(159, 23);
            this.bottoneSfondo.TabIndex = 1;
            this.bottoneSfondo.Text = "Imposta colore di sfondo";
            this.bottoneSfondo.UseVisualStyleBackColor = true;
            this.bottoneSfondo.Click += new System.EventHandler(this.bottoneSfondo_Click);
            // 
            // bottoneCancella
            // 
            this.bottoneCancella.AutoSize = true;
            this.bottoneCancella.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottoneCancella.Location = new System.Drawing.Point(238, 3);
            this.bottoneCancella.Name = "bottoneCancella";
            this.bottoneCancella.Size = new System.Drawing.Size(119, 23);
            this.bottoneCancella.TabIndex = 2;
            this.bottoneCancella.Text = "Cancella immagine";
            this.bottoneCancella.UseVisualStyleBackColor = true;
            this.bottoneCancella.Click += new System.EventHandler(this.bottoneCancella_Click);
            // 
            // bottoneVisualizza
            // 
            this.bottoneVisualizza.AutoSize = true;
            this.bottoneVisualizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottoneVisualizza.Location = new System.Drawing.Point(363, 3);
            this.bottoneVisualizza.Name = "bottoneVisualizza";
            this.bottoneVisualizza.Size = new System.Drawing.Size(131, 23);
            this.bottoneVisualizza.TabIndex = 3;
            this.bottoneVisualizza.Text = "Visualizza immagine";
            this.bottoneVisualizza.UseVisualStyleBackColor = true;
            this.bottoneVisualizza.Click += new System.EventHandler(this.bottoneVisualizza_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.* ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(595, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bottoneChiudi;
        private System.Windows.Forms.Button bottoneSfondo;
        private System.Windows.Forms.Button bottoneCancella;
        private System.Windows.Forms.Button bottoneVisualizza;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

