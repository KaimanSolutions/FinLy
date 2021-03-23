using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum CompanyTypes
    {
        [Display(Name = "Private unlimited company")]
        PrivateUnlimited = 0,

        [Display(Name = "Private limited company")]
        Ltd = 1,

        [Display(Name = "Public limited company")]
        Plc = 2,

        [Display(Name = "Old public company")]
        OldPubliccompany = 3,

        [Display(Name="Private Limited Company by guarantee without share capital, use of 'Limited' exemption")]
        PrivateLimitedGuaranteeNSCLimitedExemption = 4,

        [Display(Name = "Limited partnership")]
        LimitedPartnership = 5,

        [Display(Name = "Private limited by guarantee without share capital")]
        PrivateLimitedGuaranteeNSC = 6,

        [Display(Name = "Converted / Closed")]
        ConvertedOrClosed = 7,

        [Display(Name="Private unlimited company without share capital")]
        PrivateUnlimitedNSC = 8,

        [Display(Name="Private Limited Company, use of 'Limited' exemption")]
        PrivateLimitedSharesSection30Exemption = 9,

        [Display(Name="Assurance Company")]
        AssuranceCompany = 10,

        [Display(Name = "Overseas Company")]
        OverseaCompany = 11,

        [Display(Name = "European economic interest group (EEIG)")]
        EEIG = 12,

        [Display(Name="Investment company with variable capital")]
        ICVCSecurities = 13,

        [Display(Name="Investment company with variable capital")]
        ICVCWarrant = 14,

        [Display(Name="Investment company with variable capital")]
        ICVCUmbrella = 15,

        [Display(Name="Industrial and Provident Society")]
        IndustrialAndProvidentSociety = 16,

        [Display(Name="Northern Ireland company")]
        NorthernIreland = 17,

        [Display(Name="Credit union (Northern Ireland)")]
        NortherIrelandOther = 18,

        [Display(Name="Royal Charter company")]
        RoyalCharter = 19,
        
        [Display(Name="Investment company with variable capital")]
        InvestmentCompanyWithVariableCapital = 20,

        [Display(Name="Unregistered company")]
        UnregisteredCompany = 21,

        [Display(Name = "Limited Liability Partnership")]
        Llp = 22,

        [Display(Name="Other company type")]
        Other = 23,
        
        [Display(Name="European public limited liability company (SE)")]
        EuropeanPublicLimitedLiabilityCompany = 24,

        [Display(Name = "Protected cell company")]
        ProtectedCellCompany = 25,

        [Display(Name = "UK establishment company")]
        UKEstablishment = 26,

        [Display(Name = "Scottish qualifying partnership")]
        ScottishPartnership = 27,

        [Display(Name = "Charitable incorporated organisation")]
        CharitableIncOrganisation = 28,

        [Display(Name = "Scottish charitable incorporated organisation")]
        ScottishCharitableIncOrganisation = 29,

        [Display(Name = "Further education or sixth form college corporation")]
        FurtherEducationOrSixthForm = 30
    }
}