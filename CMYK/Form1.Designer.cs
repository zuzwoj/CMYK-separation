namespace CMYK
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
            curveBox = new PictureBox();
            originalBox = new PictureBox();
            kBox = new PictureBox();
            cBox = new PictureBox();
            mBox = new PictureBox();
            yBox = new PictureBox();
            groupBox1 = new GroupBox();
            checkBoxShowAll = new CheckBox();
            buttonCurveSave = new Button();
            buttonCurveLoad = new Button();
            radioButtonK = new RadioButton();
            radioButtonY = new RadioButton();
            radioButtonM = new RadioButton();
            radioButtonC = new RadioButton();
            buttonPictureSelect = new Button();
            buttonSavePictures = new Button();
            groupBox2 = new GroupBox();
            checkBoxCiB = new CheckBox();
            groupBox3 = new GroupBox();
            buttonGCR = new Button();
            buttonUCR = new Button();
            button1 = new Button();
            buttonC0 = new Button();
            ((System.ComponentModel.ISupportInitialize)curveBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // curveBox
            // 
            curveBox.Location = new Point(12, 12);
            curveBox.Name = "curveBox";
            curveBox.Size = new Size(350, 350);
            curveBox.TabIndex = 0;
            curveBox.TabStop = false;
            curveBox.MouseDown += curveBox_MouseDown;
            curveBox.MouseMove += curveBox_MouseMove;
            // 
            // originalBox
            // 
            originalBox.Location = new Point(12, 368);
            originalBox.Name = "originalBox";
            originalBox.Size = new Size(350, 350);
            originalBox.TabIndex = 1;
            originalBox.TabStop = false;
            // 
            // kBox
            // 
            kBox.Location = new Point(724, 368);
            kBox.Name = "kBox";
            kBox.Size = new Size(350, 350);
            kBox.TabIndex = 2;
            kBox.TabStop = false;
            // 
            // cBox
            // 
            cBox.Location = new Point(368, 12);
            cBox.Name = "cBox";
            cBox.Size = new Size(350, 350);
            cBox.TabIndex = 3;
            cBox.TabStop = false;
            // 
            // mBox
            // 
            mBox.Location = new Point(724, 12);
            mBox.Name = "mBox";
            mBox.Size = new Size(350, 350);
            mBox.TabIndex = 4;
            mBox.TabStop = false;
            // 
            // yBox
            // 
            yBox.Location = new Point(368, 368);
            yBox.Name = "yBox";
            yBox.Size = new Size(350, 350);
            yBox.TabIndex = 5;
            yBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxShowAll);
            groupBox1.Controls.Add(buttonCurveSave);
            groupBox1.Controls.Add(buttonCurveLoad);
            groupBox1.Controls.Add(radioButtonK);
            groupBox1.Controls.Add(radioButtonY);
            groupBox1.Controls.Add(radioButtonM);
            groupBox1.Controls.Add(radioButtonC);
            groupBox1.Location = new Point(1080, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 206);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gray ramp";
            // 
            // checkBoxShowAll
            // 
            checkBoxShowAll.AutoSize = true;
            checkBoxShowAll.Checked = true;
            checkBoxShowAll.CheckState = CheckState.Checked;
            checkBoxShowAll.Location = new Point(6, 180);
            checkBoxShowAll.Name = "checkBoxShowAll";
            checkBoxShowAll.Size = new Size(82, 19);
            checkBoxShowAll.TabIndex = 12;
            checkBoxShowAll.Text = "Show all";
            checkBoxShowAll.UseVisualStyleBackColor = true;
            checkBoxShowAll.CheckedChanged += checkBoxShowAll_CheckedChanged;
            // 
            // buttonCurveSave
            // 
            buttonCurveSave.Location = new Point(6, 151);
            buttonCurveSave.Name = "buttonCurveSave";
            buttonCurveSave.Size = new Size(155, 23);
            buttonCurveSave.TabIndex = 11;
            buttonCurveSave.Text = "Save";
            buttonCurveSave.UseVisualStyleBackColor = true;
            buttonCurveSave.Click += buttonCurveSave_Click;
            // 
            // buttonCurveLoad
            // 
            buttonCurveLoad.Location = new Point(6, 122);
            buttonCurveLoad.Name = "buttonCurveLoad";
            buttonCurveLoad.Size = new Size(155, 23);
            buttonCurveLoad.TabIndex = 10;
            buttonCurveLoad.Text = "Load...";
            buttonCurveLoad.UseVisualStyleBackColor = true;
            buttonCurveLoad.Click += buttonCurveLoad_Click;
            // 
            // radioButtonK
            // 
            radioButtonK.AutoSize = true;
            radioButtonK.Location = new Point(6, 97);
            radioButtonK.Name = "radioButtonK";
            radioButtonK.Size = new Size(60, 19);
            radioButtonK.TabIndex = 3;
            radioButtonK.TabStop = true;
            radioButtonK.Text = "Black";
            radioButtonK.UseVisualStyleBackColor = true;
            radioButtonK.CheckedChanged += radioButtonK_CheckedChanged;
            // 
            // radioButtonY
            // 
            radioButtonY.AutoSize = true;
            radioButtonY.Location = new Point(6, 72);
            radioButtonY.Name = "radioButtonY";
            radioButtonY.Size = new Size(67, 19);
            radioButtonY.TabIndex = 2;
            radioButtonY.TabStop = true;
            radioButtonY.Text = "Yellow";
            radioButtonY.UseVisualStyleBackColor = true;
            radioButtonY.CheckedChanged += radioButtonY_CheckedChanged;
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize = true;
            radioButtonM.Location = new Point(6, 47);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new Size(74, 19);
            radioButtonM.TabIndex = 1;
            radioButtonM.TabStop = true;
            radioButtonM.Text = "Magenta";
            radioButtonM.UseVisualStyleBackColor = true;
            radioButtonM.CheckedChanged += radioButtonM_CheckedChanged;
            // 
            // radioButtonC
            // 
            radioButtonC.AutoSize = true;
            radioButtonC.Location = new Point(6, 22);
            radioButtonC.Name = "radioButtonC";
            radioButtonC.Size = new Size(53, 19);
            radioButtonC.TabIndex = 0;
            radioButtonC.TabStop = true;
            radioButtonC.Text = "Cyan";
            radioButtonC.UseVisualStyleBackColor = true;
            radioButtonC.CheckedChanged += radioButtonC_CheckedChanged;
            // 
            // buttonPictureSelect
            // 
            buttonPictureSelect.Location = new Point(6, 22);
            buttonPictureSelect.Name = "buttonPictureSelect";
            buttonPictureSelect.Size = new Size(155, 23);
            buttonPictureSelect.TabIndex = 7;
            buttonPictureSelect.Text = "Select...";
            buttonPictureSelect.UseVisualStyleBackColor = true;
            buttonPictureSelect.Click += buttonPictureSelect_Click;
            // 
            // buttonSavePictures
            // 
            buttonSavePictures.Location = new Point(6, 51);
            buttonSavePictures.Name = "buttonSavePictures";
            buttonSavePictures.Size = new Size(155, 23);
            buttonSavePictures.TabIndex = 8;
            buttonSavePictures.Text = "Save";
            buttonSavePictures.UseVisualStyleBackColor = true;
            buttonSavePictures.Click += buttonSavePictures_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxCiB);
            groupBox2.Controls.Add(buttonPictureSelect);
            groupBox2.Controls.Add(buttonSavePictures);
            groupBox2.Location = new Point(1080, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 107);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Image";
            // 
            // checkBoxCiB
            // 
            checkBoxCiB.AutoSize = true;
            checkBoxCiB.Location = new Point(6, 80);
            checkBoxCiB.Name = "checkBoxCiB";
            checkBoxCiB.Size = new Size(89, 19);
            checkBoxCiB.TabIndex = 9;
            checkBoxCiB.Text = "grayscale";
            checkBoxCiB.UseVisualStyleBackColor = true;
            checkBoxCiB.CheckedChanged += checkBoxCiB_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonGCR);
            groupBox3.Controls.Add(buttonUCR);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(buttonC0);
            groupBox3.Location = new Point(1080, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(167, 142);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Separation";
            // 
            // buttonGCR
            // 
            buttonGCR.Location = new Point(6, 111);
            buttonGCR.Name = "buttonGCR";
            buttonGCR.Size = new Size(155, 23);
            buttonGCR.TabIndex = 11;
            buttonGCR.Text = "GCR";
            buttonGCR.UseVisualStyleBackColor = true;
            buttonGCR.Click += buttonGCR_Click;
            // 
            // buttonUCR
            // 
            buttonUCR.Location = new Point(6, 82);
            buttonUCR.Name = "buttonUCR";
            buttonUCR.Size = new Size(155, 23);
            buttonUCR.TabIndex = 2;
            buttonUCR.Text = "UCR";
            buttonUCR.UseVisualStyleBackColor = true;
            buttonUCR.Click += buttonUCR_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 53);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 1;
            button1.Text = "Black ink limit 100%";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonC0
            // 
            buttonC0.Location = new Point(6, 24);
            buttonC0.Name = "buttonC0";
            buttonC0.Size = new Size(155, 23);
            buttonC0.TabIndex = 0;
            buttonC0.Text = "Black ink limit 0%";
            buttonC0.UseVisualStyleBackColor = true;
            buttonC0.Click += buttonC0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 729);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(yBox);
            Controls.Add(mBox);
            Controls.Add(cBox);
            Controls.Add(kBox);
            Controls.Add(originalBox);
            Controls.Add(curveBox);
            Name = "Form1";
            Text = "CMYK separation";
            ((System.ComponentModel.ISupportInitialize)curveBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox curveBox;
        private GroupBox groupBox1;
        private RadioButton radioButtonK;
        private RadioButton radioButtonY;
        private RadioButton radioButtonM;
        private RadioButton radioButtonC;
        private Button buttonPictureSelect;
        private Button buttonSavePictures;
        private GroupBox groupBox2;
        private Button buttonCurveSave;
        private Button buttonCurveLoad;
        private CheckBox checkBoxCiB;
        public PictureBox originalBox;
        public PictureBox kBox;
        public PictureBox cBox;
        public PictureBox mBox;
        public PictureBox yBox;
        private GroupBox groupBox3;
        private Button button1;
        private Button buttonC0;
        private Button buttonGCR;
        private Button buttonUCR;
        private CheckBox checkBoxShowAll;
    }
}
