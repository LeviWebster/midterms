namespace midterms
{
    partial class frmMain
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
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.box_savings = new System.Windows.Forms.CheckBox();
            this.box_checking = new System.Windows.Forms.CheckBox();
            this.lbl_transferAmount = new System.Windows.Forms.Label();
            this.txt_transferAmount = new System.Windows.Forms.TextBox();
            this.lbl_accountType = new System.Windows.Forms.Label();
            this.btn_actionsubmit = new System.Windows.Forms.Button();
            this.lbl_transfer = new System.Windows.Forms.Label();
            this.lbl_withdraw = new System.Windows.Forms.Label();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_showpass = new System.Windows.Forms.Label();
            this.lbl_logininpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(12, 333);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(125, 27);
            this.txt_cost.TabIndex = 0;
            this.txt_cost.TextChanged += new System.EventHandler(this.txt_cost_TextChanged);
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(143, 340);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(125, 20);
            this.lbl_deposit.TabIndex = 3;
            this.lbl_deposit.Text = "withdraw amount";
            // 
            // box_savings
            // 
            this.box_savings.AutoSize = true;
            this.box_savings.Location = new System.Drawing.Point(12, 184);
            this.box_savings.Name = "box_savings";
            this.box_savings.Size = new System.Drawing.Size(79, 24);
            this.box_savings.TabIndex = 4;
            this.box_savings.Text = "savings";
            this.box_savings.UseVisualStyleBackColor = true;
            this.box_savings.CheckedChanged += new System.EventHandler(this.box_savings_CheckedChanged);
            // 
            // box_checking
            // 
            this.box_checking.AutoSize = true;
            this.box_checking.Location = new System.Drawing.Point(12, 214);
            this.box_checking.Name = "box_checking";
            this.box_checking.Size = new System.Drawing.Size(89, 24);
            this.box_checking.TabIndex = 5;
            this.box_checking.Text = "checking";
            this.box_checking.UseVisualStyleBackColor = true;
            this.box_checking.CheckedChanged += new System.EventHandler(this.box_checking_CheckedChanged);
            // 
            // lbl_transferAmount
            // 
            this.lbl_transferAmount.AutoSize = true;
            this.lbl_transferAmount.Location = new System.Drawing.Point(143, 287);
            this.lbl_transferAmount.Name = "lbl_transferAmount";
            this.lbl_transferAmount.Size = new System.Drawing.Size(114, 20);
            this.lbl_transferAmount.TabIndex = 7;
            this.lbl_transferAmount.Text = "transfer amount";
            // 
            // txt_transferAmount
            // 
            this.txt_transferAmount.Location = new System.Drawing.Point(12, 280);
            this.txt_transferAmount.Name = "txt_transferAmount";
            this.txt_transferAmount.Size = new System.Drawing.Size(125, 27);
            this.txt_transferAmount.TabIndex = 9;
            this.txt_transferAmount.TextChanged += new System.EventHandler(this.txt_transferAmount_TextChanged);
            // 
            // lbl_accountType
            // 
            this.lbl_accountType.AutoSize = true;
            this.lbl_accountType.Location = new System.Drawing.Point(7, 161);
            this.lbl_accountType.Name = "lbl_accountType";
            this.lbl_accountType.Size = new System.Drawing.Size(94, 20);
            this.lbl_accountType.TabIndex = 10;
            this.lbl_accountType.Text = "account type";
            // 
            // btn_actionsubmit
            // 
            this.btn_actionsubmit.Location = new System.Drawing.Point(286, 340);
            this.btn_actionsubmit.Name = "btn_actionsubmit";
            this.btn_actionsubmit.Size = new System.Drawing.Size(94, 29);
            this.btn_actionsubmit.TabIndex = 11;
            this.btn_actionsubmit.Text = "withdraw ";
            this.btn_actionsubmit.UseVisualStyleBackColor = true;
            this.btn_actionsubmit.Click += new System.EventHandler(this.btn_actionsubmit_Click);
            // 
            // lbl_transfer
            // 
            this.lbl_transfer.AutoSize = true;
            this.lbl_transfer.Location = new System.Drawing.Point(32, 257);
            this.lbl_transfer.Name = "lbl_transfer";
            this.lbl_transfer.Size = new System.Drawing.Size(91, 20);
            this.lbl_transfer.TabIndex = 12;
            this.lbl_transfer.Text = "Transfer info";
            // 
            // lbl_withdraw
            // 
            this.lbl_withdraw.AutoSize = true;
            this.lbl_withdraw.Location = new System.Drawing.Point(32, 310);
            this.lbl_withdraw.Name = "lbl_withdraw";
            this.lbl_withdraw.Size = new System.Drawing.Size(100, 20);
            this.lbl_withdraw.TabIndex = 13;
            this.lbl_withdraw.Text = "withdraw info";
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(286, 287);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(94, 29);
            this.btn_transfer.TabIndex = 14;
            this.btn_transfer.Text = "transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(56, 24);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_id.TabIndex = 15;
            // 
            // lbl_showpass
            // 
            this.lbl_showpass.AutoSize = true;
            this.lbl_showpass.Location = new System.Drawing.Point(625, 49);
            this.lbl_showpass.Name = "lbl_showpass";
            this.lbl_showpass.Size = new System.Drawing.Size(13, 20);
            this.lbl_showpass.TabIndex = 16;
            this.lbl_showpass.Text = " ";
            // 
            // lbl_logininpass
            // 
            this.lbl_logininpass.AutoSize = true;
            this.lbl_logininpass.Location = new System.Drawing.Point(625, 9);
            this.lbl_logininpass.Name = "lbl_logininpass";
            this.lbl_logininpass.Size = new System.Drawing.Size(72, 20);
            this.lbl_logininpass.TabIndex = 17;
            this.lbl_logininpass.Text = "password";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_logininpass);
            this.Controls.Add(this.lbl_showpass);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.lbl_withdraw);
            this.Controls.Add(this.lbl_transfer);
            this.Controls.Add(this.btn_actionsubmit);
            this.Controls.Add(this.lbl_accountType);
            this.Controls.Add(this.txt_transferAmount);
            this.Controls.Add(this.lbl_transferAmount);
            this.Controls.Add(this.box_checking);
            this.Controls.Add(this.box_savings);
            this.Controls.Add(this.lbl_deposit);
            this.Controls.Add(this.txt_cost);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_cost;
        private Label lbl_deposit;
        private CheckBox box_savings;
        private CheckBox box_checking;
        private Label lbl_transferAmount;
        private TextBox txt_transferAmount;
        private Label lbl_accountType;
        private Button btn_actionsubmit;
        private Label lbl_transfer;
        private Label lbl_withdraw;
        private Button btn_transfer;
        private Label lbl_id;
        private Label lbl_showpass;
        private Label lbl_logininpass;
    }
}