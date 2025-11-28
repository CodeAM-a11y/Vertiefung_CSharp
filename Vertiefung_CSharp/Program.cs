namespace Vertiefung_CSharp
{
    internal class Program
    {
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
        }
    }
}