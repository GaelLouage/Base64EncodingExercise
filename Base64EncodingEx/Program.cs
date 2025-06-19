using System.Buffers.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ToBase64("this is a string!!"));
        Console.WriteLine(FromBase64(ToBase64("this is a string!!")));
    }
    public static string ToBase64(string s)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s));
    }

    public static string FromBase64(string s)
    {

        var base64EncodedBytes = System.Convert.FromBase64String(s);
        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }
}