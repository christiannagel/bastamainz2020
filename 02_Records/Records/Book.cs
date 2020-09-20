using System;

namespace Records
{
    public record Book(string Title, string Publisher, string? Isbn = default) 
    {
    }
}
