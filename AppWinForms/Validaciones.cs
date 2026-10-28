namespace AppWinForms
{
    public static class Validaciones
    {
        public static bool SoloDigitos(string valor)
        {
            return valor
                .All(char.IsDigit);
        }

        public static bool CuitValido(string cuit)
        {
            string digitos = new string(cuit.Where(char.IsDigit).ToArray());

            if (digitos.Length != 11)
                return false;

            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < multiplicadores.Length; i++)
                suma += (digitos[i] - '0') * multiplicadores[i];

            int resto = 11 - (suma % 11);
            int digitoVerificador = resto == 11 ? 0 : resto == 10 ? 9 : resto;

            return digitoVerificador == digitos[10] - '0';
        }

        public static string FormatearCuit(string cuit)
        {
            string digitos = new string(cuit.Where(char.IsDigit).ToArray());

            return $"{digitos.Substring(0, 2)}-{digitos.Substring(2, 8)}-{digitos.Substring(10, 1)}";
        }

        public static bool TelefonoValido(string telefono)
        {
            if (!telefono.All(c => char.IsDigit(c) || c == ' ' || c == '-' || c == '+' || c == '(' || c == ')'))
                return false;

            int cantidadDigitos = telefono
                .Count(char.IsDigit);

            return cantidadDigitos >= 6 && cantidadDigitos <= 15;
        }

        public static void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
