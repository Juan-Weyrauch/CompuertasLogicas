namespace Library;

public class And : LogicGate{
    public override bool Evaluate(params bool[] inputs)
    {
        if (inputs.Length < 2) throw new ArgumentException("And gate requires at least two inputs");
        return inputs.All(input => input);
    }
}