
namespace _21pieces
{
    partial class single_play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(single_play));
            this.text_you = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_remain = new System.Windows.Forms.Label();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.lbl_dis = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_take = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // text_you
            // 
            this.text_you.Location = new System.Drawing.Point(37, 166);
            this.text_you.Name = "text_you";
            this.text_you.Size = new System.Drawing.Size(133, 20);
            this.text_you.TabIndex = 0;
            this.text_you.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_you.TextChanged += new System.EventHandler(this.text_you_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computer takes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remaining sticks";
            // 
            // lbl_remain
            // 
            this.lbl_remain.AutoSize = true;
            this.lbl_remain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_remain.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remain.Location = new System.Drawing.Point(392, 48);
            this.lbl_remain.Name = "lbl_remain";
            this.lbl_remain.Size = new System.Drawing.Size(32, 24);
            this.lbl_remain.TabIndex = 8;
            this.lbl_remain.Text = "21";
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.BackColor = System.Drawing.Color.Silver;
            this.lbl_comp.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comp.Location = new System.Drawing.Point(539, 161);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(21, 24);
            this.lbl_comp.TabIndex = 9;
            this.lbl_comp.Text = "0";
            // 
            // lbl_dis
            // 
            this.lbl_dis.AutoSize = true;
            this.lbl_dis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dis.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis.Location = new System.Drawing.Point(295, 161);
            this.lbl_dis.Name = "lbl_dis";
            this.lbl_dis.Size = new System.Drawing.Size(46, 24);
            this.lbl_dis.TabIndex = 10;
            this.lbl_dis.Text = "safe";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Close.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(501, 318);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(121, 32);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_take
            // 
            this.btn_take.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_take.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_take.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_take.Location = new System.Drawing.Point(252, 242);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(128, 58);
            this.btn_take.TabIndex = 12;
            this.btn_take.Text = "Take";
            this.btn_take.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_take.UseVisualStyleBackColor = false;
            this.btn_take.CheckedChanged += new System.EventHandler(this.btn_take_CheckedChanged);
            // 
            // single_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 362);
            this.Controls.Add(this.btn_take);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_dis);
            this.Controls.Add(this.lbl_comp);
            this.Controls.Add(this.lbl_remain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_you);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "single_play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Player";
            this.Load += new System.EventHandler(this.single_play_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_you;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_remain;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.Label lbl_dis;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.CheckBox btn_take;
    }
}