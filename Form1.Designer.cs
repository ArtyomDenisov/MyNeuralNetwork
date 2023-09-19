namespace MyNeuralNetwork
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
            this.drawPicture = new System.Windows.Forms.PictureBox();
            this.inputPicture = new System.Windows.Forms.PictureBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.PredictButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.TrainButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberList = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // drawPicture
            // 
            this.drawPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPicture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawPicture.Location = new System.Drawing.Point(11, 14);
            this.drawPicture.Margin = new System.Windows.Forms.Padding(4);
            this.drawPicture.Name = "drawPicture";
            this.drawPicture.Size = new System.Drawing.Size(292, 326);
            this.drawPicture.TabIndex = 0;
            this.drawPicture.TabStop = false;
            this.drawPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPicture_MouseDown);
            this.drawPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPicture_MouseMove);
            // 
            // inputPicture
            // 
            this.inputPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPicture.Location = new System.Drawing.Point(14, 380);
            this.inputPicture.Margin = new System.Windows.Forms.Padding(4);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(152, 172);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPicture.TabIndex = 1;
            this.inputPicture.TabStop = false;
            // 
            // CleanButton
            // 
            this.CleanButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanButton.Location = new System.Drawing.Point(310, 14);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(4);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(234, 41);
            this.CleanButton.TabIndex = 2;
            this.CleanButton.Text = "Очистить изображение";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // PredictButton
            // 
            this.PredictButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PredictButton.Location = new System.Drawing.Point(310, 64);
            this.PredictButton.Margin = new System.Windows.Forms.Padding(4);
            this.PredictButton.Name = "PredictButton";
            this.PredictButton.Size = new System.Drawing.Size(234, 39);
            this.PredictButton.TabIndex = 3;
            this.PredictButton.Text = "Распознать цифру";
            this.PredictButton.UseVisualStyleBackColor = true;
            this.PredictButton.Click += new System.EventHandler(this.PredictButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(399, 174);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(29, 20);
            this.answerLabel.TabIndex = 4;
            this.answerLabel.Text = "0";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainButton
            // 
            this.TrainButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainButton.Location = new System.Drawing.Point(311, 248);
            this.TrainButton.Margin = new System.Windows.Forms.Padding(4);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(233, 39);
            this.TrainButton.TabIndex = 6;
            this.TrainButton.Text = "Обучить";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(316, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Верный ответ:";
            // 
            // numberList
            // 
            this.numberList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberList.Location = new System.Drawing.Point(432, 214);
            this.numberList.Margin = new System.Windows.Forms.Padding(4);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(112, 27);
            this.numberList.TabIndex = 9;
            this.numberList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(316, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Это цифра:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(634, 13);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(244, 39);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить нейроную сеть";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(634, 64);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(4);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(243, 39);
            this.UploadButton.TabIndex = 13;
            this.UploadButton.Text = "Загрузить нейроную сеть";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Уменьшение разрешения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.PredictButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.inputPicture);
            this.Controls.Add(this.drawPicture);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Нейронная сеть";
            ((System.ComponentModel.ISupportInitialize)(this.drawPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawPicture;
        private System.Windows.Forms.PictureBox inputPicture;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button PredictButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown numberList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label label3;
    }
}

