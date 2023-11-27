namespace OnlyZoo
{
    partial class Catalogo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            Lista = new ToolStripSplitButton();
            Vista1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btn_Merch = new Button();
            btn_Producto = new Button();
            Titulo = new Label();
            menu_Lista = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            toolTip1 = new ToolTip(components);
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu_Lista.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btn_Merch);
            panel1.Controls.Add(btn_Producto);
            panel1.Controls.Add(Titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Lista });
            toolStrip1.Location = new Point(9, 9);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(54, 41);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "menu_lista";
            // 
            // Lista
            // 
            Lista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Lista.DropDownItems.AddRange(new ToolStripItem[] { Vista1, toolStripMenuItem2, toolStripMenuItem3 });
            Lista.Image = (Image)resources.GetObject("Lista.Image");
            Lista.ImageTransparentColor = Color.Transparent;
            Lista.Name = "Lista";
            Lista.Size = new Size(36, 38);
            Lista.Text = "toolStripSplitButton1";
            Lista.ButtonClick += Lista_ButtonClick;
            // 
            // Vista1
            // 
            Vista1.Name = "Vista1";
            Vista1.Size = new Size(116, 24);
            Vista1.Text = "Vista1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(116, 24);
            toolStripMenuItem2.Text = "Vista2";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(116, 24);
            toolStripMenuItem3.Text = "Vista3";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(650, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(682, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_Merch
            // 
            btn_Merch.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Merch.Location = new Point(669, 62);
            btn_Merch.Name = "btn_Merch";
            btn_Merch.Size = new Size(110, 38);
            btn_Merch.TabIndex = 2;
            btn_Merch.Text = "Merch";
            btn_Merch.UseVisualStyleBackColor = true;
            // 
            // btn_Producto
            // 
            btn_Producto.BackColor = Color.Transparent;
            btn_Producto.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Producto.Location = new Point(523, 62);
            btn_Producto.Name = "btn_Producto";
            btn_Producto.Size = new Size(110, 38);
            btn_Producto.TabIndex = 1;
            btn_Producto.Text = "Productos";
            btn_Producto.UseVisualStyleBackColor = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Elephant", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(327, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(158, 41);
            Titulo.TabIndex = 0;
            Titulo.Text = "OnlyZoo";
            Titulo.Click += label1_Click;
            // 
            // menu_Lista
            // 
            menu_Lista.BackColor = Color.Transparent;
            menu_Lista.BackgroundImageLayout = ImageLayout.None;
            menu_Lista.Controls.Add(button5);
            menu_Lista.Controls.Add(button4);
            menu_Lista.Controls.Add(button3);
            menu_Lista.Controls.Add(button9);
            menu_Lista.Controls.Add(button2);
            menu_Lista.Controls.Add(button1);
            menu_Lista.Dock = DockStyle.Fill;
            menu_Lista.ForeColor = Color.Transparent;
            menu_Lista.Location = new Point(0, 100);
            menu_Lista.Name = "menu_Lista";
            menu_Lista.Size = new Size(800, 350);
            menu_Lista.TabIndex = 0;
            menu_Lista.Paint += panel2_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(52, 176);
            button2.Name = "button2";
            button2.Size = new Size(178, 134);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(52, 24);
            button1.Name = "button1";
            button1.Size = new Size(178, 134);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.Location = new Point(307, 24);
            button9.Name = "button9";
            button9.Size = new Size(178, 134);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(307, 176);
            button3.Name = "button3";
            button3.Size = new Size(178, 134);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Location = new Point(566, 24);
            button4.Name = "button4";
            button4.Size = new Size(178, 134);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Location = new Point(566, 176);
            button5.Name = "button5";
            button5.Size = new Size(178, 134);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = true;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu_Lista);
            Controls.Add(panel1);
            Name = "Catalogo";
            Text = "Catalogo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu_Lista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel menu_Lista;
        private Label Titulo;
        private Button btn_Merch;
        private Button btn_Producto;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton Lista;
        private ToolStripMenuItem Vista1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button9;
    }
}