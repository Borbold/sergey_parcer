using System.Diagnostics;
using System.Text;

namespace SergeyParcesr {
    internal class StringParsing {
        public void ParsePassedString(string parStr, DataGridViewRowCollection gridRows) {
            string[] arrayParStr = parStr.Split(' ');

            // Checking
            byte[] bufStrSID = Encoding.Default.GetBytes(arrayParStr[2].Split('x')[1]);

            int CD = 0;
            CD |= bufStrSID[0] >> 5;
            int sender = 0;
            sender |= bufStrSID[1];
            sender |= bufStrSID[2] >> 2;
            int receiver = 0;
            receiver |= bufStrSID[2];
            receiver |= bufStrSID[3] >> 2;
            int attribute = 0;
            attribute |= bufStrSID[4];
            attribute |= bufStrSID[5];
            int code = 0;
            code |= bufStrSID[6];
            code |= bufStrSID[7];
            // Checking

            gridRows.Add(arrayParStr[0], arrayParStr[1],
                CD, Convert.ToString(sender, 16).ToUpper(), Convert.ToString(receiver, 16).ToUpper(),
                Convert.ToString(attribute, 16).ToUpper(), Convert.ToString(code, 16).ToUpper(),
                arrayParStr[3].Split('=')[1]);
        }
    }
}
