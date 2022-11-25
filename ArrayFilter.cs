namespace ByteArrayConverter;
public static class ArrayFilter
{
    public static void FilterUserInput(string Input, List<string> list)
    {
        string InputUppered = Input.ToUpper();

        InputUppered = InputUppered.TrimNonHexStart();
        InputUppered = InputUppered.TrimNonHexEnd();

        if(InputUppered.Contains("0X")) FilterFromByteArray(InputUppered, list);
        else if(InputUppered.Contains(@"\X")) FilterFromStringLiteral(InputUppered, list);
        else if(InputUppered.Contains(" ")) FilterFromSpaceSeperated(InputUppered, list);
        else FilterFromRawHex(InputUppered, list);
    }

    static void FilterFromRawHex(string InputUppered, List<string> list)
    {
        for(int i = 0; i < InputUppered.Length; i += 2)
            if((InputUppered[i].OnlyContainsHex()) && (InputUppered[i + 1].OnlyContainsHex()))
                list.Add(InputUppered[i].ToString() + InputUppered[i + 1].ToString());
    }

    static void FilterFromSpaceSeperated(string InputUppered, List<string> list)
    {
        var splitStr = InputUppered.Split(" ");
        foreach(string str in splitStr)
            list.Add(str);
    }

    static void FilterFromStringLiteral(string InputUppered, List<string> list)
    {
        var splitStr = InputUppered.Split(@"\");
        foreach(string str in splitStr)
            if(str.StartsWith("X"))
                list.Add((str[1].ToString() + str[2].ToString()));
            else
                list.Add((str[0].ToString() + str[1].ToString()));
    }

    static void FilterFromByteArray(string InputUppered, List<string> list)
    {
        var splitStr = InputUppered.Split(", ");
        foreach(string str in splitStr)
            list.Add(str.Replace("0X", ""));
    }
}