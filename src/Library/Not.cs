using Library;


public class Not: IPuertaLogica
{
    public bool Funcion(List<bool> listaBools) // Unicamente devuelve el primer valor de entrada.
    {
            return !listaBools[0]; // Retorna el valor booleano opuesto al que entro.
    }
    
}