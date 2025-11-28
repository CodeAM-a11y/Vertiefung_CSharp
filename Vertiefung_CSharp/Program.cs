using System.Text;

namespace Vertiefung_CSharp
{
    internal class Program
    {
        static public bool ContainsDuplicateChars(string s)
        {
            bool bReturn = false;

            s = s.ToLower();
            string suchen = "";
            for(int i = 0; i < s.Length; i++)
            {
                suchen=suchen.Insert(i, Convert.ToString(s[i]));
                s=s.Remove(i, 1);
                foreach(char ch in suchen)
                {
                    if (s.Contains(ch)) { bReturn = true; }
                }
            }

            return bReturn;
        }
        static public bool IsPalindrom(string s)
        {
            s = s.ToLower();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            return s.Equals(reversedString);

        }
        static public bool IsPalindrom(string s,bool b1)
        {
            StringBuilder SBuild = new StringBuilder();
            if (b1 = true) 
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i]==' ') { s=s.Remove(i,1); }
                }
            }
            s = s.ToLower();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            return s.Equals(reversedString);

        }
        static public void AnalyseString(string s)
        {
            int vokaleZähl = 0;
            int konsonantenZähl = 0;
            int umlauteZähl = 0;
            int ziffernZähl = 0;
            int andereZeichenZähl = 0;
            string vokale = "aeioujyAEIOUJY";
            string konsonanten = "qwrtzpsdfghklxcvbnmQWRTZPSDFGHKLXCVBNM";
            string umlaute = "üöäßÜÖÄ";
            string ziffern = "1234567890";
            foreach (char x in s)
            {
                if (vokale.Contains(x)) { vokaleZähl++; }
                else if (vokale.Contains(x)) { vokaleZähl++; }
                else if (konsonanten.Contains(x)) { konsonantenZähl++; }
                else if (umlaute.Contains(x)) { umlauteZähl++; }
                else if (ziffern.Contains(x)) { ziffernZähl++; }
                else { andereZeichenZähl++; }
            }
            Console.WriteLine($"Der Text enthält {vokaleZähl} Vokale, {konsonantenZähl} Konsonanten, {umlauteZähl} Umlaute, {ziffernZähl} Ziffern und {andereZeichenZähl} andere Zeichen");
        }
        static public int CountCharString(string s,char c)
        {
            s = s.ToLower();
            c = char.ToLower(c);
            int zähler=0;
            foreach(char x in s)
            {
                if (x==c) { zähler++; }
            }
            return zähler;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountCharString("abccccccd", 'c'));
            AnalyseString("Hallo, über die Himmel 238491##ß");
            Console.WriteLine(IsPalindrom("Otto")+" "+IsPalindrom("Maxiii"));
            Console.WriteLine(IsPalindrom("Dreh mal am Herd",true));
            Console.WriteLine(ContainsDuplicateChars("Otto"));
            Console.WriteLine(ContainsDuplicateChars("Micha"));
        }
    }
}