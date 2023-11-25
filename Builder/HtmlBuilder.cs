namespace Builder
{
    internal class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        string _rootName;
        public HtmlBuilder(string rootName)
        {
            root.Name = rootName;
            _rootName = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }
        public void Clear()
        {
            root = new HtmlElement { Name = _rootName };
        }
    }
}
