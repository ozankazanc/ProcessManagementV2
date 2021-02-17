
namespace ProcessManagementV2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchHostName = new System.Windows.Forms.Button();
            this.txHostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProcessList = new System.Windows.Forms.DataGridView();
            this.btnSearchSpid = new System.Windows.Forms.Button();
            this.txSpid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetBlockingQuery = new System.Windows.Forms.Button();
            this.btnGetAllProcess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txConString = new System.Windows.Forms.TextBox();
            this.btnShowConString = new System.Windows.Forms.Button();
            this.btnChangeConString = new System.Windows.Forms.Button();
            this.BtnKill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txBlockHostName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txBlockSPID = new System.Windows.Forms.TextBox();
            this.txBlockingSPID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchHostName
            // 
            this.btnSearchHostName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchHostName.Location = new System.Drawing.Point(366, 97);
            this.btnSearchHostName.Name = "btnSearchHostName";
            this.btnSearchHostName.Size = new System.Drawing.Size(187, 31);
            this.btnSearchHostName.TabIndex = 0;
            this.btnSearchHostName.Text = "Ara";
            this.btnSearchHostName.UseVisualStyleBackColor = true;
            this.btnSearchHostName.Click += new System.EventHandler(this.BtnSearchHostName_Click);
            // 
            // txHostName
            // 
            this.txHostName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txHostName.Location = new System.Drawing.Point(12, 99);
            this.txHostName.Name = "txHostName";
            this.txHostName.Size = new System.Drawing.Size(348, 29);
            this.txHostName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host_Name";
            // 
            // dgProcessList
            // 
            this.dgProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcessList.Location = new System.Drawing.Point(8, 181);
            this.dgProcessList.Name = "dgProcessList";
            this.dgProcessList.RowTemplate.Height = 25;
            this.dgProcessList.Size = new System.Drawing.Size(909, 336);
            this.dgProcessList.TabIndex = 5;
            this.dgProcessList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProcessList_CellContentClick);
            // 
            // btnSearchSpid
            // 
            this.btnSearchSpid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchSpid.Location = new System.Drawing.Point(715, 98);
            this.btnSearchSpid.Name = "btnSearchSpid";
            this.btnSearchSpid.Size = new System.Drawing.Size(202, 29);
            this.btnSearchSpid.TabIndex = 6;
            this.btnSearchSpid.Text = "Ara";
            this.btnSearchSpid.UseVisualStyleBackColor = true;
            this.btnSearchSpid.Click += new System.EventHandler(this.BtnSearchSpid_Click);
            // 
            // txSpid
            // 
            this.txSpid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSpid.Location = new System.Drawing.Point(559, 98);
            this.txSpid.Name = "txSpid";
            this.txSpid.Size = new System.Drawing.Size(145, 29);
            this.txSpid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(559, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "SPID";
            // 
            // btnGetBlockingQuery
            // 
            this.btnGetBlockingQuery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetBlockingQuery.Location = new System.Drawing.Point(289, 146);
            this.btnGetBlockingQuery.Name = "btnGetBlockingQuery";
            this.btnGetBlockingQuery.Size = new System.Drawing.Size(264, 29);
            this.btnGetBlockingQuery.TabIndex = 11;
            this.btnGetBlockingQuery.Text = "Sistemi bloklayan istek var mı?";
            this.btnGetBlockingQuery.UseVisualStyleBackColor = true;
            this.btnGetBlockingQuery.Click += new System.EventHandler(this.BtnGetBlockingQuery_Click);
            // 
            // btnGetAllProcess
            // 
            this.btnGetAllProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetAllProcess.Location = new System.Drawing.Point(12, 146);
            this.btnGetAllProcess.Name = "btnGetAllProcess";
            this.btnGetAllProcess.Size = new System.Drawing.Size(271, 29);
            this.btnGetAllProcess.TabIndex = 13;
            this.btnGetAllProcess.Text = "Bütün process\'leri getir";
            this.btnGetAllProcess.UseVisualStyleBackColor = true;
            this.btnGetAllProcess.Click += new System.EventHandler(this.BtnGetAllProcess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(780, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Process Listesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "ConnectionString (Test Amaçlı)";
            // 
            // txConString
            // 
            this.txConString.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txConString.Location = new System.Drawing.Point(12, 43);
            this.txConString.Name = "txConString";
            this.txConString.Size = new System.Drawing.Size(541, 29);
            this.txConString.TabIndex = 16;
            // 
            // btnShowConString
            // 
            this.btnShowConString.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowConString.Location = new System.Drawing.Point(715, 43);
            this.btnShowConString.Name = "btnShowConString";
            this.btnShowConString.Size = new System.Drawing.Size(204, 29);
            this.btnShowConString.TabIndex = 18;
            this.btnShowConString.Text = "Connection String\'i Göster";
            this.btnShowConString.UseVisualStyleBackColor = true;
            this.btnShowConString.Click += new System.EventHandler(this.BtnShowConString_Click);
            // 
            // btnChangeConString
            // 
            this.btnChangeConString.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeConString.Location = new System.Drawing.Point(559, 43);
            this.btnChangeConString.Name = "btnChangeConString";
            this.btnChangeConString.Size = new System.Drawing.Size(145, 29);
            this.btnChangeConString.TabIndex = 19;
            this.btnChangeConString.Text = "Değiştir";
            this.btnChangeConString.UseVisualStyleBackColor = true;
            this.btnChangeConString.Click += new System.EventHandler(this.BtnChangeConString_Click);
            // 
            // BtnKill
            // 
            this.BtnKill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnKill.Location = new System.Drawing.Point(635, 544);
            this.BtnKill.Name = "BtnKill";
            this.BtnKill.Size = new System.Drawing.Size(264, 29);
            this.BtnKill.TabIndex = 20;
            this.BtnKill.Text = "Kill Uygula";
            this.BtnKill.UseVisualStyleBackColor = true;
            this.BtnKill.Click += new System.EventHandler(this.BtnKill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Host_Name";
            // 
            // txBlockHostName
            // 
            this.txBlockHostName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBlockHostName.Location = new System.Drawing.Point(12, 544);
            this.txBlockHostName.Name = "txBlockHostName";
            this.txBlockHostName.ReadOnly = true;
            this.txBlockHostName.Size = new System.Drawing.Size(191, 29);
            this.txBlockHostName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(209, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "SPID";
            // 
            // txBlockSPID
            // 
            this.txBlockSPID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBlockSPID.Location = new System.Drawing.Point(209, 544);
            this.txBlockSPID.Name = "txBlockSPID";
            this.txBlockSPID.ReadOnly = true;
            this.txBlockSPID.Size = new System.Drawing.Size(191, 29);
            this.txBlockSPID.TabIndex = 24;
          
            // 
            // txBlockingSPID
            // 
            this.txBlockingSPID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBlockingSPID.Location = new System.Drawing.Point(406, 544);
            this.txBlockingSPID.Name = "txBlockingSPID";
            this.txBlockingSPID.ReadOnly = true;
            this.txBlockingSPID.Size = new System.Drawing.Size(191, 29);
            this.txBlockingSPID.TabIndex = 26;
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(406, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Blocking SPID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 600);
            this.Controls.Add(this.txBlockingSPID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txBlockSPID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBlockHostName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnKill);
            this.Controls.Add(this.btnChangeConString);
            this.Controls.Add(this.btnShowConString);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txConString);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetAllProcess);
            this.Controls.Add(this.btnGetBlockingQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSpid);
            this.Controls.Add(this.btnSearchSpid);
            this.Controls.Add(this.dgProcessList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txHostName);
            this.Controls.Add(this.btnSearchHostName);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnSearchHostName;
        private System.Windows.Forms.TextBox txHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProcessList;
        private System.Windows.Forms.Button btnSearchSpid;
        private System.Windows.Forms.TextBox txSpid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetBlockingQuery;
        private System.Windows.Forms.Button btnGetAllProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txConString;
        private System.Windows.Forms.Button btnShowConString;
        private System.Windows.Forms.Button btnChangeConString;

        #endregion

        private System.Windows.Forms.Button BtnKill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBlockHostName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBlockSPID;
        private System.Windows.Forms.TextBox txBlockingSPID;
        private System.Windows.Forms.Label label7;
    }
}

