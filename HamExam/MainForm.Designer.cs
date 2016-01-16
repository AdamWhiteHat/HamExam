/*
 * Created by SharpDevelop.
 * User: BurningBunny
 * Date: 1/14/2013
 * Time: 2:51 PM
 * 
 * 
 */
namespace HamExam
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnNextQuestion = new System.Windows.Forms.Button();
			this.radioAnswerA = new System.Windows.Forms.RadioButton();
			this.radioAnswerB = new System.Windows.Forms.RadioButton();
			this.radioAnswerC = new System.Windows.Forms.RadioButton();
			this.radioAnswerD = new System.Windows.Forms.RadioButton();
			this.labelQuestion = new System.Windows.Forms.Label();
			this.labelQID = new System.Windows.Forms.Label();
			this.labelDebug = new System.Windows.Forms.Label();
			this.labelQuestionsCorrect = new System.Windows.Forms.Label();
			this.labelQuestionsTotal = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnHint = new System.Windows.Forms.Button();
			this.tbSection = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.Location = new System.Drawing.Point(5, 230);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(145, 30);
			this.btnNextQuestion.TabIndex = 0;
			this.btnNextQuestion.Text = "Next question";
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			this.btnNextQuestion.Click += new System.EventHandler(this.BtnNextQuestionClick);
			// 
			// radioAnswerA
			// 
			this.radioAnswerA.Location = new System.Drawing.Point(45, 105);
			this.radioAnswerA.Name = "radioAnswerA";
			this.radioAnswerA.Size = new System.Drawing.Size(445, 30);
			this.radioAnswerA.TabIndex = 1;
			this.radioAnswerA.TabStop = true;
			this.radioAnswerA.Text = "radioAnswerA";
			this.radioAnswerA.UseVisualStyleBackColor = true;
			this.radioAnswerA.Click += new System.EventHandler(this.AnswerAClicked);
			// 
			// radioAnswerB
			// 
			this.radioAnswerB.Location = new System.Drawing.Point(45, 135);
			this.radioAnswerB.Name = "radioAnswerB";
			this.radioAnswerB.Size = new System.Drawing.Size(445, 30);
			this.radioAnswerB.TabIndex = 2;
			this.radioAnswerB.TabStop = true;
			this.radioAnswerB.Text = "radioAnswerB";
			this.radioAnswerB.UseVisualStyleBackColor = true;
			this.radioAnswerB.Click += new System.EventHandler(this.AnswerBClicked);
			// 
			// radioAnswerC
			// 
			this.radioAnswerC.Location = new System.Drawing.Point(45, 165);
			this.radioAnswerC.Name = "radioAnswerC";
			this.radioAnswerC.Size = new System.Drawing.Size(445, 30);
			this.radioAnswerC.TabIndex = 3;
			this.radioAnswerC.TabStop = true;
			this.radioAnswerC.Text = "radioAnswerC";
			this.radioAnswerC.UseVisualStyleBackColor = true;
			this.radioAnswerC.Click += new System.EventHandler(this.AnswerCClicked);
			// 
			// radioAnswerD
			// 
			this.radioAnswerD.Location = new System.Drawing.Point(45, 195);
			this.radioAnswerD.Name = "radioAnswerD";
			this.radioAnswerD.Size = new System.Drawing.Size(445, 30);
			this.radioAnswerD.TabIndex = 4;
			this.radioAnswerD.TabStop = true;
			this.radioAnswerD.Text = "radioAnswerD";
			this.radioAnswerD.UseVisualStyleBackColor = true;
			this.radioAnswerD.Click += new System.EventHandler(this.AnswerDClicked);
			// 
			// labelQuestion
			// 
			this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuestion.Location = new System.Drawing.Point(5, 55);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(485, 50);
			this.labelQuestion.TabIndex = 5;
			this.labelQuestion.Text = "labelQuestion";
			this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// labelQID
			// 
			this.labelQID.Location = new System.Drawing.Point(5, 0);
			this.labelQID.Name = "labelQID";
			this.labelQID.Size = new System.Drawing.Size(100, 15);
			this.labelQID.TabIndex = 6;
			this.labelQID.Text = "labelQID";
			this.labelQID.Visible = false;
			// 
			// labelDebug
			// 
			this.labelDebug.Location = new System.Drawing.Point(160, 235);
			this.labelDebug.Name = "labelDebug";
			this.labelDebug.Size = new System.Drawing.Size(225, 25);
			this.labelDebug.TabIndex = 7;
			// 
			// labelQuestionsCorrect
			// 
			this.labelQuestionsCorrect.Location = new System.Drawing.Point(410, 0);
			this.labelQuestionsCorrect.Name = "labelQuestionsCorrect";
			this.labelQuestionsCorrect.Size = new System.Drawing.Size(25, 15);
			this.labelQuestionsCorrect.TabIndex = 10;
			this.labelQuestionsCorrect.Text = "000";
			this.labelQuestionsCorrect.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelQuestionsTotal
			// 
			this.labelQuestionsTotal.Location = new System.Drawing.Point(445, 0);
			this.labelQuestionsTotal.Name = "labelQuestionsTotal";
			this.labelQuestionsTotal.Size = new System.Drawing.Size(40, 15);
			this.labelQuestionsTotal.TabIndex = 11;
			this.labelQuestionsTotal.Text = "000";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(435, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "/";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(310, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 15);
			this.label5.TabIndex = 13;
			this.label5.Text = "Questions correct:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnHint
			// 
			this.btnHint.Location = new System.Drawing.Point(405, 235);
			this.btnHint.Name = "btnHint";
			this.btnHint.Size = new System.Drawing.Size(80, 23);
			this.btnHint.TabIndex = 14;
			this.btnHint.Text = "Hint...";
			this.btnHint.UseVisualStyleBackColor = true;
			this.btnHint.Click += new System.EventHandler(this.BtnHintClick);
			// 
			// tbSection
			// 
			this.tbSection.BackColor = System.Drawing.SystemColors.Control;
			this.tbSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSection.Location = new System.Drawing.Point(10, 20);
			this.tbSection.Multiline = true;
			this.tbSection.Name = "tbSection";
			this.tbSection.Size = new System.Drawing.Size(470, 30);
			this.tbSection.TabIndex = 16;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 433);
			this.Controls.Add(this.tbSection);
			this.Controls.Add(this.btnHint);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelQuestionsTotal);
			this.Controls.Add(this.labelQuestionsCorrect);
			this.Controls.Add(this.labelDebug);
			this.Controls.Add(this.labelQID);
			this.Controls.Add(this.labelQuestion);
			this.Controls.Add(this.radioAnswerD);
			this.Controls.Add(this.radioAnswerC);
			this.Controls.Add(this.radioAnswerB);
			this.Controls.Add(this.radioAnswerA);
			this.Controls.Add(this.btnNextQuestion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "HamExam";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox tbSection;
		private System.Windows.Forms.Button btnHint;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelQuestionsTotal;
		private System.Windows.Forms.Label labelQuestionsCorrect;
		private System.Windows.Forms.Label labelDebug;
		private System.Windows.Forms.Label labelQID;
		private System.Windows.Forms.Label labelQuestion;
		private System.Windows.Forms.RadioButton radioAnswerD;
		private System.Windows.Forms.RadioButton radioAnswerC;
		private System.Windows.Forms.RadioButton radioAnswerB;
		private System.Windows.Forms.RadioButton radioAnswerA;
		private System.Windows.Forms.Button btnNextQuestion;
	}
}
