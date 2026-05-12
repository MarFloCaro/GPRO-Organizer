using System;

#nullable disable
namespace go
{
    [Serializable]
    public class Date
    {
        public int season;
        public int race;

        public Date Clone()
        {
            return new Date()
            {
                season = this.season,
                race = this.race
            };
        }

        public bool IsEqual(Date date) => this.race == date.race && this.season == date.season;
    }
}
