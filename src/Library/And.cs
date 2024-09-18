namespace Library;

public class And : IPuertaLogica
{
    public bool Funcion(List<bool> listaBools) //  Metodo que permite acceder a los elementos de una lista.
    {

    if (listaBools[0] && listaBools[1]) // En el caso de que si fueran mas de tres elementos en la lista ,unicamente usuaria los dos primeros.
        {
            return true;
        }
        else return false;
    }
}