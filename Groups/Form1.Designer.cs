namespace Groups
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            this.FrontBtn = new System.Windows.Forms.Button();
            this.NextBttn = new System.Windows.Forms.Button();
            this.TopBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.dataSet1 = new Groups.DataSet1();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Groups.DataSet1TableAdapters.GroupsTableAdapter();
            this.tableAdapterManager = new Groups.DataSet1TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FrontBtn
            // 
            this.FrontBtn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FrontBtn.Location = new System.Drawing.Point(24, 125);
            this.FrontBtn.Name = "FrontBtn";
            this.FrontBtn.Size = new System.Drawing.Size(75, 48);
            this.FrontBtn.TabIndex = 0;
            this.FrontBtn.Text = "前へ";
            this.FrontBtn.UseVisualStyleBackColor = true;
            this.FrontBtn.Click += new System.EventHandler(this.FrontBtn_Click);
            // 
            // NextBttn
            // 
            this.NextBttn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NextBttn.Location = new System.Drawing.Point(120, 125);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(75, 48);
            this.NextBttn.TabIndex = 1;
            this.NextBttn.Text = "次へ";
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // TopBtn
            // 
            this.TopBtn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TopBtn.Location = new System.Drawing.Point(218, 125);
            this.TopBtn.Name = "TopBtn";
            this.TopBtn.Size = new System.Drawing.Size(88, 48);
            this.TopBtn.TabIndex = 2;
            this.TopBtn.Text = "先頭へ";
            this.TopBtn.UseVisualStyleBackColor = true;
            this.TopBtn.Click += new System.EventHandler(this.TopBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndBtn.Location = new System.Drawing.Point(332, 125);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(90, 48);
            this.EndBtn.TabIndex = 3;
            this.EndBtn.Text = "最後へ";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FinishBtn.Location = new System.Drawing.Point(347, 192);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(75, 48);
            this.FinishBtn.TabIndex = 4;
            this.FinishBtn.Text = "終了";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.dataSet1;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Groups.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            idLabel.Location = new System.Drawing.Point(30, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(84, 22);
            idLabel.TabIndex = 5;
            idLabel.Text = "所属ID：";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTextBox.Location = new System.Drawing.Point(120, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(186, 29);
            this.idTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            nameLabel.Location = new System.Drawing.Point(38, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 22);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "名前：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameTextBox.Location = new System.Drawing.Point(120, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(186, 29);
            this.nameTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 254);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.TopBtn);
            this.Controls.Add(this.NextBttn);
            this.Controls.Add(this.FrontBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FrontBtn;
        private System.Windows.Forms.Button NextBttn;
        private System.Windows.Forms.Button TopBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button FinishBtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private DataSet1TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

