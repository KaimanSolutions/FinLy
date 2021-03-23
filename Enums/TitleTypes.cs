using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum TitleTypes
    {
        Mr = 0,
        Miss = 1,

        Mrs = 2,
        
        Ms = 3,

        Mx = 4,

        Dr = 5,

        Prof = 6,

        QC = 7,

        Chancellor = 8,

        [Display(Name = "Vice-Chancellor")]
        ViceChancellor = 9,

        Sir = 10,

        Gentleman = 11,

        Sire = 12,

        Mistress = 13,

        Madam = 14,

        Dame = 15,

        Lord = 16,

        Lady = 17,

        Esq = 18,

        Excellency = 19,
        
        [Display(Name = "Your Honour")]
        HerHisHonour = 20,

        Rev = 21,
    }
}