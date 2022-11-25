using System.Text.RegularExpressions;
namespace ByteArrayConverter;
public static class StringExtensions
{
    public static bool OnlyContainsHex(this string text) => Regex.IsMatch(text, @"\A\b[0-9a-fA-F]+\b\Z");
    public static bool OnlyContainsHex(this char text) => text.ToString().OnlyContainsHex();

    public static string TrimNonHexEnd(this string text)
    {
        while(!(text[text.Length - 1].OnlyContainsHex()))
            text = text[..^1];
        return text;
    }

    public static string TrimNonHexStart(this string text)
    {
        while(!(text[0]).OnlyContainsHex())
            text = text[1..];
        return text;
    }
}