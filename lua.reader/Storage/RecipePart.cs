using Newtonsoft.Json.Linq;

namespace lua.reader
{
    public class RecipePart
    {
        public static RecipePart Input(JToken token)
        { return new RecipePart(token); }
        public static RecipePart Output(JToken token)
        { return new RecipePart(token, false); }

        public static RecipePart Input(string item, double amount, string type = null)
        { return new RecipePart(type, item, amount, true); }
        public static RecipePart Output(string item, double amount, string type = null)
        { return new RecipePart(type, item, amount, false); }

        public Direction Direction { get; private set; }

        private RecipePart(string type, string item, double amount, bool input)
        {
            Direction = input ? Direction.Input : Direction.Output;

            Type = type ?? "item";
            Item = item;
            Amount = amount;
        }

        private RecipePart(string item, double amount, bool input = true) : this("item", item, amount, input)
        { }

        private RecipePart(JToken token, bool input = true)
        {
            Direction = input ? Direction.Input : Direction.Output;

            if (token.Type == JTokenType.Object)
            {
                dynamic source = token;

                Type = source.type ?? "item";
                Item = source.name;
                Amount = source.amount;
            }
            else if (token.Type == JTokenType.Array)
            {
                Item = token[0].Value<string>();
                Amount = token[1].Value<double>();
            }

        }

        public string Type { get; set; }
        public string Item { get; set; }
        public object Amount { get; set; }

        public override string ToString()
        {
            return $"{Type}: '{Item}', {Amount}";
        }
    }
}