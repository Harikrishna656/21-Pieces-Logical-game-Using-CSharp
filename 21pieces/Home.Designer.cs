
namespace _21pieces
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_sp = new System.Windows.Forms.Button();
            this.btn_mlp = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sp
            // 
            this.btn_sp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sp.Font = new System.Drawing.Font("BatmanForeverAlternate", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp.Location = new System.Drawing.Point(212, 52);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Size = new System.Drawing.Size(243, 42);
            this.btn_sp.TabIndex = 0;
            this.btn_sp.Text = "Single Player";
            this.btn_sp.UseVisualStyleBackColor = false;
            this.btn_sp.Click += new System.EventHandler(this.btn_sp_Click);
            // 
            // btn_mlp
            // 
            this.btn_mlp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_mlp.Font = new System.Drawing.Font("BatmanForeverAlternate", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mlp.Location = new System.Drawing.Point(232, 116);
            this.btn_mlp.Name = "btn_mlp";
            this.btn_mlp.Size = new System.Drawing.Size(211, 42);
            this.btn_mlp.TabIndex = 1;
            this.btn_mlp.Text = "Multi Player";
            this.btn_mlp.UseVisualStyleBackColor = false;
            this.btn_mlp.Click += new System.EventHandler(this.btn_mlp_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_help.Font = new System.Drawing.Font("BatmanForeverAlternate", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(269, 187);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(132, 42);
            this.btn_help.TabIndex = 2;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("BatmanForeverAlternate", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(269, 265);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(132, 42);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 362);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_mlp);
            this.Controls.Add(this.btn_sp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sp;
        private System.Windows.Forms.Button btn_mlp;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_exit;
    }
}

