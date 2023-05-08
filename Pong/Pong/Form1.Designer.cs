
namespace Pong
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
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player1_score = new System.Windows.Forms.Label();
            this.player2_score = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.quit_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(78, 179);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(20, 100);
            this.player1.TabIndex = 0;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(597, 179);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(20, 100);
            this.player2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(337, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(337, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(337, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(337, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(337, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(337, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 10;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(335, 215);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player1_score
            // 
            this.player1_score.AutoSize = true;
            this.player1_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_score.ForeColor = System.Drawing.Color.White;
            this.player1_score.Location = new System.Drawing.Point(266, 22);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(39, 42);
            this.player1_score.TabIndex = 12;
            this.player1_score.Text = "0";
            // 
            // player2_score
            // 
            this.player2_score.AutoSize = true;
            this.player2_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_score.ForeColor = System.Drawing.Color.White;
            this.player2_score.Location = new System.Drawing.Point(387, 22);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(39, 42);
            this.player2_score.TabIndex = 13;
            this.player2_score.Text = "0";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.Controls.Add(this.quit_button);
            this.menu.Controls.Add(this.start_button);
            this.menu.Controls.Add(this.title);
            this.menu.Location = new System.Drawing.Point(-10, -80);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(711, 611);
            this.menu.TabIndex = 14;
            // 
            // quit_button
            // 
            this.quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_button.Location = new System.Drawing.Point(287, 370);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(116, 38);
            this.quit_button.TabIndex = 2;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(287, 299);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(116, 38);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title.Location = new System.Drawing.Point(3, 169);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(705, 87);
            this.title.TabIndex = 0;
            this.title.Text = "PONG";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.player2_score);
            this.Controls.Add(this.player1_score);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label player1_score;
        private System.Windows.Forms.Label player2_score;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label title;
    }
}

