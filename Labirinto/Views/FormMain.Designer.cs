namespace Labirinto
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editarMazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLineType = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLineColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLineWid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi10 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.numTamanhoBlc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numLargura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picMaze = new System.Windows.Forms.PictureBox();
            this.tsmiResolutColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoBlc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMazeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(987, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editarMazeToolStripMenuItem
            // 
            this.editarMazeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLineType,
            this.tsmiLineColor,
            this.tsmiLineWid,
            this.tsmiResolutColor});
            this.editarMazeToolStripMenuItem.Name = "editarMazeToolStripMenuItem";
            this.editarMazeToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.editarMazeToolStripMenuItem.Text = "Propriedades";
            // 
            // tsmiLineType
            // 
            this.tsmiLineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.tsmiLineType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowAnchorToolStripMenuItem,
            this.diamondAnchorToolStripMenuItem,
            this.flatToolStripMenuItem,
            this.roundToolStripMenuItem,
            this.roundAnchorToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.squareAnchorToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.tsmiLineType.Name = "tsmiLineType";
            this.tsmiLineType.Size = new System.Drawing.Size(180, 22);
            this.tsmiLineType.Text = "Tipo da linha";
            // 
            // arrowAnchorToolStripMenuItem
            // 
            this.arrowAnchorToolStripMenuItem.Name = "arrowAnchorToolStripMenuItem";
            this.arrowAnchorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrowAnchorToolStripMenuItem.Text = "ArrowAnchor";
            this.arrowAnchorToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // diamondAnchorToolStripMenuItem
            // 
            this.diamondAnchorToolStripMenuItem.Name = "diamondAnchorToolStripMenuItem";
            this.diamondAnchorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diamondAnchorToolStripMenuItem.Text = "DiamondAnchor";
            this.diamondAnchorToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // flatToolStripMenuItem
            // 
            this.flatToolStripMenuItem.Checked = true;
            this.flatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flatToolStripMenuItem.Name = "flatToolStripMenuItem";
            this.flatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flatToolStripMenuItem.Text = "Flat";
            this.flatToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // roundToolStripMenuItem
            // 
            this.roundToolStripMenuItem.Name = "roundToolStripMenuItem";
            this.roundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roundToolStripMenuItem.Text = "Round";
            this.roundToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // roundAnchorToolStripMenuItem
            // 
            this.roundAnchorToolStripMenuItem.Name = "roundAnchorToolStripMenuItem";
            this.roundAnchorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roundAnchorToolStripMenuItem.Text = "RoundAnchor";
            this.roundAnchorToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // squareAnchorToolStripMenuItem
            // 
            this.squareAnchorToolStripMenuItem.Name = "squareAnchorToolStripMenuItem";
            this.squareAnchorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.squareAnchorToolStripMenuItem.Text = "SquareAnchor";
            this.squareAnchorToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemLineType_Click);
            // 
            // tsmiLineColor
            // 
            this.tsmiLineColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.tsmiLineColor.Name = "tsmiLineColor";
            this.tsmiLineColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiLineColor.Text = "Cor da linha";
            this.tsmiLineColor.Click += new System.EventHandler(this.corDaLinhaToolStripMenuItem_Click);
            // 
            // tsmiLineWid
            // 
            this.tsmiLineWid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.tsmiLineWid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsmi2,
            this.tsmi3,
            this.tsmi4,
            this.tsmi5,
            this.tsmi6,
            this.tsmi7,
            this.tsmi8,
            this.tsmi9,
            this.tsmi10});
            this.tsmiLineWid.Name = "tsmiLineWid";
            this.tsmiLineWid.Size = new System.Drawing.Size(180, 22);
            this.tsmiLineWid.Text = "Largura da linha";
            // 
            // tsmi1
            // 
            this.tsmi1.Checked = true;
            this.tsmi1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(180, 22);
            this.tsmi1.Text = "1";
            this.tsmi1.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi2
            // 
            this.tsmi2.Name = "tsmi2";
            this.tsmi2.Size = new System.Drawing.Size(180, 22);
            this.tsmi2.Text = "2";
            this.tsmi2.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi3
            // 
            this.tsmi3.Name = "tsmi3";
            this.tsmi3.Size = new System.Drawing.Size(180, 22);
            this.tsmi3.Text = "3";
            this.tsmi3.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi4
            // 
            this.tsmi4.Name = "tsmi4";
            this.tsmi4.Size = new System.Drawing.Size(180, 22);
            this.tsmi4.Text = "4";
            this.tsmi4.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi5
            // 
            this.tsmi5.Name = "tsmi5";
            this.tsmi5.Size = new System.Drawing.Size(180, 22);
            this.tsmi5.Text = "5";
            this.tsmi5.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi6
            // 
            this.tsmi6.Name = "tsmi6";
            this.tsmi6.Size = new System.Drawing.Size(180, 22);
            this.tsmi6.Text = "6";
            this.tsmi6.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi7
            // 
            this.tsmi7.Name = "tsmi7";
            this.tsmi7.Size = new System.Drawing.Size(180, 22);
            this.tsmi7.Text = "7";
            this.tsmi7.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi8
            // 
            this.tsmi8.Name = "tsmi8";
            this.tsmi8.Size = new System.Drawing.Size(180, 22);
            this.tsmi8.Text = "8";
            this.tsmi8.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi9
            // 
            this.tsmi9.Name = "tsmi9";
            this.tsmi9.Size = new System.Drawing.Size(180, 22);
            this.tsmi9.Text = "9";
            this.tsmi9.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // tsmi10
            // 
            this.tsmi10.Name = "tsmi10";
            this.tsmi10.Size = new System.Drawing.Size(180, 22);
            this.tsmi10.Text = "10";
            this.tsmi10.Click += new System.EventHandler(this.toolStripMenuItemLineWid_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnSolve);
            this.pnlContent.Controls.Add(this.btnCriar);
            this.pnlContent.Controls.Add(this.numTamanhoBlc);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.numAltura);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.numLargura);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.pictureBox2);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.picMaze);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContent.Size = new System.Drawing.Size(987, 559);
            this.pnlContent.TabIndex = 1;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnSolve.Location = new System.Drawing.Point(50, 323);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(269, 35);
            this.btnSolve.TabIndex = 20;
            this.btnSolve.Text = "Resolver Labirinto";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Visible = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnCriar.Location = new System.Drawing.Point(50, 264);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(269, 35);
            this.btnCriar.TabIndex = 16;
            this.btnCriar.Text = "Criar Labirinto";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // numTamanhoBlc
            // 
            this.numTamanhoBlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.numTamanhoBlc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTamanhoBlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTamanhoBlc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.numTamanhoBlc.Location = new System.Drawing.Point(206, 124);
            this.numTamanhoBlc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTamanhoBlc.Name = "numTamanhoBlc";
            this.numTamanhoBlc.Size = new System.Drawing.Size(113, 21);
            this.numTamanhoBlc.TabIndex = 11;
            this.numTamanhoBlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTamanhoBlc.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(51, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tamanho do Bloco";
            // 
            // numAltura
            // 
            this.numAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.numAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.numAltura.Location = new System.Drawing.Point(206, 208);
            this.numAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(113, 21);
            this.numAltura.TabIndex = 14;
            this.numAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAltura.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Altura";
            // 
            // numLargura
            // 
            this.numLargura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.numLargura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLargura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.numLargura.Location = new System.Drawing.Point(206, 166);
            this.numLargura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLargura.Name = "numLargura";
            this.numLargura.Size = new System.Drawing.Size(113, 21);
            this.numLargura.TabIndex = 12;
            this.numLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLargura.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(51, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Largura";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(70, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gerador de Labirinto";
            // 
            // picMaze
            // 
            this.picMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.picMaze.Location = new System.Drawing.Point(379, 5);
            this.picMaze.Name = "picMaze";
            this.picMaze.Padding = new System.Windows.Forms.Padding(3);
            this.picMaze.Size = new System.Drawing.Size(603, 549);
            this.picMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMaze.TabIndex = 10;
            this.picMaze.TabStop = false;
            // 
            // tsmiResolutColor
            // 
            this.tsmiResolutColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(197)))));
            this.tsmiResolutColor.Name = "tsmiResolutColor";
            this.tsmiResolutColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiResolutColor.Text = "Cor da resolução";
            this.tsmiResolutColor.Click += new System.EventHandler(this.tsmiResolutColor_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(79)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 583);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanhoBlc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editarMazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLineType;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.NumericUpDown numTamanhoBlc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLargura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.ToolStripMenuItem arrowAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamondAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roundAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLineColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiLineWid;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsmi2;
        private System.Windows.Forms.ToolStripMenuItem tsmi3;
        private System.Windows.Forms.ToolStripMenuItem tsmi4;
        private System.Windows.Forms.ToolStripMenuItem tsmi5;
        private System.Windows.Forms.ToolStripMenuItem tsmi6;
        private System.Windows.Forms.ToolStripMenuItem tsmi7;
        private System.Windows.Forms.ToolStripMenuItem tsmi8;
        private System.Windows.Forms.ToolStripMenuItem tsmi9;
        private System.Windows.Forms.ToolStripMenuItem tsmi10;
        private System.Windows.Forms.ToolStripMenuItem tsmiResolutColor;
    }
}

