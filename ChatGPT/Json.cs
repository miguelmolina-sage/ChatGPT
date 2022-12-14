namespace ChatGPT;

// https://beta.openai.com/docs/api-reference/completions/create
public class RequestBody
{
    public string model { get; set; }
    public string prompt { get; set; } = "";
    public string suffix { get; set; } = null;
    public int max_tokens { get; set; } = 16;
    public decimal temperature { get; set; } = 1;
    public decimal top_p { get; set; } = 1;
    public int n { get; set; } = 1;
    public bool stream { get; set; } = false;
    public int? logprobs { get; set; } = null;
    public bool echo { get; set; } = false;
    public string stop { get; set; } = null;
    public decimal presence_penalty { get; set; } = 0;
    public decimal frequency_penalty { get; set; } = 0;
    public int best_of { get; set; } = 1;
    public Dictionary<string, decimal> logit_bias { get; set; } = null;
    public string user { get; set; }
}

public class ApiResponse
{
    public string id { get; set; }
    public string @object { get; set; } // Escaped with @ symbol
    public int created { get; set; }
    public string model { get; set; }
    public Choice[] choices { get; set; }
    public Usage usage { get; set; }
}

public class Choice
{
    public string text { get; set; }
    public int index { get; set; }
    public object logprobs { get; set; }
    public string finish_reason { get; set; }
}

public class Usage
{
    public int prompt_tokens { get; set; }
    public int completion_tokens { get; set; }
    public int total_tokens { get; set; }
}
