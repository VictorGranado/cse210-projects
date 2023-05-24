namespace Develop02
{
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;

        public string GetAsString()
        {
            return $"{date}\n{prompt}\n{response}\n";
        }
        public void Store(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }

}