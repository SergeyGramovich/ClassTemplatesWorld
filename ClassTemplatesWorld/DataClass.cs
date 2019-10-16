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

        // Right CheckBoxes

        [DataMember]
        public bool rightADataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool rightStaticADataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool rightConstrDataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool rightMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool rightStaticMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool rightMessageDataClassCheckBox { get; set; } = true;

        // Left CheckBoxes

        [DataMember]
        public bool leftADataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool leftMethDataClassCheckBox { get; set; } = true;
        [DataMember]
        public bool leftStaticMethDataClassCheckBox { get; set; } = true;
    }
}
