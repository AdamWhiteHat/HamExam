/*
 * Created by SharpDevelop.
 * User: BurningBunny
 * Date: 1/14/2013
 * Time: 2:51 PM
 * 
 * 
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using HamExam;

namespace HamExam
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		HamExam exam;
		bool HintVisible;
		
		public MainForm()
		{
			InitializeComponent();
			exam = new HamExam();
			HintVisible = true;
			ToggleHint();
		}
		
		public static void MyExceptionHandler(object sender, ThreadExceptionEventArgs e) {
			MessageBox.Show("Error: " + e.Exception.Message,"HamExam",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		
		#region Events
		
		void MainFormLoad(object sender, EventArgs e)
		{
			LoadNextQuestion();
		}
		
		void BtnNextQuestionClick(object sender, EventArgs e)
		{
			LoadNextQuestion();
		}
		
		void AnswerAClicked(object sender, EventArgs e)
		{
			CheckAnswer('A');
		}
		
		void AnswerBClicked(object sender, EventArgs e)
		{
			CheckAnswer('B');
		}
		
		void AnswerCClicked(object sender, EventArgs e)
		{
			CheckAnswer('C');
		}
		
		void AnswerDClicked(object sender, EventArgs e)
		{
			CheckAnswer('D');
		}
		
		void BtnHintClick(object sender, EventArgs e)
		{
			ToggleHint();
		}
		
		#endregion
		
		void ToggleHint()
		{
			if(HintVisible)
			{
				this.Height = 292;
				HintVisible = false;
			}
			else
			{
				this.Height = 460;
				HintVisible = true;
			}
		}
		
		public void LoadNextQuestion()
		{
			exam.NextQuestion();
			ResetGUI();
		}
		
		void CheckAnswer(char answer)
		{
			if(!exam.HasAnswered)
			{
				exam.HasAnswered = true;
				
				if(exam.Answer==answer)
				{
					exam.QuestionCorrect();
					UpdateGUI(answer,true);
				}
				else
				{
					exam.QuestionIncorrect();
					UpdateGUI(exam.Answer,true);
					UpdateGUI(answer,false);
				}
			}
		}
		
		void UpdateGUI(char answer,bool correct)
		{
			labelQuestionsCorrect.Text = exam.QuestionsCorrect.ToString();
			
			// Highlight answers
			if(answer=='A')
				radioAnswerA.BackColor = correct ? Color.MintCream : Color.MistyRose;
			else if(answer=='B')
				radioAnswerB.BackColor = correct ? Color.MintCream : Color.MistyRose;
			else if(answer=='C')
				radioAnswerC.BackColor = correct ? Color.MintCream : Color.MistyRose;
			else if(answer=='D')
				radioAnswerD.BackColor = correct ? Color.MintCream : Color.MistyRose;
		}
		
		void ResetGUI()
		{
			// Reset checked state
			radioAnswerA.Checked = false;
			radioAnswerB.Checked = false;
			radioAnswerC.Checked = false;
			radioAnswerD.Checked = false;
			// Reset control colors
			radioAnswerA.BackColor = Color.FromKnownColor(KnownColor.Control);
			radioAnswerB.BackColor = Color.FromKnownColor(KnownColor.Control);
			radioAnswerC.BackColor = Color.FromKnownColor(KnownColor.Control);
			radioAnswerD.BackColor = Color.FromKnownColor(KnownColor.Control);
			// Update score
			labelQuestionsCorrect.Text = exam.QuestionsCorrect.ToString();
			labelQuestionsTotal.Text = exam.QuestionsAsked.ToString();

			// Display next question
			labelQID.Text = exam.QuestionInfo_Chapter + " - " + exam.QuestionInfo_Page;
			tbSection.Text = exam.QuestionInfo_Section;
			labelQuestion.Text= exam.Question_Options[2];
			radioAnswerA.Text = exam.Question_Options[3];
			radioAnswerB.Text = exam.Question_Options[4];
			radioAnswerC.Text = exam.Question_Options[5];
			if(exam.Question_Options.Length>7) {
				radioAnswerD.Visible = true;
				radioAnswerD.Text = exam.Question_Options[6];
			} else {
				radioAnswerD.Visible = false;
			}

			// Debug output..
			labelDebug.Text = "Question #" + exam.CurrentQuestionNumber.ToString() + " of " + exam.QuestionsAvailable.ToString();
			//labelDebug.Text += ": Elements: " + CurrentQuestion.Length.ToString();
			//labelDebug.Text += " & Answer: " + QuestionInfo[1];
		}
	}
}
