namespace ExamFinal.Advance;
//records are designed to be immutable by default, which means their properties cannot be modified once the record is
//created.

public record  AdvanceRECORD
{
    public string Name { get; init; }
    public int Age { get; init; }
}


