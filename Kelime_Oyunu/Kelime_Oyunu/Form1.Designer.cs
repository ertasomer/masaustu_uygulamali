
namespace Kelime_Oyunu
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
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.answerHint = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.questionBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.answerBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.tableLayoutPanel2);
            this.questionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionBox.Location = new System.Drawing.Point(15, 15);
            this.questionBox.Margin = new System.Windows.Forms.Padding(15);
            this.questionBox.Name = "questionBox";
            this.questionBox.Padding = new System.Windows.Forms.Padding(10);
            this.questionBox.Size = new System.Drawing.Size(312, 281);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Soru - 1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.question, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.answer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnHint, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDone, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 26);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 245);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // question
            // 
            this.question.Cursor = System.Windows.Forms.Cursors.Default;
            this.question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question.Location = new System.Drawing.Point(100, 3);
            this.question.MinimumSize = new System.Drawing.Size(100, 4);
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Size = new System.Drawing.Size(189, 23);
            this.question.TabIndex = 1;
            // 
            // answer
            // 
            this.answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer.Location = new System.Drawing.Point(100, 32);
            this.answer.MinimumSize = new System.Drawing.Size(100, 4);
            this.answer.Name = "answer";
            this.answer.PlaceholderText = "Cevabı giriniz..";
            this.answer.Size = new System.Drawing.Size(189, 23);
            this.answer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cevap";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHint
            // 
            this.btnHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.Location = new System.Drawing.Point(3, 61);
            this.btnHint.Name = "btnHint";
            this.btnHint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHint.Size = new System.Drawing.Size(91, 40);
            this.btnHint.TabIndex = 4;
            this.btnHint.Text = "İpucu Al";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(100, 61);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(189, 40);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Cevapla";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.answerHint);
            this.answerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerBox.Location = new System.Drawing.Point(357, 15);
            this.answerBox.Margin = new System.Windows.Forms.Padding(15);
            this.answerBox.Name = "answerBox";
            this.answerBox.Padding = new System.Windows.Forms.Padding(15);
            this.answerBox.Size = new System.Drawing.Size(312, 281);
            this.answerBox.TabIndex = 1;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Cevap - 1";
            // 
            // answerHint
            // 
            this.answerHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerHint.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answerHint.Location = new System.Drawing.Point(15, 31);
            this.answerHint.Name = "answerHint";
            this.answerHint.Size = new System.Drawing.Size(282, 235);
            this.answerHint.TabIndex = 0;
            this.answerHint.Text = "********";
            this.answerHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.answerBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.questionBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.questionBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.answerBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label answerHint;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnDone;
    }
}

