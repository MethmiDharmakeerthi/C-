namespace Cylinder
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
            this.components = new System.ComponentModel.Container();
            this.topic = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxradius = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxheight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topic
            // 
            this.topic.AutoSize = true;
            this.topic.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic.Location = new System.Drawing.Point(60, 34);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(176, 20);
            this.topic.TabIndex = 0;
            this.topic.Text = "Find Cylinder Area";
            this.topic.Click += new System.EventHandler(this.topic_Click);
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radius.Location = new System.Drawing.Point(27, 85);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(110, 15);
            this.radius.TabIndex = 1;
            this.radius.Text = "*  Cylinder Radius :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxradius
            // 
            this.tbxradius.Location = new System.Drawing.Point(154, 82);
            this.tbxradius.Name = "tbxradius";
            this.tbxradius.Size = new System.Drawing.Size(100, 20);
            this.tbxradius.TabIndex = 3;
            // 
            // area
            // 
            this.area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(48, 204);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(206, 15);
            this.area.TabIndex = 4;
            this.area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxheight
            // 
            this.tbxheight.Location = new System.Drawing.Point(154, 118);
            this.tbxheight.Name = "tbxheight";
            this.tbxheight.Size = new System.Drawing.Size(100, 20);
            this.tbxheight.TabIndex = 7;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(27, 121);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(107, 15);
            this.height.TabIndex = 6;
            this.height.Text = "*  Cylinder Height :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 259);
            this.Controls.Add(this.tbxheight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.area);
            this.Controls.Add(this.tbxradius);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.topic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic;
        private System.Windows.Forms.Label radius;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbxradius;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxheight;
        private System.Windows.Forms.Label height;
    }
}

