using System;
using System.Drawing;
using System.Windows.Forms;

namespace AI_Emporium
{
    partial class home : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Panel menuPanel;
        private Button menuButton1;
        private Button menuButton2;
        private Button menuButton3;
        private Button menuButton4;

        private Panel componentsPanel;
        private Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuButton1 = new System.Windows.Forms.Button();
            this.menuButton2 = new System.Windows.Forms.Button();
            this.menuButton3 = new System.Windows.Forms.Button();
            this.menuButton4 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.componentsPanel = new System.Windows.Forms.Panel();
            this.miLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.componentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuPanel.Controls.Add(this.menuButton1);
            this.menuPanel.Controls.Add(this.menuButton2);
            this.menuPanel.Controls.Add(this.menuButton3);
            this.menuPanel.Controls.Add(this.menuButton4);
            this.menuPanel.Controls.Add(this.titleLabel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 480);
            this.menuPanel.TabIndex = 5;
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.menuButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton1.FlatAppearance.BorderSize = 0;
            this.menuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.menuButton1.Location = new System.Drawing.Point(0, 340);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuButton1.Size = new System.Drawing.Size(200, 80);
            this.menuButton1.TabIndex = 0;
            this.menuButton1.Text = "Opción 1";
            this.menuButton1.UseVisualStyleBackColor = false;
            this.menuButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // menuButton2
            // 
            this.menuButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.menuButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton2.FlatAppearance.BorderSize = 0;
            this.menuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.menuButton2.Location = new System.Drawing.Point(0, 260);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuButton2.Size = new System.Drawing.Size(200, 80);
            this.menuButton2.TabIndex = 1;
            this.menuButton2.Text = "Opción 2";
            this.menuButton2.UseVisualStyleBackColor = false;
            this.menuButton2.Click += new System.EventHandler(this.menuButton2_Click);
            // 
            // menuButton3
            // 
            this.menuButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.menuButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton3.FlatAppearance.BorderSize = 0;
            this.menuButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.menuButton3.Location = new System.Drawing.Point(0, 180);
            this.menuButton3.Name = "menuButton3";
            this.menuButton3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuButton3.Size = new System.Drawing.Size(200, 80);
            this.menuButton3.TabIndex = 2;
            this.menuButton3.Text = "Opción 3";
            this.menuButton3.UseVisualStyleBackColor = false;
            this.menuButton3.Click += new System.EventHandler(this.menuButton3_Click);
            // 
            // menuButton4
            // 
            this.menuButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.menuButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton4.FlatAppearance.BorderSize = 0;
            this.menuButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.menuButton4.Location = new System.Drawing.Point(0, 100);
            this.menuButton4.Name = "menuButton4";
            this.menuButton4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuButton4.Size = new System.Drawing.Size(200, 80);
            this.menuButton4.TabIndex = 3;
            this.menuButton4.Text = "Opción 4";
            this.menuButton4.UseVisualStyleBackColor = false;
            this.menuButton4.Click += new System.EventHandler(this.menuButton4_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.titleLabel.Size = new System.Drawing.Size(200, 100);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "AI Emporium";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // componentsPanel
            // 
            this.componentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.componentsPanel.Controls.Add(this.miLabel);
            this.componentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentsPanel.Location = new System.Drawing.Point(200, 0);
            this.componentsPanel.Name = "componentsPanel";
            this.componentsPanel.Size = new System.Drawing.Size(600, 480);
            this.componentsPanel.TabIndex = 6;
            // 
            // miLabel
            // 
            this.miLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.miLabel.ForeColor = System.Drawing.Color.White;
            this.miLabel.Location = new System.Drawing.Point(150, 20);
            this.miLabel.Name = "miLabel";
            this.miLabel.Size = new System.Drawing.Size(245, 23);
            this.miLabel.TabIndex = 0;
            this.miLabel.Text = "desarrollo de software";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.componentsPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "home";
            this.Text = "AI Emporium";
            this.menuPanel.ResumeLayout(false);
            this.componentsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label miLabel;
    }
}