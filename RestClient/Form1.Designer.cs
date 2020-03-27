namespace RestClient
{
    partial class RestClient
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
            this.buttonStatus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPutText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPutFN = new System.Windows.Forms.TextBox();
            this.buttonPut = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPostText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPostFN = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxCopyFN2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCopyFN1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGetFN = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDeleteFN = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.textBoxMoveFN2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMoveFN1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(12, 12);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(81, 23);
            this.buttonStatus.TabIndex = 0;
            this.buttonStatus.Text = "Check status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPutText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPutFN);
            this.groupBox1.Controls.Add(this.buttonPut);
            this.groupBox1.Location = new System.Drawing.Point(29, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Put";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text";
            // 
            // textBoxPutText
            // 
            this.textBoxPutText.Location = new System.Drawing.Point(6, 90);
            this.textBoxPutText.Name = "textBoxPutText";
            this.textBoxPutText.Size = new System.Drawing.Size(100, 20);
            this.textBoxPutText.TabIndex = 8;
            this.textBoxPutText.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FileName";
            // 
            // textBoxPutFN
            // 
            this.textBoxPutFN.Location = new System.Drawing.Point(6, 45);
            this.textBoxPutFN.Name = "textBoxPutFN";
            this.textBoxPutFN.Size = new System.Drawing.Size(100, 20);
            this.textBoxPutFN.TabIndex = 6;
            this.textBoxPutFN.Text = "file.txt";
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(6, 116);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(81, 23);
            this.buttonPut.TabIndex = 5;
            this.buttonPut.Text = "Put";
            this.buttonPut.UseVisualStyleBackColor = true;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(9, 116);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(81, 23);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonPost);
            this.groupBox2.Controls.Add(this.textBoxPostText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxPostFN);
            this.groupBox2.Location = new System.Drawing.Point(184, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 155);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Text";
            // 
            // textBoxPostText
            // 
            this.textBoxPostText.Location = new System.Drawing.Point(6, 90);
            this.textBoxPostText.Name = "textBoxPostText";
            this.textBoxPostText.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostText.TabIndex = 8;
            this.textBoxPostText.Text = "text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FileName";
            // 
            // textBoxPostFN
            // 
            this.textBoxPostFN.Location = new System.Drawing.Point(6, 45);
            this.textBoxPostFN.Name = "textBoxPostFN";
            this.textBoxPostFN.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostFN.TabIndex = 6;
            this.textBoxPostFN.Text = "file.txt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.buttonCopy);
            this.groupBox4.Controls.Add(this.textBoxCopyFN2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxCopyFN1);
            this.groupBox4.Location = new System.Drawing.Point(342, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 155);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Copy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FileName2";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(9, 116);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(81, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxCopyFN2
            // 
            this.textBoxCopyFN2.Location = new System.Drawing.Point(6, 90);
            this.textBoxCopyFN2.Name = "textBoxCopyFN2";
            this.textBoxCopyFN2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCopyFN2.TabIndex = 8;
            this.textBoxCopyFN2.Text = "file2.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "FileName1";
            // 
            // textBoxCopyFN1
            // 
            this.textBoxCopyFN1.Location = new System.Drawing.Point(6, 45);
            this.textBoxCopyFN1.Name = "textBoxCopyFN1";
            this.textBoxCopyFN1.Size = new System.Drawing.Size(100, 20);
            this.textBoxCopyFN1.TabIndex = 6;
            this.textBoxCopyFN1.Text = "file.txt";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonGet);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBoxGetFN);
            this.groupBox5.Location = new System.Drawing.Point(342, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(129, 155);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Get";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(9, 116);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(97, 23);
            this.buttonGet.TabIndex = 6;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "FileName";
            // 
            // textBoxGetFN
            // 
            this.textBoxGetFN.Location = new System.Drawing.Point(6, 68);
            this.textBoxGetFN.Name = "textBoxGetFN";
            this.textBoxGetFN.Size = new System.Drawing.Size(100, 20);
            this.textBoxGetFN.TabIndex = 6;
            this.textBoxGetFN.Text = "file.txt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxDeleteFN);
            this.groupBox3.Location = new System.Drawing.Point(184, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 155);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(9, 116);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "FileName";
            // 
            // textBoxDeleteFN
            // 
            this.textBoxDeleteFN.Location = new System.Drawing.Point(6, 68);
            this.textBoxDeleteFN.Name = "textBoxDeleteFN";
            this.textBoxDeleteFN.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteFN.TabIndex = 6;
            this.textBoxDeleteFN.Text = "file.txt";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.buttonMove);
            this.groupBox6.Controls.Add(this.textBoxMoveFN2);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.textBoxMoveFN1);
            this.groupBox6.Location = new System.Drawing.Point(494, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(129, 155);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Move";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "FileName2";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(9, 116);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(81, 23);
            this.buttonMove.TabIndex = 6;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // textBoxMoveFN2
            // 
            this.textBoxMoveFN2.Location = new System.Drawing.Point(6, 90);
            this.textBoxMoveFN2.Name = "textBoxMoveFN2";
            this.textBoxMoveFN2.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoveFN2.TabIndex = 8;
            this.textBoxMoveFN2.Text = "file2.txt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "FileName1";
            // 
            // textBoxMoveFN1
            // 
            this.textBoxMoveFN1.Location = new System.Drawing.Point(6, 45);
            this.textBoxMoveFN1.Name = "textBoxMoveFN1";
            this.textBoxMoveFN1.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoveFN1.TabIndex = 6;
            this.textBoxMoveFN1.Text = "file.txt";
            // 
            // RestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 410);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStatus);
            this.Name = "RestClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPutText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPutFN;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPostText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPostFN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxCopyFN2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCopyFN1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGetFN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDeleteFN;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.TextBox textBoxMoveFN2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMoveFN1;
    }
}

