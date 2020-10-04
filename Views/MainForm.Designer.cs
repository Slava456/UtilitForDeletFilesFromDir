namespace UtilitForDeletFileFromDirs.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGo = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.pnlDropDir = new System.Windows.Forms.Panel();
            this.lblDir = new System.Windows.Forms.Label();
            this.pnlDropOut = new System.Windows.Forms.Panel();
            this.lblDirForControl = new System.Windows.Forms.Label();
            this.dgvTargetFiles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btClearDir = new System.Windows.Forms.Button();
            this.btClearDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(326, 183);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "Старт";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(12, 20);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(135, 13);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "Введите название файла";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 145);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(389, 23);
            this.pb.TabIndex = 3;
            // 
            // pnlDropDir
            // 
            this.pnlDropDir.AllowDrop = true;
            this.pnlDropDir.BackColor = System.Drawing.Color.White;
            this.pnlDropDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDropDir.Location = new System.Drawing.Point(204, 36);
            this.pnlDropDir.Name = "pnlDropDir";
            this.pnlDropDir.Size = new System.Drawing.Size(93, 26);
            this.pnlDropDir.TabIndex = 4;
            this.pnlDropDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDropDir_DragDrop);
            this.pnlDropDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDropDir_DragEnter);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(201, 20);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(84, 13);
            this.lblDir.TabIndex = 5;
            this.lblDir.Text = "Укажите папку";
            // 
            // pnlDropOut
            // 
            this.pnlDropOut.AllowDrop = true;
            this.pnlDropOut.BackColor = System.Drawing.Color.White;
            this.pnlDropOut.Location = new System.Drawing.Point(321, 36);
            this.pnlDropOut.Name = "pnlDropOut";
            this.pnlDropOut.Size = new System.Drawing.Size(80, 26);
            this.pnlDropOut.TabIndex = 6;
            this.pnlDropOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDropOut_DragDrop);
            this.pnlDropOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDropOut_DragEnter);
            // 
            // lblDirForControl
            // 
            this.lblDirForControl.AutoSize = true;
            this.lblDirForControl.Location = new System.Drawing.Point(291, 20);
            this.lblDirForControl.Name = "lblDirForControl";
            this.lblDirForControl.Size = new System.Drawing.Size(110, 13);
            this.lblDirForControl.TabIndex = 7;
            this.lblDirForControl.Text = "Папка для контроля";
            // 
            // dgvTargetFiles
            // 
            this.dgvTargetFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTargetFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTargetFiles.Location = new System.Drawing.Point(12, 39);
            this.dgvTargetFiles.Name = "dgvTargetFiles";
            this.dgvTargetFiles.RowHeadersVisible = false;
            this.dgvTargetFiles.Size = new System.Drawing.Size(186, 100);
            this.dgvTargetFiles.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Файлы";
            this.Column1.Name = "Column1";
            // 
            // btClearDir
            // 
            this.btClearDir.Location = new System.Drawing.Point(12, 183);
            this.btClearDir.Name = "btClearDir";
            this.btClearDir.Size = new System.Drawing.Size(118, 23);
            this.btClearDir.TabIndex = 9;
            this.btClearDir.Text = "Сбросить папки";
            this.btClearDir.UseVisualStyleBackColor = true;
            this.btClearDir.Click += new System.EventHandler(this.btClearDir_Click);
            // 
            // btClearDGV
            // 
            this.btClearDGV.Location = new System.Drawing.Point(136, 183);
            this.btClearDGV.Name = "btClearDGV";
            this.btClearDGV.Size = new System.Drawing.Size(105, 23);
            this.btClearDGV.TabIndex = 10;
            this.btClearDGV.Text = "Сбросить файлы";
            this.btClearDGV.UseVisualStyleBackColor = true;
            this.btClearDGV.Click += new System.EventHandler(this.btClearDGV_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.btClearDGV);
            this.Controls.Add(this.btClearDir);
            this.Controls.Add(this.dgvTargetFiles);
            this.Controls.Add(this.lblDirForControl);
            this.Controls.Add(this.pnlDropOut);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.pnlDropDir);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.btGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление файла";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Panel pnlDropDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Panel pnlDropOut;
        private System.Windows.Forms.Label lblDirForControl;
        private System.Windows.Forms.DataGridView dgvTargetFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btClearDir;
        private System.Windows.Forms.Button btClearDGV;
        private System.Windows.Forms.ProgressBar pb;
    }
}

