namespace DesafioPratico01_Rocketseat;

public class ValidaPlacaDeVeiculos
{
    public static bool ValidarPlaca(string placa)
    {
        if (placa.Length != 7)
        {
            return false;
        }
        for (int i = 0; i < 3; i++)
        {
            if (!Char.IsLetter(placa[i]))
            {
                return false;
            }
        }
        for (int i = 3; i < 7; i++)
        {
            if (!Char.IsDigit(placa[i]))
            {
                return false;
            }
        }

        return true;
    }
}
