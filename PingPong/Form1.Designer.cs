namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.Panel();
            this.LossText = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.gameBol = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.restart = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.Controls.Add(this.restart);
            this.background.Controls.Add(this.LossText);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.gameBol);
            this.background.Controls.Add(this.gamePanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1064, 629);
            this.background.TabIndex = 0;
            // 
            // LossText
            // 
            this.LossText.AutoSize = true;
            this.LossText.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LossText.Location = new System.Drawing.Point(296, 244);
            this.LossText.Name = "LossText";
            this.LossText.Size = new System.Drawing.Size(427, 70);
            this.LossText.TabIndex = 3;
            this.LossText.Text = "Вы проиграли";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(910, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(97, 36);
            this.result.TabIndex = 2;
            this.result.Text = "Счет: ";
            // 
            // gameBol
            // 
            this.gameBol.BackColor = System.Drawing.Color.Black;
            this.gameBol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameBol.BackgroundImage")));
            this.gameBol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBol.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameBol.Location = new System.Drawing.Point(483, 332);
            this.gameBol.Name = "gameBol";
            this.gameBol.Size = new System.Drawing.Size(105, 78);
            this.gameBol.TabIndex = 1;
            this.gameBol.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePanel.Location = new System.Drawing.Point(399, 570);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(346, 47);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.Location = new System.Drawing.Point(296, 174);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(449, 70);
            this.restart.TabIndex = 4;
            this.restart.Text = "Нажмите Enter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 629);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.PictureBox gameBol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label LossText;
        private System.Windows.Forms.Label restart;
    }
}

