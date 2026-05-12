using System;
using System.Collections;

#nullable disable
namespace go.Forms
{
    [Serializable]
    public class FormInfo
    {
        public ArrayList columnInfo = new ArrayList();
        public ArrayList columnWidths = new ArrayList();
        public int formWidth;
        public int formHeight;
    }
}
