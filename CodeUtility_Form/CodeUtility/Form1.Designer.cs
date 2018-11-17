using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;

namespace CodeUtility
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._scanChildDirectories = new System.Windows.Forms.CheckBox();
            this._startScan = new System.Windows.Forms.Button();
            this._scanCsharp = new System.Windows.Forms.CheckBox();
            this._scanPhp = new System.Windows.Forms.CheckBox();
            this._scanHtml = new System.Windows.Forms.CheckBox();
            this._scanCss = new System.Windows.Forms.CheckBox();
            this._scanCs = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _scanChildDirectories
            // 
            this._scanChildDirectories.AutoSize = true;
            this._scanChildDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._scanChildDirectories.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scanChildDirectories.Location = new System.Drawing.Point(608, 362);
            this._scanChildDirectories.Name = "_scanChildDirectories";
            this._scanChildDirectories.Size = new System.Drawing.Size(137, 17);
            this._scanChildDirectories.TabIndex = 0;
            this._scanChildDirectories.Text = "Scan Child Directories";
            this._scanChildDirectories.UseVisualStyleBackColor = false;
            // 
            // _startScan
            // 
            this._startScan.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._startScan.Location = new System.Drawing.Point(608, 408);
            this._startScan.Name = "_startScan";
            this._startScan.Size = new System.Drawing.Size(180, 30);
            this._startScan.TabIndex = 1;
            this._startScan.Text = "Start Scan";
            this._startScan.UseVisualStyleBackColor = true;
            // 
            // _scanCsharp
            // 
            this._scanCsharp.AutoSize = true;
            this._scanCsharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._scanCsharp.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scanCsharp.Location = new System.Drawing.Point(608, 247);
            this._scanCsharp.Name = "_scanCsharp";
            this._scanCsharp.Size = new System.Drawing.Size(80, 17);
            this._scanCsharp.TabIndex = 2;
            this._scanCsharp.Text = "Scan .html";
            this._scanCsharp.UseVisualStyleBackColor = false;
            // 
            // _scanPhp
            // 
            this._scanPhp.AutoSize = true;
            this._scanPhp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._scanPhp.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scanPhp.Location = new System.Drawing.Point(608, 270);
            this._scanPhp.Name = "_scanPhp";
            this._scanPhp.Size = new System.Drawing.Size(75, 17);
            this._scanPhp.TabIndex = 4;
            this._scanPhp.Text = "Scan .php";
            this._scanPhp.UseVisualStyleBackColor = false;
            // 
            // _scanHtml
            // 
            this._scanHtml.AutoSize = true;
            this._scanHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._scanHtml.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scanHtml.Location = new System.Drawing.Point(608, 293);
            this._scanHtml.Name = "_scanHtml";
            this._scanHtml.Size = new System.Drawing.Size(75, 17);
            this._scanHtml.TabIndex = 5;
            this._scanHtml.Text = "Scan .css";
            this._scanHtml.UseVisualStyleBackColor = false;
            // 
            // _scanCss
            // 
            this._scanCss.AutoSize = true;
            this._scanCss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._scanCss.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scanCss.Location = new System.Drawing.Point(608, 316);
            this._scanCss.Name = "_scanCss";
            this._scanCss.Size = new System.Drawing.Size(66, 17);
            this._scanCss.TabIndex = 6;
            this._scanCss.Text = "Scan .js";
            this._scanCss.UseVisualStyleBackColor = false;
            // 
            // _scanCs
            // 
            this._scanCs.AutoSize = true;
            this._scanCs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._scanCs.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scanCs.Location = new System.Drawing.Point(608, 339);
            this._scanCs.Name = "_scanCs";
            this._scanCs.Size = new System.Drawing.Size(69, 17);
            this._scanCs.TabIndex = 7;
            this._scanCs.Text = "Scan .cs";
            this._scanCs.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 440);
            this.panel1.TabIndex = 8;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(741, -3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(60, 30);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._scanCs);
            this.Controls.Add(this._scanCss);
            this.Controls.Add(this._scanHtml);
            this.Controls.Add(this._scanPhp);
            this.Controls.Add(this._scanCsharp);
            this.Controls.Add(this._startScan);
            this.Controls.Add(this._scanChildDirectories);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _scanChildDirectories;
        private System.Windows.Forms.Button _startScan;
        private System.Windows.Forms.CheckBox _scanCsharp;
        private System.Windows.Forms.CheckBox _scanPhp;
        private System.Windows.Forms.CheckBox _scanHtml;
        private System.Windows.Forms.CheckBox _scanCss;
        private System.Windows.Forms.CheckBox _scanCs;
        private System.Windows.Forms.Panel panel1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //The window dragging
        public const int wm_nclButtonDown = 0xa1;
        public const int ht_Captioin = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, wm_nclButtonDown, ht_Captioin, 0);
            }
        }


        private Button Exit;
    }
}

