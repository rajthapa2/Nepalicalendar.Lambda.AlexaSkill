namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public interface IDateConverter
    {
        BCDate Convert(int daysDiff);
    }
}
