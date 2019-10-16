using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ClassTemplatesWorld
{
    [DataContractAttribute]
    class RichTextBoxDataClass
    {
        [DataMember]
        public List<bool> inlineTextFontWeight = new List<bool>();
        [DataMember]
        public List<string> inlineText = new List<string>();
        [DataMember]
        public List<int> inlineTextFontSize = new List<int>();
        [DataMember]
        public List<Color> inlineTextColor = new List<Color>();
        [DataMember]
        public List<int> paragraphInlinesCount = new List<int>();
    }
}
