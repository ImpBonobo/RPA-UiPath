using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using ContentControl = Microsoft.Office.Interop.Word.ContentControl;

namespace MainProgramm
{
    class WordParser
    {
        public void main()
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;
            Word.Document wordDocument = new Word.Document();
            wordDocument = wordApp.Documents.Open("C:\\Users\\eric\\Desktop\\test.docx");

            List<ContentControl> contentControlList = new List<ContentControl>();

            foreach (Word.Range range in wordDocument.StoryRanges)
            {
                Word.Range rangeStory = range;
                foreach (ContentControl contentControl in rangeStory.ContentControls)
                {
                    contentControlList.Add(contentControl);
                }
            }

            for (int i = 0; i < contentControlList.Count; i++)
            {
                contentControlList[i].Range.Text = "Ich bin Nummer " + i;
            }
        }
    }
}
