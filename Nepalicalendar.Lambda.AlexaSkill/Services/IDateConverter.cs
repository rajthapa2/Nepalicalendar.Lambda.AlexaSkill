namespace NepaliCalendar.Lambda.AlexaSkill.Services
{
    public interface IDateConverter
    {
        BCDate Convert(int daysDiff);
    }
}
