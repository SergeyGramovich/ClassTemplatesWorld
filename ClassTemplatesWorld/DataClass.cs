using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace ClassTemplatesWorld
{
    [DataContractAttribute]
    class DataClass
    {
        [DataMember]
        public string className { get; set; }
        [DataMember]
        public string classDescription { get; set; }
        [DataMember]
        public Point canvasPointClass { get; set; }
        [DataMember]
        public string parentClassNameForThis { get; set; } = null;

        // Right RichTextBoxes

        [DataMember]
        public bool rightADataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> rightAInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> rightAInlineText = new List<string>();
        [DataMember]
        public List<int> rightAInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> rightAInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> rightAParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool rightStaticADataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> rightStaticAInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> rightStaticAInlineText = new List<string>();
        [DataMember]
        public List<int> rightStaticAInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> rightStaticAInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> rightStaticAParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool rightConstrDataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> rightConstrInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> rightConstrInlineText = new List<string>();
        [DataMember]
        public List<int> rightConstrInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> rightConstrInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> rightConstrParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool rightMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> rightMethInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> rightMethInlineText = new List<string>();
        [DataMember]
        public List<int> rightMethInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> rightMethInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> rightMethParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool rightStaticMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> rightStaticMethInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> rightStaticMethInlineText = new List<string>();
        [DataMember]
        public List<int> rightStaticMethInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> rightStaticMethInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> rightStaticMethParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool rightMessageDataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> rightMessageInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> rightMessageInlineText = new List<string>();
        [DataMember]
        public List<int> rightMessageInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> rightMessageInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> rightMessageParagraphInlinesCount = new List<int>();

        // Left RichTextBoxes

        [DataMember]
        public bool leftADataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> leftAInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> leftAInlineText = new List<string>();
        [DataMember]
        public List<int> leftAInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> leftAInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> leftAParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool leftMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> leftMethInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> leftMethInlineText = new List<string>();
        [DataMember]
        public List<int> leftMethInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> leftMethInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> leftMethParagraphInlinesCount = new List<int>();

        [DataMember]
        public bool leftStaticMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public List<bool> leftStaticMethInlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> leftStaticMethInlineText = new List<string>();
        [DataMember]
        public List<int> leftStaticMethInlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> leftStaticMethInlineTextColor = new List<Color>();
        [DataMember]
        public List<int> leftStaticMethParagraphInlinesCount = new List<int>();

    }
}
