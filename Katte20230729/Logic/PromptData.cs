namespace Katte20230729.Logic
{
    public class PromptData
    {
        public string Prompt { get; set; } = string.Empty;
        public string PromptExplanation { get; set; } = string.Empty;

        public void Clear()
        {
            Prompt = string.Empty;
            PromptExplanation = string.Empty;
        }
    }
}
