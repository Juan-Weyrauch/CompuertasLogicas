
namespace Library;
public class GarageGate : IPuertaLogica
{
    public bool Funcion(List<bool> listaBools)
    {
        bool ValorA = listaBools[0];
        bool ValorB = listaBools[1];
        bool ValorC = listaBools[2];
        And and = new And();
        Or or = new Or();
        Not not = new Not();
        
        bool AndAB = and.Funcion([ ValorA, ValorB]);
        bool NotB = not.Funcion([ValorB]);
        bool NotA = not.Funcion([ValorA]);
        bool AndNotANotB = and.Funcion([NotA,NotB]);
        bool OrAB = or.Funcion([AndAB,AndNotANotB]);
        bool AndABC = and.Funcion([ValorC,OrAB]);
        return AndABC;
        
    }
}