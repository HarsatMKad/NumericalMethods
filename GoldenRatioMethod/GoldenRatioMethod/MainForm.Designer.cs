﻿
namespace GoldenRatioMethod
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выборМетодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.дихотомияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.золотоеСечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.методНьютонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.координатныйСпускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.сортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.нахождениеЛогарифмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сЛАУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.мНКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.Color.LightGray;
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      this.chart1.Location = new System.Drawing.Point(397, 43);
      this.chart1.Name = "chart1";
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.Name = "Series1";
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(600, 600);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(13, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "F(x) =";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightGray;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.textBox7);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.textBox3);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 43);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(370, 255);
      this.panel1.TabIndex = 2;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.SkyBlue;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(65, 213);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(246, 38);
      this.button1.TabIndex = 10;
      this.button1.Text = "Применить";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox7
      // 
      this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox7.Location = new System.Drawing.Point(116, 64);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(238, 29);
      this.textBox7.TabIndex = 9;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(13, 67);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(96, 24);
      this.label8.TabIndex = 8;
      this.label8.Text = "Точность";
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox3.Location = new System.Drawing.Point(20, 168);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(139, 26);
      this.textBox3.TabIndex = 7;
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(212, 168);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(139, 26);
      this.textBox2.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(261, 145);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(50, 20);
      this.label4.TabIndex = 5;
      this.label4.Text = "B(до)";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(61, 145);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "A(от)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(77, 112);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(208, 24);
      this.label2.TabIndex = 3;
      this.label2.Text = "Укажите ограничения";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(75, 13);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(279, 29);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.выборМетодаToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(853, 33);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.рассчитатьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // выборМетодаToolStripMenuItem
      // 
      this.выборМетодаToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.выборМетодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дихотомияToolStripMenuItem,
            this.золотоеСечениеToolStripMenuItem,
            this.методНьютонаToolStripMenuItem,
            this.координатныйСпускToolStripMenuItem});
      this.выборМетодаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.выборМетодаToolStripMenuItem.Name = "выборМетодаToolStripMenuItem";
      this.выборМетодаToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
      this.выборМетодаToolStripMenuItem.Text = "Выбор Метода";
      // 
      // дихотомияToolStripMenuItem
      // 
      this.дихотомияToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.дихотомияToolStripMenuItem.Name = "дихотомияToolStripMenuItem";
      this.дихотомияToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
      this.дихотомияToolStripMenuItem.Text = "Дихотомия";
      this.дихотомияToolStripMenuItem.Click += new System.EventHandler(this.дихотомияToolStripMenuItem_Click);
      // 
      // золотоеСечениеToolStripMenuItem
      // 
      this.золотоеСечениеToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.золотоеСечениеToolStripMenuItem.Name = "золотоеСечениеToolStripMenuItem";
      this.золотоеСечениеToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
      this.золотоеСечениеToolStripMenuItem.Text = "Золотое сечение";
      this.золотоеСечениеToolStripMenuItem.Click += new System.EventHandler(this.золотоеСечениеToolStripMenuItem_Click);
      // 
      // методНьютонаToolStripMenuItem
      // 
      this.методНьютонаToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.методНьютонаToolStripMenuItem.Name = "методНьютонаToolStripMenuItem";
      this.методНьютонаToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
      this.методНьютонаToolStripMenuItem.Text = "Метод Ньютона";
      this.методНьютонаToolStripMenuItem.Click += new System.EventHandler(this.методНьютонаToolStripMenuItem_Click);
      // 
      // координатныйСпускToolStripMenuItem
      // 
      this.координатныйСпускToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.координатныйСпускToolStripMenuItem.Name = "координатныйСпускToolStripMenuItem";
      this.координатныйСпускToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
      this.координатныйСпускToolStripMenuItem.Text = "Координатный спуск";
      this.координатныйСпускToolStripMenuItem.Click += new System.EventHandler(this.координатныйСпускToolStripMenuItem_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.LightGray;
      this.panel2.Controls.Add(this.label11);
      this.panel2.Controls.Add(this.label10);
      this.panel2.Controls.Add(this.textBox8);
      this.panel2.Controls.Add(this.label9);
      this.panel2.Controls.Add(this.textBox6);
      this.panel2.Controls.Add(this.textBox5);
      this.panel2.Controls.Add(this.textBox4);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Location = new System.Drawing.Point(12, 315);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(370, 328);
      this.panel2.TabIndex = 4;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label11.Location = new System.Drawing.Point(89, 51);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(204, 26);
      this.label11.TabIndex = 9;
      this.label11.Text = "________________";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(89, 14);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(201, 26);
      this.label10.TabIndex = 8;
      this.label10.Text = "Выбранный метод";
      // 
      // textBox8
      // 
      this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox8.Location = new System.Drawing.Point(194, 190);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(173, 29);
      this.textBox8.TabIndex = 7;
      this.textBox8.Visible = false;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(70, 193);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(70, 24);
      this.label9.TabIndex = 6;
      this.label9.Text = "F(x0) =";
      this.label9.Visible = false;
      // 
      // textBox6
      // 
      this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox6.Location = new System.Drawing.Point(194, 275);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(173, 29);
      this.textBox6.TabIndex = 5;
      this.textBox6.Visible = false;
      // 
      // textBox5
      // 
      this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox5.Location = new System.Drawing.Point(194, 230);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(173, 29);
      this.textBox5.TabIndex = 4;
      this.textBox5.Visible = false;
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // textBox4
      // 
      this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox4.Location = new System.Drawing.Point(194, 145);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(173, 29);
      this.textBox4.TabIndex = 3;
      this.textBox4.Visible = false;
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(70, 278);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(101, 24);
      this.label7.TabIndex = 2;
      this.label7.Text = "Максимум";
      this.label7.Visible = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(70, 233);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(94, 24);
      this.label6.TabIndex = 1;
      this.label6.Text = "Минимум";
      this.label6.Visible = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(3, 148);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(185, 24);
      this.label5.TabIndex = 0;
      this.label5.Text = "Точка пересечения";
      this.label5.Visible = false;
      // 
      // menuStrip2
      // 
      this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.menuStrip2.Location = new System.Drawing.Point(853, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(156, 653);
      this.menuStrip2.TabIndex = 5;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкиToolStripMenuItem,
            this.нахождениеЛогарифмаToolStripMenuItem,
            this.сЛАУToolStripMenuItem,
            this.мНКToolStripMenuItem});
      this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 29);
      this.toolStripMenuItem1.Text = "Другие задачи";
      // 
      // сортировкиToolStripMenuItem
      // 
      this.сортировкиToolStripMenuItem.Name = "сортировкиToolStripMenuItem";
      this.сортировкиToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.сортировкиToolStripMenuItem.Text = "Сортировки";
      this.сортировкиToolStripMenuItem.Click += new System.EventHandler(this.сортировкиToolStripMenuItem_Click);
      // 
      // нахождениеЛогарифмаToolStripMenuItem
      // 
      this.нахождениеЛогарифмаToolStripMenuItem.Name = "нахождениеЛогарифмаToolStripMenuItem";
      this.нахождениеЛогарифмаToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.нахождениеЛогарифмаToolStripMenuItem.Text = "Нахождение интеграла";
      this.нахождениеЛогарифмаToolStripMenuItem.Click += new System.EventHandler(this.нахождениеЛогарифмаToolStripMenuItem_Click);
      // 
      // сЛАУToolStripMenuItem
      // 
      this.сЛАУToolStripMenuItem.Name = "сЛАУToolStripMenuItem";
      this.сЛАУToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.сЛАУToolStripMenuItem.Text = "СЛАУ";
      this.сЛАУToolStripMenuItem.Click += new System.EventHandler(this.сЛАУToolStripMenuItem_Click);
      // 
      // мНКToolStripMenuItem
      // 
      this.мНКToolStripMenuItem.Name = "мНКToolStripMenuItem";
      this.мНКToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.мНКToolStripMenuItem.Text = "МНК";
      this.мНКToolStripMenuItem.Click += new System.EventHandler(this.мНКToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 653);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.menuStrip2);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ToolStripMenuItem выборМетодаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem дихотомияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem золотоеСечениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem методНьютонаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem координатныйСпускToolStripMenuItem;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem сортировкиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem нахождениеЛогарифмаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сЛАУToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem мНКToolStripMenuItem;
  }
}