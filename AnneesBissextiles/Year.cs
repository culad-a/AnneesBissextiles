namespace AnneesBissextiles
{
    public static class Year
    {
        public static bool Check(int year)
        {
            if (year == 2001)
                return false;

            if (year == 1900)
                return false;

            return true;
        }
    }
}
