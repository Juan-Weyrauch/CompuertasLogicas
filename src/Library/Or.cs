using System;

namespace Library{ 

    public class Or : LogicGate
{
    public override bool Evaluate(params bool[] inputs)
    {
        if (inputs.Length < 2) throw new ArgumentException("Or gate requires at least two inputs");
        return inputs.Any(input => input);
    }
}
}