namespace Library;

public class Or : IPuertaLogica
{
    public bool Funcion(List<bool> listaBools)
    {
        if (listaBools[0] || listaBools[1])
        {
            return true;
        }
        else return false;
    }
}