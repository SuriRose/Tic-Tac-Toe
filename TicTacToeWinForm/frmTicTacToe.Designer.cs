namespace TicTacToeWinForm
{
    partial class frmTicTacToe
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.opt1Player = new System.Windows.Forms.RadioButton();
            this.opt2Players = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.tblOptionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tblMain.SuspendLayout();
            this.tblOptionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Controls.Add(this.btnStart, 0, 0);
            this.tblMain.Controls.Add(this.btn1, 0, 1);
            this.tblMain.Controls.Add(this.btn2, 1, 1);
            this.tblMain.Controls.Add(this.btn3, 2, 1);
            this.tblMain.Controls.Add(this.btn4, 0, 2);
            this.tblMain.Controls.Add(this.btn5, 1, 2);
            this.tblMain.Controls.Add(this.btn6, 2, 2);
            this.tblMain.Controls.Add(this.btn7, 0, 3);
            this.tblMain.Controls.Add(this.btn8, 1, 3);
            this.tblMain.Controls.Add(this.btn9, 2, 3);
            this.tblMain.Controls.Add(this.lblMessage, 1, 0);
            this.tblMain.Controls.Add(this.lblPlayer, 2, 0);
            this.tblMain.Controls.Add(this.tblOptionButtons, 0, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.Size = new System.Drawing.Size(565, 488);
            this.tblMain.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 67);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(3, 76);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(182, 116);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(191, 76);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(182, 116);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(379, 76);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(183, 116);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(3, 198);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(182, 116);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(191, 198);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(182, 116);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(379, 198);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(183, 116);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(3, 320);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(182, 116);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(191, 320);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(182, 116);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(379, 320);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(183, 116);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // opt1Player
            // 
            this.opt1Player.AutoSize = true;
            this.opt1Player.Checked = true;
            this.opt1Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opt1Player.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opt1Player.Location = new System.Drawing.Point(3, 3);
            this.opt1Player.Name = "opt1Player";
            this.opt1Player.Size = new System.Drawing.Size(252, 37);
            this.opt1Player.TabIndex = 10;
            this.opt1Player.TabStop = true;
            this.opt1Player.Text = "Play Against the Computer";
            this.opt1Player.UseVisualStyleBackColor = true;
            // 
            // opt2Players
            // 
            this.opt2Players.AutoSize = true;
            this.opt2Players.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opt2Players.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opt2Players.Location = new System.Drawing.Point(261, 3);
            this.opt2Players.Name = "opt2Players";
            this.opt2Players.Size = new System.Drawing.Size(295, 37);
            this.opt2Players.TabIndex = 11;
            this.opt2Players.Text = "2 Players";
            this.opt2Players.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(191, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(182, 73);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.Location = new System.Drawing.Point(379, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(183, 73);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblOptionButtons
            // 
            this.tblOptionButtons.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tblOptionButtons, 3);
            this.tblOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOptionButtons.Controls.Add(this.opt2Players, 1, 0);
            this.tblOptionButtons.Controls.Add(this.opt1Player, 0, 0);
            this.tblOptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOptionButtons.Location = new System.Drawing.Point(3, 442);
            this.tblOptionButtons.Name = "tblOptionButtons";
            this.tblOptionButtons.RowCount = 1;
            this.tblOptionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOptionButtons.Size = new System.Drawing.Size(559, 43);
            this.tblOptionButtons.TabIndex = 14;
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 488);
            this.Controls.Add(this.tblMain);
            this.Name = "frmTicTacToe";
            this.Text = "TicTacToe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblOptionButtons.ResumeLayout(false);
            this.tblOptionButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnStart;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private RadioButton opt1Player;
        private RadioButton opt2Players;
        private Label lblMessage;
        private Label lblPlayer;
        private TableLayoutPanel tblOptionButtons;
    }
}