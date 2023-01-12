using Application.Common.Interfaces;

namespace Infrastructure.Services;

public class DatetimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
