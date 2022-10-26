namespace BitcoinBOT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(66, 77);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(197, 64);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Iniciar Robô de Leitura";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.Transparent;
            this.btn_comprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_comprar.BackgroundImage")));
            this.btn_comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comprar.FlatAppearance.BorderSize = 0;
            this.btn_comprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_comprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_comprar.Location = new System.Drawing.Point(66, 165);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(197, 64);
            this.btn_comprar.TabIndex = 1;
            this.btn_comprar.Text = "Comprar Bitcoin";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // notify
            // 
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 330);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "BitcoinBot";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_start;
        private Button btn_comprar;
        private NotifyIcon notify;
    }
}