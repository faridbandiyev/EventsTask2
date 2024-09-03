namespace Events
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMainAccountBalance = new System.Windows.Forms.TextBox();
            this.txtMainAccountWithdrawValue = new System.Windows.Forms.TextBox();
            this.txtMainAccountDepositValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSecondAccountBalance = new System.Windows.Forms.TextBox();
            this.txtSecondAccountDepositValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecondAccountWithdrawValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMainAccountDeposit = new System.Windows.Forms.Button();
            this.btnMainAccountWithdraw = new System.Windows.Forms.Button();
            this.btnSecondAccountWithdraw = new System.Windows.Forms.Button();
            this.btnSecondAccountDeposit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balans:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Məxaric:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mədaxil:";
            // 
            // txtMainAccountBalance
            // 
            this.txtMainAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMainAccountBalance.Location = new System.Drawing.Point(149, 54);
            this.txtMainAccountBalance.Name = "txtMainAccountBalance";
            this.txtMainAccountBalance.Size = new System.Drawing.Size(100, 30);
            this.txtMainAccountBalance.TabIndex = 3;
            // 
            // txtMainAccountWithdrawValue
            // 
            this.txtMainAccountWithdrawValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMainAccountWithdrawValue.Location = new System.Drawing.Point(149, 142);
            this.txtMainAccountWithdrawValue.Name = "txtMainAccountWithdrawValue";
            this.txtMainAccountWithdrawValue.Size = new System.Drawing.Size(100, 30);
            this.txtMainAccountWithdrawValue.TabIndex = 4;
            // 
            // txtMainAccountDepositValue
            // 
            this.txtMainAccountDepositValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMainAccountDepositValue.Location = new System.Drawing.Point(149, 98);
            this.txtMainAccountDepositValue.Name = "txtMainAccountDepositValue";
            this.txtMainAccountDepositValue.Size = new System.Drawing.Size(100, 30);
            this.txtMainAccountDepositValue.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMainAccountBalance);
            this.groupBox1.Controls.Add(this.txtMainAccountDepositValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMainAccountWithdrawValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 191);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Əsas hesab";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSecondAccountBalance);
            this.groupBox2.Controls.Add(this.txtSecondAccountDepositValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSecondAccountWithdrawValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(24, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 191);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ehtiyyat hesab";
            // 
            // txtSecondAccountBalance
            // 
            this.txtSecondAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondAccountBalance.Location = new System.Drawing.Point(149, 54);
            this.txtSecondAccountBalance.Name = "txtSecondAccountBalance";
            this.txtSecondAccountBalance.Size = new System.Drawing.Size(100, 30);
            this.txtSecondAccountBalance.TabIndex = 3;
            // 
            // txtSecondAccountDepositValue
            // 
            this.txtSecondAccountDepositValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondAccountDepositValue.Location = new System.Drawing.Point(149, 98);
            this.txtSecondAccountDepositValue.Name = "txtSecondAccountDepositValue";
            this.txtSecondAccountDepositValue.Size = new System.Drawing.Size(100, 30);
            this.txtSecondAccountDepositValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balans:";
            // 
            // txtSecondAccountWithdrawValue
            // 
            this.txtSecondAccountWithdrawValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondAccountWithdrawValue.Location = new System.Drawing.Point(149, 142);
            this.txtSecondAccountWithdrawValue.Name = "txtSecondAccountWithdrawValue";
            this.txtSecondAccountWithdrawValue.Size = new System.Drawing.Size(100, 30);
            this.txtSecondAccountWithdrawValue.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Məxaric:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mədaxil:";
            // 
            // btnMainAccountDeposit
            // 
            this.btnMainAccountDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainAccountDeposit.Location = new System.Drawing.Point(390, 62);
            this.btnMainAccountDeposit.Name = "btnMainAccountDeposit";
            this.btnMainAccountDeposit.Size = new System.Drawing.Size(218, 52);
            this.btnMainAccountDeposit.TabIndex = 8;
            this.btnMainAccountDeposit.Text = "Mədaxil";
            this.btnMainAccountDeposit.UseVisualStyleBackColor = true;
            this.btnMainAccountDeposit.Click += new System.EventHandler(this.btnMainAccountDeposit_Click);
            // 
            // btnMainAccountWithdraw
            // 
            this.btnMainAccountWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainAccountWithdraw.Location = new System.Drawing.Point(390, 129);
            this.btnMainAccountWithdraw.Name = "btnMainAccountWithdraw";
            this.btnMainAccountWithdraw.Size = new System.Drawing.Size(218, 52);
            this.btnMainAccountWithdraw.TabIndex = 9;
            this.btnMainAccountWithdraw.Text = "Məxaric";
            this.btnMainAccountWithdraw.UseVisualStyleBackColor = true;
            this.btnMainAccountWithdraw.Click += new System.EventHandler(this.btnMainAccountWithdraw_Click);
            // 
            // btnSecondAccountWithdraw
            // 
            this.btnSecondAccountWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSecondAccountWithdraw.Location = new System.Drawing.Point(390, 356);
            this.btnSecondAccountWithdraw.Name = "btnSecondAccountWithdraw";
            this.btnSecondAccountWithdraw.Size = new System.Drawing.Size(218, 52);
            this.btnSecondAccountWithdraw.TabIndex = 11;
            this.btnSecondAccountWithdraw.Text = "Məxaric";
            this.btnSecondAccountWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnSecondAccountDeposit
            // 
            this.btnSecondAccountDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSecondAccountDeposit.Location = new System.Drawing.Point(390, 289);
            this.btnSecondAccountDeposit.Name = "btnSecondAccountDeposit";
            this.btnSecondAccountDeposit.Size = new System.Drawing.Size(218, 52);
            this.btnSecondAccountDeposit.TabIndex = 10;
            this.btnSecondAccountDeposit.Text = "Mədaxil";
            this.btnSecondAccountDeposit.UseVisualStyleBackColor = true;
            this.btnSecondAccountDeposit.Click += new System.EventHandler(this.btnSecondAccountDeposit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.btnSecondAccountWithdraw);
            this.Controls.Add(this.btnSecondAccountDeposit);
            this.Controls.Add(this.btnMainAccountWithdraw);
            this.Controls.Add(this.btnMainAccountDeposit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMainAccountBalance;
        private System.Windows.Forms.TextBox txtMainAccountWithdrawValue;
        private System.Windows.Forms.TextBox txtMainAccountDepositValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSecondAccountBalance;
        private System.Windows.Forms.TextBox txtSecondAccountDepositValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondAccountWithdrawValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMainAccountDeposit;
        private System.Windows.Forms.Button btnMainAccountWithdraw;
        private System.Windows.Forms.Button btnSecondAccountWithdraw;
        private System.Windows.Forms.Button btnSecondAccountDeposit;
    }
}

