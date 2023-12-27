namespace SHJ.PersianCulture;

public static class PersianCurrencyExtentions
{
    /// <summary>
    /// fa-IR => current culture currency symbol => ریال    exam=>
    /// 123456 => "123,123ریال"    
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToNumbericRial(this int value)
    {
        return value.ToString("C0");
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ToRial(this int value)
    {
        return value * 10;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static long ToRial(this long value)
    {
        return value * 10;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ToToman(this int value)
    {
        return value / 10;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static long ToToman(this long value)
    {
        return value / 10;
    }
}
