/*
 *
 * Developed by Adam Rakaska
 *  http://csharpcodewhisperer.blogspot.com
 *    http://arakaska.wix.com/intelligentsoftware
 *
 *
 * Made using SharpDevelop
 *
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace HamExam
{
	/// <summary>
	/// Description of HamExam.
	/// </summary>
	public class HamExam
	{
		public HamExam()
		{
			rand = new Random();
			ResetTest();
		}
		
		public int LastQuestionNumber;
		public int CurrentQuestionNumber;
		
		public int QuestionsAsked;
		public int QuestionsCorrect;
		public int QuestionsIncorrect;
		public List<int> MissedQuestions;
		public float AskMissedPercentage;
		
		public Random rand;
		public char Answer;
		public bool HasAnswered;
		
		public string[] QuestionPool;
		public int QuestionsAvailable;
		public string QuestionInfo_Page;
		public string QuestionInfo_Chapter;
		public string QuestionInfo_Section;
		
		// Reference material variables
		public string[] Sections;
		
		public string[] Question_Options;
		public enum AnswerEnum { A, B, C, D };
		static char[] delimiterChars = { '(', ')' };
		public void QuestionIncorrect()	{	QuestionsIncorrect++;	}
		public void QuestionCorrect()	{	QuestionsCorrect++;	}
		
		public void ResetTest()
		{
			LoadQuestionPool("TechnicianClass.QuestionPool");
			LoadSectionInfo("Technician_Sections.xml");
			
			// Stats
			LastQuestionNumber = 0;
			QuestionsAsked = 0;
			QuestionsCorrect = 0;
			QuestionsIncorrect = 0;
			MissedQuestions = new List<int>();
			AskMissedPercentage = 0.2f; // 0.1901f
			// Misc
			Answer = ' ';
			HasAnswered = false;
		}
		
		public void LoadQuestionPool(string FileName)
		{
			if(!File.Exists(FileName))
			{
				throw new Exception("Question pool does not exist!");
			}
			
			XmlDocument questionPool = new XmlDocument();
			questionPool.LoadXml( File.ReadAllText(FileName) );
			
			XmlNodeList chapters = questionPool.DocumentElement.ChildNodes;
			
			List<string> pool = new List<string>();
			foreach(XmlNode chapter in chapters)
			{
				XmlNodeList Qs = chapter.LastChild.LastChild.ChildNodes;
				foreach(XmlNode q in Qs)
				{
					pool.Add(q.InnerText);
				}
			}
			
			QuestionPool = pool.ToArray();
			QuestionsAvailable = QuestionPool.Length;
		}
		
		public void NextQuestion()
		{
			CurrentQuestionNumber = rand.Next(QuestionsAvailable); // Select a random question from 0 to NumQuestions
			
			while(CurrentQuestionNumber == LastQuestionNumber)
			{	// Make sure we didnt select the same question
				CurrentQuestionNumber = rand.Next(QuestionsAvailable);
			}
			LastQuestionNumber = CurrentQuestionNumber;		// Set last question
			
			ParseQuestion();
			
			QuestionsAsked++; // Increment questions asked
			HasAnswered = false; // Allow user to answer
		}
		
		public void ParseQuestion()
		{
			Question_Options = QuestionPool[CurrentQuestionNumber].Split('\n');
			
			// Figure out the correct answer
			string[] QuestionInfo = Question_Options[1].Split(delimiterChars);
			QuestionInfo_Chapter = QuestionInfo[0];
			QuestionInfo_Page = QuestionInfo[2];
			Answer = QuestionInfo[1][0];
			
			// Reference
			foreach(string s in Sections)
			{
				string sectionID = QuestionInfo_Chapter.Substring(0,3);
				if(s.Contains(sectionID))
				{
					QuestionInfo_Section = s;
				}
			}
		}
		
		public void LoadSectionInfo(string FileName)
		{
			Sections = File.ReadAllLines(FileName);
		}
	}
}
