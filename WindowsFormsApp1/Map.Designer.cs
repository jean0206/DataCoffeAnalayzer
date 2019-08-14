namespace WindowsFormsApp1
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.gMapCoffe = new GMap.NET.WindowsForms.GMapControl();
            this.typeRanking = new System.Windows.Forms.ComboBox();
            this.yearRanking = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.DepartamentsBox = new System.Windows.Forms.ComboBox();
            this.optionBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.resetZoom = new System.Windows.Forms.Button();
            this.beforeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapCoffe
            // 
            this.gMapCoffe.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gMapCoffe.Bearing = 0F;
            this.gMapCoffe.CanDragMap = true;
            this.gMapCoffe.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapCoffe.GrayScaleMode = false;
            this.gMapCoffe.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapCoffe.LevelsKeepInMemmory = 5;
            this.gMapCoffe.Location = new System.Drawing.Point(12, 63);
            this.gMapCoffe.MarkersEnabled = true;
            this.gMapCoffe.MaxZoom = 2;
            this.gMapCoffe.MinZoom = 2;
            this.gMapCoffe.MouseWheelZoomEnabled = true;
            this.gMapCoffe.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapCoffe.Name = "gMapCoffe";
            this.gMapCoffe.NegativeMode = false;
            this.gMapCoffe.PolygonsEnabled = true;
            this.gMapCoffe.RetryLoadTile = 0;
            this.gMapCoffe.RoutesEnabled = true;
            this.gMapCoffe.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapCoffe.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapCoffe.ShowTileGridLines = false;
            this.gMapCoffe.Size = new System.Drawing.Size(829, 390);
            this.gMapCoffe.TabIndex = 0;
            this.gMapCoffe.Zoom = 0D;
            // 
            // typeRanking
            // 
            this.typeRanking.FormattingEnabled = true;
            this.typeRanking.Location = new System.Drawing.Point(155, 21);
            this.typeRanking.Name = "typeRanking";
            this.typeRanking.Size = new System.Drawing.Size(121, 21);
            this.typeRanking.TabIndex = 1;
            // 
            // yearRanking
            // 
            this.yearRanking.FormattingEnabled = true;
            this.yearRanking.Location = new System.Drawing.Point(12, 21);
            this.yearRanking.Name = "yearRanking";
            this.yearRanking.Size = new System.Drawing.Size(121, 21);
            this.yearRanking.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(694, 21);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Generar";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // DepartamentsBox
            // 
            this.DepartamentsBox.FormattingEnabled = true;
            this.DepartamentsBox.Location = new System.Drawing.Point(456, 23);
            this.DepartamentsBox.Name = "DepartamentsBox";
            this.DepartamentsBox.Size = new System.Drawing.Size(121, 21);
            this.DepartamentsBox.TabIndex = 4;
            this.DepartamentsBox.SelectedIndexChanged += new System.EventHandler(this.DepartamentsBox_SelectedIndexChanged);
            // 
            // optionBox
            // 
            this.optionBox.FormattingEnabled = true;
            this.optionBox.Location = new System.Drawing.Point(303, 21);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(121, 21);
            this.optionBox.TabIndex = 5;
            this.optionBox.SelectedIndexChanged += new System.EventHandler(this.optionBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(775, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resetZoom
            // 
            this.resetZoom.Location = new System.Drawing.Point(58, 467);
            this.resetZoom.Name = "resetZoom";
            this.resetZoom.Size = new System.Drawing.Size(75, 23);
            this.resetZoom.TabIndex = 7;
            this.resetZoom.Text = "ZoomInicial";
            this.resetZoom.UseVisualStyleBackColor = true;
            this.resetZoom.Click += new System.EventHandler(this.resetZoom_Click);
            // 
            // beforeButton
            // 
            this.beforeButton.Location = new System.Drawing.Point(694, 467);
            this.beforeButton.Name = "beforeButton";
            this.beforeButton.Size = new System.Drawing.Size(75, 23);
            this.beforeButton.TabIndex = 8;
            this.beforeButton.Text = "Regresar";
            this.beforeButton.UseVisualStyleBackColor = true;
            this.beforeButton.Click += new System.EventHandler(this.beforeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 507);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 502);
            this.Controls.Add(this.beforeButton);
            this.Controls.Add(this.resetZoom);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.DepartamentsBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.yearRanking);
            this.Controls.Add(this.typeRanking);
            this.Controls.Add(this.gMapCoffe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapCoffe;
        private System.Windows.Forms.ComboBox typeRanking;
        private System.Windows.Forms.ComboBox yearRanking;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox DepartamentsBox;
        private System.Windows.Forms.ComboBox optionBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resetZoom;
        private System.Windows.Forms.Button beforeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}