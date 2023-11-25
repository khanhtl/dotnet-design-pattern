using System.Text;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.AppendLine("</p>");
            Console.WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.AppendLine("</ul>");
            Console.WriteLine(sb);

            var builder = new HtmlBuilder("ul");
            builder
                .AddChild("li", "hello")
                .AddChild("li", "world");
            Console.WriteLine(builder);
        }
    }
}