using AppShoppingCenter.Models;
using System.Globalization;

namespace AppShoppingCenter.Libraries.Converters;

public class TimeSpanToTimeStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // 1. Verificação de segurança: Se for nulo ou não for um objeto do tipo Ticket, retorna vazio
        if (value == null || value is not Ticket ticket)
        {
            return string.Empty;
        }

        // 2. Verificação de segurança: Se a Data de Saída não foi definida (ainda é MinValue), retorna 00h 00m
        if (ticket.DateOut == DateTime.MinValue)
        {
            return "00h 00m";
        }

        // 3. Cálculo da diferença
        var dif = ticket.DateOut - ticket.DateIn;

        // 4. Formatação
        return string.Format("{0:D2}h {1:D2}m", dif.Hours, dif.Minutes);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}