namespace SHJ.PersianCulture;

public static class PersianCultureExtentions
{
    public const char ArabicYeChar = (char)1610;
    public const char PersianYeChar = (char)1740;
    public const char ArabicKeChar = (char)1603;
    public const char PersianKeChar = (char)1705;

    /// <summary>
    ///  "1"  =>  "۱"
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string NumberEn2Fa(this string str)
    {
        return str.Replace("0", "۰")
            .Replace("1", "۱")
            .Replace("2", "۲")
            .Replace("3", "۳")
            .Replace("4", "۴")
            .Replace("5", "۵")
            .Replace("6", "۶")
            .Replace("7", "۷")
            .Replace("8", "۸")
            .Replace("9", "۹");
    }

    /// <summary>
    /// "۱" => "1"
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string NumberFa2En(this string str)
    {
        return str.Replace("۰", "0")
            .Replace("۱", "1")
            .Replace("۲", "2")
            .Replace("۳", "3")
            .Replace("۴", "4")
            .Replace("۵", "5")
            .Replace("۶", "6")
            .Replace("۷", "7")
            .Replace("۸", "8")
            .Replace("۹", "9")
            //iphone numeric
            .Replace("٠", "0")
            .Replace("١", "1")
            .Replace("٢", "2")
            .Replace("٣", "3")
            .Replace("٤", "4")
            .Replace("٥", "5")
            .Replace("٦", "6")
            .Replace("٧", "7")
            .Replace("٨", "8")
            .Replace("٩", "9");
    }

    /// <summary>
    ///  Fix Persian Chars
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string FixPersianChars(this string str)
    {
        return str.Replace("ﮎ", "ک")
            .Replace("ﮏ", "ک")
            .Replace("ﮐ", "ک")
            .Replace("ﮑ", "ک")
            .Replace("ك", "ک")
            .Replace("ي", "ی")
            .Replace(" ", " ")
            .Replace("‌", " ")
            .Replace("ھ", "ه");//.Replace("ئ", "ی");
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static string ApplyCorrectYeKe(this object data)
    {
        return data == null ? null : ApplyCorrectYeKe(data.ToString());
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static string ApplyCorrectYeKe(this string data)
    {
        return string.IsNullOrWhiteSpace(data) ?
                    string.Empty :
                    data.Replace(ArabicYeChar, PersianYeChar).Replace(ArabicKeChar, PersianKeChar).Trim();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string CleanPersionString(this string str)
    {
        return str.Trim().FixPersianChars().NumberFa2En().NullIfEmpty();
    }

    private static string NullIfEmpty(this string str)
    {
        return str?.Length == 0 ? null : str;
    }

}
