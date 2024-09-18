using Library;

namespace DefaultNamespace;

public class Not: IPuertaLogica
{
    public bool Funcion(List<bool> listaBools)
    {
            return !listaBools[0]; // Retorna el valor booleano opuesto al que entro.
    }
    
}