namespace ShapesP5
{
    partial class Shapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shapes));
            this.comboShapes = new System.Windows.Forms.ComboBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createShapes = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.y4 = new System.Windows.Forms.TextBox();
            this.shapeBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P3 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.perText = new System.Windows.Forms.Label();
            this.pCount = new System.Windows.Forms.Label();
            this.tCount = new System.Windows.Forms.Label();
            this.rCount = new System.Windows.Forms.Label();
            this.sCount = new System.Windows.Forms.Label();
            this.numSquare = new System.Windows.Forms.Label();
            this.numRect = new System.Windows.Forms.Label();
            this.numTrap = new System.Windows.Forms.Label();
            this.numPara = new System.Windows.Forms.Label();
            this.shapeName = new System.Windows.Forms.Label();
            this.areaLable = new System.Windows.Forms.Label();
            this.perLable = new System.Windows.Forms.Label();
            this.shapeBox3 = new System.Windows.Forms.PictureBox();
            this.shapeBox2 = new System.Windows.Forms.PictureBox();
            this.shapeBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboShapes
            // 
            this.comboShapes.BackColor = System.Drawing.SystemColors.Menu;
            this.comboShapes.FormattingEnabled = true;
            this.comboShapes.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Parallelogram",
            "Trapezoid"});
            this.comboShapes.Location = new System.Drawing.Point(9, 12);
            this.comboShapes.Name = "comboShapes";
            this.comboShapes.Size = new System.Drawing.Size(100, 21);
            this.comboShapes.TabIndex = 0;
            this.comboShapes.SelectedIndexChanged += new System.EventHandler(this.comboShapes_SelectedIndexChanged);
            // 
            // y1
            // 
            this.y1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.y1.Location = new System.Drawing.Point(47, 105);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(29, 20);
            this.y1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point set 1 (x,y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Point set 2 (x,y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Point set 3 (x,y)";
            // 
            // createShapes
            // 
            this.createShapes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createShapes.Location = new System.Drawing.Point(12, 337);
            this.createShapes.Name = "createShapes";
            this.createShapes.Size = new System.Drawing.Size(128, 44);
            this.createShapes.TabIndex = 6;
            this.createShapes.Text = "Compute";
            this.createShapes.UseVisualStyleBackColor = true;
            this.createShapes.Click += new System.EventHandler(this.createShapes_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(12, 153);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(29, 20);
            this.x2.TabIndex = 7;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(47, 203);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(29, 20);
            this.y3.TabIndex = 8;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(12, 105);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(29, 20);
            this.x1.TabIndex = 9;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(47, 153);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(29, 20);
            this.y2.TabIndex = 10;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(12, 203);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(29, 20);
            this.x3.TabIndex = 11;
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(12, 253);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(29, 20);
            this.x4.TabIndex = 12;
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(47, 253);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(29, 20);
            this.y4.TabIndex = 13;
            // 
            // shapeBox
            // 
            this.shapeBox.Image = ((System.Drawing.Image)(resources.GetObject("shapeBox.Image")));
            this.shapeBox.Location = new System.Drawing.Point(182, 67);
            this.shapeBox.Name = "shapeBox";
            this.shapeBox.Size = new System.Drawing.Size(217, 216);
            this.shapeBox.TabIndex = 14;
            this.shapeBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Point set 4 (x,y)";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(179, 51);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(0, 13);
            this.P2.TabIndex = 15;
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Location = new System.Drawing.Point(364, 51);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(0, 13);
            this.P3.TabIndex = 16;
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Location = new System.Drawing.Point(179, 286);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(0, 13);
            this.P1.TabIndex = 17;
            // 
            // P4
            // 
            this.P4.AutoSize = true;
            this.P4.Location = new System.Drawing.Point(364, 286);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(0, 13);
            this.P4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Area";
            // 
            // perText
            // 
            this.perText.AutoSize = true;
            this.perText.Location = new System.Drawing.Point(257, 321);
            this.perText.Name = "perText";
            this.perText.Size = new System.Drawing.Size(51, 13);
            this.perText.TabIndex = 22;
            this.perText.Text = "Perimeter";
            // 
            // pCount
            // 
            this.pCount.AutoSize = true;
            this.pCount.Location = new System.Drawing.Point(452, 253);
            this.pCount.Name = "pCount";
            this.pCount.Size = new System.Drawing.Size(127, 13);
            this.pCount.TabIndex = 23;
            this.pCount.Text = "Number of Parallelograms";
            // 
            // tCount
            // 
            this.tCount.AutoSize = true;
            this.tCount.Location = new System.Drawing.Point(452, 186);
            this.tCount.Name = "tCount";
            this.tCount.Size = new System.Drawing.Size(111, 13);
            this.tCount.TabIndex = 24;
            this.tCount.Text = "Number of Trapezoids";
            // 
            // rCount
            // 
            this.rCount.AutoSize = true;
            this.rCount.Location = new System.Drawing.Point(452, 124);
            this.rCount.Name = "rCount";
            this.rCount.Size = new System.Drawing.Size(113, 13);
            this.rCount.TabIndex = 25;
            this.rCount.Text = "Number of Rectangles";
            // 
            // sCount
            // 
            this.sCount.AutoSize = true;
            this.sCount.Location = new System.Drawing.Point(452, 69);
            this.sCount.Name = "sCount";
            this.sCount.Size = new System.Drawing.Size(98, 13);
            this.sCount.TabIndex = 26;
            this.sCount.Text = "Number of Squares";
            // 
            // numSquare
            // 
            this.numSquare.AutoSize = true;
            this.numSquare.Location = new System.Drawing.Point(469, 89);
            this.numSquare.Name = "numSquare";
            this.numSquare.Size = new System.Drawing.Size(0, 13);
            this.numSquare.TabIndex = 31;
            // 
            // numRect
            // 
            this.numRect.AutoSize = true;
            this.numRect.Location = new System.Drawing.Point(469, 137);
            this.numRect.Name = "numRect";
            this.numRect.Size = new System.Drawing.Size(0, 13);
            this.numRect.TabIndex = 32;
            // 
            // numTrap
            // 
            this.numTrap.AutoSize = true;
            this.numTrap.Location = new System.Drawing.Point(469, 203);
            this.numTrap.Name = "numTrap";
            this.numTrap.Size = new System.Drawing.Size(0, 13);
            this.numTrap.TabIndex = 33;
            // 
            // numPara
            // 
            this.numPara.AutoSize = true;
            this.numPara.Location = new System.Drawing.Point(469, 270);
            this.numPara.Name = "numPara";
            this.numPara.Size = new System.Drawing.Size(0, 13);
            this.numPara.TabIndex = 34;
            // 
            // shapeName
            // 
            this.shapeName.AutoSize = true;
            this.shapeName.Location = new System.Drawing.Point(257, 12);
            this.shapeName.Name = "shapeName";
            this.shapeName.Size = new System.Drawing.Size(0, 13);
            this.shapeName.TabIndex = 35;
            // 
            // areaLable
            // 
            this.areaLable.AutoSize = true;
            this.areaLable.Location = new System.Drawing.Point(190, 340);
            this.areaLable.Name = "areaLable";
            this.areaLable.Size = new System.Drawing.Size(0, 13);
            this.areaLable.TabIndex = 36;
            // 
            // perLable
            // 
            this.perLable.AutoSize = true;
            this.perLable.Location = new System.Drawing.Point(257, 337);
            this.perLable.Name = "perLable";
            this.perLable.Size = new System.Drawing.Size(0, 13);
            this.perLable.TabIndex = 37;
            // 
            // shapeBox3
            // 
            this.shapeBox3.Image = ((System.Drawing.Image)(resources.GetObject("shapeBox3.Image")));
            this.shapeBox3.Location = new System.Drawing.Point(149, 89);
            this.shapeBox3.Name = "shapeBox3";
            this.shapeBox3.Size = new System.Drawing.Size(297, 164);
            this.shapeBox3.TabIndex = 38;
            this.shapeBox3.TabStop = false;
            // 
            // shapeBox2
            // 
            this.shapeBox2.Image = ((System.Drawing.Image)(resources.GetObject("shapeBox2.Image")));
            this.shapeBox2.Location = new System.Drawing.Point(182, 67);
            this.shapeBox2.Name = "shapeBox2";
            this.shapeBox2.Size = new System.Drawing.Size(217, 216);
            this.shapeBox2.TabIndex = 39;
            this.shapeBox2.TabStop = false;
            // 
            // shapeBox4
            // 
            this.shapeBox4.Image = ((System.Drawing.Image)(resources.GetObject("shapeBox4.Image")));
            this.shapeBox4.Location = new System.Drawing.Point(182, 67);
            this.shapeBox4.Name = "shapeBox4";
            this.shapeBox4.Size = new System.Drawing.Size(217, 216);
            this.shapeBox4.TabIndex = 40;
            this.shapeBox4.TabStop = false;
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 393);
            this.Controls.Add(this.shapeBox4);
            this.Controls.Add(this.shapeBox2);
            this.Controls.Add(this.shapeBox3);
            this.Controls.Add(this.perLable);
            this.Controls.Add(this.areaLable);
            this.Controls.Add(this.shapeName);
            this.Controls.Add(this.numPara);
            this.Controls.Add(this.numTrap);
            this.Controls.Add(this.numRect);
            this.Controls.Add(this.numSquare);
            this.Controls.Add(this.sCount);
            this.Controls.Add(this.rCount);
            this.Controls.Add(this.tCount);
            this.Controls.Add(this.pCount);
            this.Controls.Add(this.perText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.shapeBox);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.createShapes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.comboShapes);
            this.Name = "Shapes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboShapes;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createShapes;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.TextBox y4;
        private System.Windows.Forms.PictureBox shapeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label perText;
        private System.Windows.Forms.Label pCount;
        private System.Windows.Forms.Label tCount;
        private System.Windows.Forms.Label rCount;
        private System.Windows.Forms.Label sCount;
        private System.Windows.Forms.Label numSquare;
        private System.Windows.Forms.Label numRect;
        private System.Windows.Forms.Label numTrap;
        private System.Windows.Forms.Label numPara;
        private System.Windows.Forms.Label shapeName;
        private System.Windows.Forms.Label areaLable;
        private System.Windows.Forms.Label perLable;
        private System.Windows.Forms.PictureBox shapeBox3;
        private System.Windows.Forms.PictureBox shapeBox2;
        private System.Windows.Forms.PictureBox shapeBox4;
    }
}

