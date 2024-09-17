using System;

namespace Library; 

public class Not : LogicGate
{
    public override bool Evaluate(params bool[] inputs)
    {
        if (inputs.Length != 1) throw new ArgumentException("Not gate requires exactly one input");
        return !inputs[0];
    }
}
