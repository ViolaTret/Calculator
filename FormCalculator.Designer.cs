using System.Drawing;

namespace Calculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.panelHistory = new System.Windows.Forms.Panel();
            this.labelHistory = new System.Windows.Forms.Label();
            this.panelText = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.buttonZerro = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonFlipFraction = new System.Windows.Forms.Button();
            this.buttonResetAllValues = new System.Windows.Forms.Button();
            this.buttonClearLableText = new System.Windows.Forms.Button();
            this.buttonPercentage = new System.Windows.Forms.Button();
            this.buttonBcksp = new System.Windows.Forms.Button();
            this.panelHistory.SuspendLayout();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.Transparent;
            this.panelHistory.Controls.Add(this.labelHistory);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(445, 40);
            this.panelHistory.TabIndex = 0;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.BackColor = System.Drawing.Color.Transparent;
            this.labelHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHistory.ForeColor = System.Drawing.Color.DimGray;
            this.labelHistory.Location = new System.Drawing.Point(445, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHistory.Size = new System.Drawing.Size(0, 38);
            this.labelHistory.TabIndex = 0;
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.Color.Transparent;
            this.panelText.Controls.Add(this.labelText);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Location = new System.Drawing.Point(0, 40);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(445, 70);
            this.panelText.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(382, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(63, 69);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "0";
            this.labelText.TextChanged += new System.EventHandler(this.LabelText_TextChanged);
            // 
            // buttonInvert
            // 
            this.buttonInvert.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonInvert.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInvert.FlatAppearance.BorderSize = 0;
            this.buttonInvert.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonInvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInvert.Location = new System.Drawing.Point(1, 570);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(110, 90);
            this.buttonInvert.TabIndex = 11;
            this.buttonInvert.Text = "+/-";
            this.buttonInvert.UseVisualStyleBackColor = false;
            // 
            // buttonZerro
            // 
            this.buttonZerro.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonZerro.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonZerro.FlatAppearance.BorderSize = 0;
            this.buttonZerro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonZerro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonZerro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonZerro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZerro.Location = new System.Drawing.Point(112, 570);
            this.buttonZerro.Name = "buttonZerro";
            this.buttonZerro.Size = new System.Drawing.Size(110, 90);
            this.buttonZerro.TabIndex = 0;
            this.buttonZerro.Text = "0";
            this.buttonZerro.UseVisualStyleBackColor = false;
            this.buttonZerro.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonComma.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonComma.FlatAppearance.BorderSize = 0;
            this.buttonComma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonComma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonComma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComma.Location = new System.Drawing.Point(223, 570);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(110, 90);
            this.buttonComma.TabIndex = 10;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = false;
            this.buttonComma.Click += new System.EventHandler(this.ButtonComma_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(242)))));
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(242)))));
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(242)))));
            this.buttonEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(142)))), ((int)(((byte)(242)))));
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.Location = new System.Drawing.Point(334, 570);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(110, 90);
            this.buttonEqual.TabIndex = 12;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(334, 479);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 90);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThree.Location = new System.Drawing.Point(223, 479);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(110, 90);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.Location = new System.Drawing.Point(112, 479);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(110, 90);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.Location = new System.Drawing.Point(1, 479);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(110, 90);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.Transparent;
            this.buttonSub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonSub.FlatAppearance.BorderSize = 0;
            this.buttonSub.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSub.Location = new System.Drawing.Point(334, 388);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(110, 90);
            this.buttonSub.TabIndex = 14;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.ButtonSub_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.Location = new System.Drawing.Point(223, 388);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(110, 90);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFive.Location = new System.Drawing.Point(112, 388);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(110, 90);
            this.buttonFive.TabIndex = 5;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.Location = new System.Drawing.Point(1, 388);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(110, 90);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Transparent;
            this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(334, 297);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(110, 90);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.Location = new System.Drawing.Point(223, 297);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(110, 90);
            this.buttonNine.TabIndex = 9;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.Location = new System.Drawing.Point(112, 297);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(110, 90);
            this.buttonEight.TabIndex = 8;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeven.Location = new System.Drawing.Point(1, 297);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(110, 90);
            this.buttonSeven.TabIndex = 7;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Transparent;
            this.buttonDivide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(334, 206);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(110, 90);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.BackColor = System.Drawing.Color.Transparent;
            this.buttonPow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonPow.FlatAppearance.BorderSize = 0;
            this.buttonPow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPow.Location = new System.Drawing.Point(112, 206);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(110, 90);
            this.buttonPow.TabIndex = 18;
            this.buttonPow.Text = "x²";
            this.buttonPow.UseVisualStyleBackColor = false;
            this.buttonPow.Click += new System.EventHandler(this.ButtonPow_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.Transparent;
            this.buttonSqrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonSqrt.FlatAppearance.BorderSize = 0;
            this.buttonSqrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrt.Location = new System.Drawing.Point(223, 206);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(110, 90);
            this.buttonSqrt.TabIndex = 17;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // buttonFlipFraction
            // 
            this.buttonFlipFraction.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlipFraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonFlipFraction.FlatAppearance.BorderSize = 0;
            this.buttonFlipFraction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonFlipFraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFlipFraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonFlipFraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlipFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlipFraction.Location = new System.Drawing.Point(1, 206);
            this.buttonFlipFraction.Name = "buttonFlipFraction";
            this.buttonFlipFraction.Size = new System.Drawing.Size(110, 90);
            this.buttonFlipFraction.TabIndex = 19;
            this.buttonFlipFraction.Text = "1/x";
            this.buttonFlipFraction.UseVisualStyleBackColor = false;
            this.buttonFlipFraction.Click += new System.EventHandler(this.ButtonFlipFraction_Click);
            // 
            // buttonResetAllValues
            // 
            this.buttonResetAllValues.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetAllValues.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonResetAllValues.FlatAppearance.BorderSize = 0;
            this.buttonResetAllValues.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonResetAllValues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResetAllValues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonResetAllValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetAllValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetAllValues.Location = new System.Drawing.Point(223, 115);
            this.buttonResetAllValues.Name = "buttonResetAllValues";
            this.buttonResetAllValues.Size = new System.Drawing.Size(110, 90);
            this.buttonResetAllValues.TabIndex = 22;
            this.buttonResetAllValues.Text = "C";
            this.buttonResetAllValues.UseVisualStyleBackColor = false;
            this.buttonResetAllValues.Click += new System.EventHandler(this.ButtonResetAllValues_Click);
            // 
            // buttonClearLableText
            // 
            this.buttonClearLableText.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearLableText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonClearLableText.FlatAppearance.BorderSize = 0;
            this.buttonClearLableText.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonClearLableText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClearLableText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonClearLableText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLableText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearLableText.Location = new System.Drawing.Point(112, 115);
            this.buttonClearLableText.Name = "buttonClearLableText";
            this.buttonClearLableText.Size = new System.Drawing.Size(110, 90);
            this.buttonClearLableText.TabIndex = 21;
            this.buttonClearLableText.Text = "CE";
            this.buttonClearLableText.UseVisualStyleBackColor = false;
            this.buttonClearLableText.Click += new System.EventHandler(this.ButtonClearLableText_Click);
            // 
            // buttonPercentage
            // 
            this.buttonPercentage.BackColor = System.Drawing.Color.Transparent;
            this.buttonPercentage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonPercentage.FlatAppearance.BorderSize = 0;
            this.buttonPercentage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPercentage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPercentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPercentage.Location = new System.Drawing.Point(1, 115);
            this.buttonPercentage.Name = "buttonPercentage";
            this.buttonPercentage.Size = new System.Drawing.Size(110, 90);
            this.buttonPercentage.TabIndex = 20;
            this.buttonPercentage.Text = "%";
            this.buttonPercentage.UseVisualStyleBackColor = false;
            this.buttonPercentage.Click += new System.EventHandler(this.ButtonPercentage_Click);
            // 
            // buttonBcksp
            // 
            this.buttonBcksp.BackColor = System.Drawing.Color.Transparent;
            this.buttonBcksp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonBcksp.FlatAppearance.BorderSize = 0;
            this.buttonBcksp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonBcksp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBcksp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonBcksp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBcksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBcksp.Location = new System.Drawing.Point(334, 115);
            this.buttonBcksp.Name = "buttonBcksp";
            this.buttonBcksp.Size = new System.Drawing.Size(110, 90);
            this.buttonBcksp.TabIndex = 23;
            this.buttonBcksp.Text = "⌫";
            this.buttonBcksp.UseVisualStyleBackColor = false;
            this.buttonBcksp.Click += new System.EventHandler(this.ButtonBcksp_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 661);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.buttonBcksp);
            this.Controls.Add(this.buttonResetAllValues);
            this.Controls.Add(this.buttonClearLableText);
            this.Controls.Add(this.buttonPercentage);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonFlipFraction);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonZerro);
            this.Controls.Add(this.buttonInvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Button buttonZerro;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonFlipFraction;
        private System.Windows.Forms.Button buttonBcksp;
        private System.Windows.Forms.Button buttonResetAllValues;
        private System.Windows.Forms.Button buttonClearLableText;
        private System.Windows.Forms.Button buttonPercentage;
    }
}

