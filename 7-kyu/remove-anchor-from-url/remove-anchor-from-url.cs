public static class Kata
{
    public static string RemoveUrlAnchor(string url)
    {
        // Divide a string no '#' e pega apenas a primeira parte [0]
        return url.Split('#')[0];
    }
}