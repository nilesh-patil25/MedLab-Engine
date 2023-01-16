/*
 * Date:29/11/2022
 * Class : PatientClass
 */
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HIS.APP.Models
{
    #region Model
    /// <summary>
    /// Patient Class for deserializing SipPlus data
    /// </summary>
    public class PatientClass
    {
        [JsonProperty("1249")]
        public string? ITSSId { get; set; }
        public string PatientId { get; set; }

        [JsonProperty("0001")]
        public string FirstName { get; set; }

        [JsonProperty("pregnancies")]
        public Pregnancies Pregnancies { get; set; }

        [JsonProperty("0011")]
        public int Ethnicity { get; set; }

        [JsonProperty("0002")]
        public string LastName { get; set; }

        [JsonProperty("0006")]
        public string DateOfBirth { get; set; }

        [JsonProperty("F200")]
        public string F200 { get; set; }

        [JsonProperty("F012")]
        public bool F012 { get; set; }

        [JsonProperty("1018")]
        public string CountryId { get; set; }

        [JsonProperty("F201")]
        public string F201 { get; set; }

        [JsonProperty("0019")]
        public string Record { get; set; }

        [JsonProperty("forms")]
        public List<Form> Forms { get; set; }

        [JsonProperty("1019")]
        public string IdType { get; set; }
    }
    public class _0018
    {
        [JsonProperty("countryId")]
        public string CountryId { get; set; }

        [JsonProperty("divisionId")]
        public string DivisionId { get; set; }

        [JsonProperty("subdivisionId")]
        public string SubdivisionId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class _0372
    {
        [JsonProperty("countryId")]
        public string CountryId { get; set; }

        [JsonProperty("divisionId")]
        public string DivisionId { get; set; }

        [JsonProperty("subdivisionId")]
        public string SubdivisionId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class _0381
    {
        [JsonProperty("countryId")]
        public string CountryId { get; set; }

        [JsonProperty("divisionId")]
        public string DivisionId { get; set; }

        [JsonProperty("subdivisionId")]
        public string SubdivisionId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DemographicsInformation
    {
        [JsonProperty("0846")]
        public NoYesNaNdEnum _0846 { get; set; }

        [JsonProperty("0659")]
        public NoYesNaNdEnum _0659 { get; set; }

        [JsonProperty("0087")]
        public NoYesNaNdEnum _0087 { get; set; }

        [JsonProperty("0058")]
        public string _0058 { get; set; }

        [JsonProperty("1183")]
        public string _1183 { get; set; }

        [JsonProperty("0085")]
        public string _0085 { get; set; }

        [JsonProperty("1250")]
        public int _1250 { get; set; }

        [JsonProperty("1251")]
        public bool _1251 { get; set; }

        [JsonProperty("1252")]
        public int _1252 { get; set; }
        [JsonProperty("1253")]
        public bool _1253 { get; set; }

        [JsonProperty("1254")]
        public int _1254 { get; set; }
        [JsonProperty("1255")]
        public bool _1255 { get; set; }

        [JsonProperty("1256")]
        public int _1256 { get; set; }

        [JsonProperty("1257")]
        public bool _1257 { get; set; }

        [JsonProperty("1258")]
        public int _1258 { get; set; }

        [JsonProperty("1259")]
        public bool _1259 { get; set; }

        [JsonProperty("1260")]
        public int _1260 { get; set; }

        [JsonProperty("1261")]
        public bool _1261 { get; set; }

        [JsonProperty("F105")]
        public string F105 { get; set; }

        [JsonProperty("B007")]
        public double B007 { get; set; }

        [JsonProperty("B000")]
        public double B000 { get; set; }

        [JsonProperty("B003")]
        public double B003 { get; set; }

        [JsonProperty("B008")]
        public int B008 { get; set; }

        [JsonProperty("B005")]
        public double B005 { get; set; }

        [JsonProperty("B006")]
        public double B006 { get; set; }

        [JsonProperty("B001")]
        public double B001 { get; set; }

        [JsonProperty("0008")]
        public string CountryofResidence { get; set; }

        [JsonProperty("0007")]
        public string Nationality { get; set; }

        [JsonProperty("0009")]
        public int Age { get; set; }

        [JsonProperty("0013")]
        public int Education { get; set; }

        [JsonProperty("0012")]
        public int Literacy { get; set; }

        [JsonProperty("0014")]
        public int YearsinHighestLevel { get; set; }

        [JsonProperty("0015")]
        public int CivilStatus { get; set; }

        [JsonProperty("0016")]
        public int LivesAlone { get; set; }

        [JsonProperty("0020")]
        public int _0020 { get; set; }

        [JsonProperty("0022")]
        public int _0022 { get; set; }

        [JsonProperty("0024")]
        public int _0024 { get; set; }

        [JsonProperty("0026")]
        public int _0026 { get; set; }

        [JsonProperty("0028")]
        public int _0028 { get; set; }

        [JsonProperty("0030")]
        public int _0030 { get; set; }

        [JsonProperty("0023")]
        public int _0023 { get; set; }

        [JsonProperty("0021")]
        public int _0021 { get; set; }

        [JsonProperty("0025")]
        public int _0025 { get; set; }

        [JsonProperty("0027")]
        public int _0027 { get; set; }

        [JsonProperty("0029")]
        public int _0029 { get; set; }

        [JsonProperty("0031")]
        public int _0031 { get; set; }

        [JsonProperty("0032")]
        public int _0032 { get; set; }

        [JsonProperty("0033")]
        public int _0033 { get; set; }

        [JsonProperty("0034")]
        public int _0034 { get; set; }

        [JsonProperty("0035")]
        public int _0035 { get; set; }

        [JsonProperty("0036")]
        public int _0036 { get; set; }

        [JsonProperty("0432")]
        public int _0432 { get; set; }

        [JsonProperty("0793")]
        public int _0793 { get; set; }

        [JsonProperty("0794")]
        public int _0794 { get; set; }

        [JsonProperty("0795")]
        public int _0795 { get; set; }

        [JsonProperty("0796")]
        public int _0796 { get; set; }

        [JsonProperty("0843")]
        public int _0843 { get; set; }

        [JsonProperty("0037")]
        public string _0037 { get; set; }

        [JsonProperty("0040")]
        public int _0040 { get; set; }

        [JsonProperty("0042")]
        public int _0042 { get; set; }

        [JsonProperty("0044")]
        public int _0044 { get; set; }

        [JsonProperty("0050")]
        public int _0050 { get; set; }

        [JsonProperty("0049")]
        public int _0049 { get; set; }

        [JsonProperty("0409")]
        public int _0409 { get; set; }

        [JsonProperty("0043")]
        public int _0043 { get; set; }

        [JsonProperty("0048")]
        public int _0048 { get; set; }

        [JsonProperty("0041")]
        public int _0041 { get; set; }

        [JsonProperty("0046")]
        public int _0046 { get; set; }

        [JsonProperty("0047")]
        public int _0047 { get; set; }

        [JsonProperty("0038")]
        public int _0038 { get; set; }

        [JsonProperty("0039")]
        public int _0039 { get; set; }

        [JsonProperty("0054")]
        public int _0054 { get; set; }

        [JsonProperty("0053")]
        public int _0053 { get; set; }

        [JsonProperty("0051")]
        public string _0051 { get; set; }

        [JsonProperty("0055")]
        public int _0055 { get; set; }

        [JsonProperty("0711")]
        public int _0711 { get; set; }

        [JsonProperty("0056")]
        public int _0056 { get; set; }

        [JsonProperty("0082")]
        public int _0082 { get; set; }

        [JsonProperty("0084")]
        public int _0084 { get; set; }

        [JsonProperty("0083")]
        public int _0083 { get; set; }

        [JsonProperty("0103")]
        public NormalAbnormalNotDone _0103 { get; set; }

        [JsonProperty("0104")]
        public NormalAbnormalNotDone _0104 { get; set; }

        [JsonProperty("0086")]

        public RhpositiveEnum _0086 { get; set; }

        [JsonProperty("0410")]
        public NoYesNaNdEnum _0410 { get; set; }

        [JsonProperty("0585")]
        public int _0585 { get; set; }

        [JsonProperty("0057")]
        public string _0057 { get; set; }

        [JsonProperty("0059")]
        public int _0059 { get; set; }

        [JsonProperty("0060")]
        public int _0060 { get; set; }

        [JsonProperty("0061")]
        public int _0061 { get; set; }

        [JsonProperty("0066")]
        public int _0066 { get; set; }

        [JsonProperty("0072")]
        public int _0072 { get; set; }

        [JsonProperty("0073")]
        public int _0073 { get; set; }

        [JsonProperty("0071")]
        public int _0071 { get; set; }

        [JsonProperty("0062")]
        public int _0062 { get; set; }

        [JsonProperty("0067")]
        public int _0067 { get; set; }

        [JsonProperty("0068")]
        public int _0068 { get; set; }

        [JsonProperty("0063")]
        public int _0063 { get; set; }

        [JsonProperty("0064")]
        public int _0064 { get; set; }

        [JsonProperty("0069")]
        public int _0069 { get; set; }

        [JsonProperty("0074")]
        public int _0074 { get; set; }

        [JsonProperty("0065")]
        public int _0065 { get; set; }

        [JsonProperty("0075")]
        public int _0075 { get; set; }

        [JsonProperty("0077")]
        public int _0077 { get; set; }

        [JsonProperty("0797")]
        public SickleCellenum _0797 { get; set; }

        [JsonProperty("0080")]
        public int _0080 { get; set; }

        [JsonProperty("0845")]
        public int _0845 { get; set; }

        [JsonProperty("0081")]
        public int _0081 { get; set; }

        [JsonProperty("0798")]
        public int _0798 { get; set; }

        [JsonProperty("0799")]
        public bool _0799 { get; set; }

        [JsonProperty("0097")]
        public int _0097 { get; set; }

        [JsonProperty("0098")]
        public int _0098 { get; set; }

        [JsonProperty("0109")]
        public RhnegativeEnum _0109 { get; set; }

        [JsonProperty("0110")]
        public NoYesNdNaEnum _0110 { get; set; }

        [JsonProperty("0111")]
        public int _0111 { get; set; }

        [JsonProperty("0656")]
        public NoYesNaNdEnum _0656 { get; set; }

        [JsonProperty("0657")]
        public YesNoNaEnum _0657 { get; set; }

        [JsonProperty("0660")]
        public YesNoNaEnum _0660 { get; set; }

        [JsonProperty("0662")]
        public NoYesNaNdEnum _0662 { get; set; }

        [JsonProperty("0663")]
        public YesNoNaEnum _0663 { get; set; }

        [JsonProperty("0658")]
        public NoYesNaNdEnum _0658 { get; set; }

        [JsonProperty("0661")]
        public NoYesNaNdEnum _0661 { get; set; }

        [JsonProperty("0664")]
        public NoYesNaNdEnum _0664 { get; set; }

        [JsonProperty("0849")]
        public NoYesNaNdEnum _0849 { get; set; }

        [JsonProperty("0850")]
        public YesNoNaEnum _0850 { get; set; }

        [JsonProperty("0852")]
        public NoYesNaNdEnum _0852 { get; set; }

        [JsonProperty("0853")]
        public YesNoNaEnum _0853 { get; set; }

        [JsonProperty("0856")]
        public YesNoNaEnum _0856 { get; set; }

        [JsonProperty("0855")]
        public NoYesNaNdEnum _0855 { get; set; }

        [JsonProperty("0851")]
        public NoYesNaNdEnum _0851 { get; set; }

        [JsonProperty("0854")]
        public NoYesNaNdEnum _0854 { get; set; }

        [JsonProperty("0857")]
        public NoYesNaNdEnum _0857 { get; set; }

        [JsonProperty("0875")]
        public string _0875 { get; set; }

        [JsonProperty("0678")]
        public NoYesNdNaEnum _0678 { get; set; }

        [JsonProperty("0685")]
        public NoYesNdNaEnum _0685 { get; set; }

        [JsonProperty("0876")]
        public int _0876 { get; set; }

        [JsonProperty("0800")]
        public int _0800 { get; set; }

        [JsonProperty("0801")]
        public bool _0801 { get; set; }

        [JsonProperty("0877")]
        public bool _0877 { get; set; }

        [JsonProperty("0078")]
        public int _0078 { get; set; }

        [JsonProperty("0079")]
        public int _0079 { get; set; }

        [JsonProperty("0183")]
        public string _0183 { get; set; }

        [JsonProperty("0186")]
        public int _0186 { get; set; }

        [JsonProperty("0185")]
        public int _0185 { get; set; }

        [JsonProperty("0188")]
        public int _0188 { get; set; }

        [JsonProperty("0189")]
        public int _0189 { get; set; }

        [JsonProperty("0190")]
        public int _0190 { get; set; }

        [JsonProperty("0191")]
        public int _0191 { get; set; }

        [JsonProperty("0192")]
        public string _0192 { get; set; }

        [JsonProperty("0257")]
        public int _0257 { get; set; }

        [JsonProperty("0258")]
        public int _0258 { get; set; }

        [JsonProperty("0745")]
        public int _0745 { get; set; }

        [JsonProperty("0260")]
        public int _0260 { get; set; }

        [JsonProperty("0653")]
        public int _0653 { get; set; }

        [JsonProperty("0498")]
        public int _0498 { get; set; }

        [JsonProperty("0652")]
        public int _0652 { get; set; }

        [JsonProperty("0651")]
        public int _0651 { get; set; }

        [JsonProperty("0261")]
        public int _0261 { get; set; }

        [JsonProperty("0650")]
        public int _0650 { get; set; }

        [JsonProperty("X003")]
        public int X003 { get; set; }

        [JsonProperty("0259")]
        public int _0259 { get; set; }

        [JsonProperty("0878")]
        public int _0878 { get; set; }

        [JsonProperty("0262")]
        public int _0262 { get; set; }

        [JsonProperty("0263")]
        public int _0263 { get; set; }

        [JsonProperty("0264")]
        public int _0264 { get; set; }

        [JsonProperty("0266")]
        public int _0266 { get; set; }

        [JsonProperty("0267")]
        public int _0267 { get; set; }

        [JsonProperty("0268")]
        public int _0268 { get; set; }

        [JsonProperty("0269")]
        public int _0269 { get; set; }

        [JsonProperty("0270")]
        public int _0270 { get; set; }

        [JsonProperty("0860")]
        public int _0860 { get; set; }

        [JsonProperty("0271")]
        public int _0271 { get; set; }

        [JsonProperty("0861")]
        public int _0861 { get; set; }

        [JsonProperty("0272")]
        public int _0272 { get; set; }

        [JsonProperty("0273")]
        public int _0273 { get; set; }

        [JsonProperty("0274")]
        public int _0274 { get; set; }

        [JsonProperty("0275")]
        public int _0275 { get; set; }

        [JsonProperty("0276")]
        public int _0276 { get; set; }

        [JsonProperty("0277")]
        public int _0277 { get; set; }

        [JsonProperty("0202")]
        public int _0202 { get; set; }

        [JsonProperty("0203")]
        public int _0203 { get; set; }

        [JsonProperty("0204")]
        public int _0204 { get; set; }

        [JsonProperty("0205")]
        public int _0205 { get; set; }

        [JsonProperty("0198")]
        public int _0198 { get; set; }

        [JsonProperty("0199")]
        public int _0199 { get; set; }

        [JsonProperty("0200")]
        public bool _0200 { get; set; }

        [JsonProperty("0201")]
        public bool _0201 { get; set; }

        [JsonProperty("0278")]
        public string _0278 { get; set; }

        [JsonProperty("0279")]
        public string _0279 { get; set; }

        [JsonProperty("0280")]
        public string _0280 { get; set; }

        [JsonProperty("0439")]
        public int _0439 { get; set; }

        [JsonProperty("0437")]
        public int _0437 { get; set; }

        [JsonProperty("0438")]
        public int _0438 { get; set; }

        [JsonProperty("labor")]
        public Labor Labor { get; set; }

        [JsonProperty("0206")]
        public int _0206 { get; set; }

        [JsonProperty("children")]
        public Children Children { get; set; }

        [JsonProperty("0285")]
        public int _0285 { get; set; }

        [JsonProperty("0307")]
        public int _0307 { get; set; }

        [JsonProperty("0305")]
        public int _0305 { get; set; }

        [JsonProperty("0304")]
        public int _0304 { get; set; }

        [JsonProperty("0440")]
        public int _0440 { get; set; }

        [JsonProperty("0643")]
        public int _0643 { get; set; }

        [JsonProperty("0810")]
        public int _0810 { get; set; }

        [JsonProperty("0308")]
        public string _0308 { get; set; }

        [JsonProperty("0309")]
        public string _0309 { get; set; }

        [JsonProperty("0382")]
        public int _0382 { get; set; }

        [JsonProperty("0383")]
        public int _0383 { get; set; }

        [JsonProperty("0381")]
        public _0381 _0381 { get; set; }

        [JsonProperty("0384")]
        public int _0384 { get; set; }

        [JsonProperty("0385")]
        public int _0385 { get; set; }

        [JsonProperty("0386")]
        public int _0386 { get; set; }

        [JsonProperty("0391")]
        public string _0391 { get; set; }

        [JsonProperty("0871")]
        public string _0871 { get; set; }

        [JsonProperty("0379")]
        public string _0379 { get; set; }

        [JsonProperty("puerperium")]
        public Puerperium Puerperium { get; set; }

        [JsonProperty("prenatal")]
        public Prenatal Prenatal { get; set; }

        [JsonProperty("0018")]
        public _0018 PlaceOfBirth_Abortion { get; set; }

        [JsonProperty("F100")]
        public string F100 { get; set; }

        [JsonProperty("F101")]
        public string F101 { get; set; }

        [JsonProperty("F102")]
        public string F102 { get; set; }

        [JsonProperty("F103")]
        public string F103 { get; set; }

        [JsonProperty("0665")]
        public RhnegativeEnum _0665 { get; set; }

        [JsonProperty("0666")]
        public int _0666 { get; set; }

        [JsonProperty("0667")]
        public RhnegativeEnum _0667 { get; set; }

        [JsonProperty("0668")]
        public int _0668 { get; set; }
        [JsonProperty("0669")]
        public NoYesNdNaEnum _0669 { get; set; }

        [JsonProperty("0670")]
        public int _0670 { get; set; }

        [JsonProperty("0671")]
        public NoYesNdNaEnum _0671 { get; set; }

        [JsonProperty("0672")]
        public RhnegativeEnum _0672 { get; set; }
        [JsonProperty("0673")]
        public int _0673 { get; set; }
        [JsonProperty("0674")]
        public RhnegativeEnum _0674 { get; set; }

        [JsonProperty("0675")]
        public int _0675 { get; set; }

        [JsonProperty("0676")]
        public NoYesNdNaEnum _0676 { get; set; }

        [JsonProperty("0677")]
        public int _0677 { get; set; }

        [JsonProperty("0679")]
        public RhnegativeEnum _0679 { get; set; }
        [JsonProperty("0680")]
        public int _0680 { get; set; }

        [JsonProperty("0681")]
        public RhnegativeEnum _0681 { get; set; }

        [JsonProperty("0682")]
        public int _0682 { get; set; }

        [JsonProperty("0683")]
        public NoYesNdNaEnum _0683 { get; set; }

        [JsonProperty("0684")]
        public int _0684 { get; set; }

        [JsonProperty("0184")]
        public int _0184 { get; set; }

        [JsonProperty("0302")]
        public int _0302 { get; set; }

        [JsonProperty("0808")]
        public int _0808 { get; set; }

        [JsonProperty("0301")]
        public int _0301 { get; set; }

        [JsonProperty("0300")]
        public int _0300 { get; set; }

        [JsonProperty("0303")]
        public int _0303 { get; set; }

        [JsonProperty("0193")]
        public string _0193 { get; set; }

        [JsonProperty("0197")]
        public int _0197 { get; set; }

        [JsonProperty("0194")]
        public bool _0194 { get; set; }

        [JsonProperty("0187")]
        public int _0187 { get; set; }

        [JsonProperty("0003")]
        public string Address { get; set; }

        [JsonProperty("0005")]
        public string Phone { get; set; }

        [JsonProperty("0213")]
        public string _0213 { get; set; }

        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("0215")]
        public string _0215 { get; set; }

        [JsonProperty("0207")]
        public string _0207 { get; set; }

        [JsonProperty("0209")]
        public string _0209 { get; set; }

        [JsonProperty("0210")]
        public int _0210 { get; set; }

        [JsonProperty("0392")]
        public int _0392 { get; set; }

        [JsonProperty("0211")]
        public int _0211 { get; set; }

        [JsonProperty("0212")]
        public int _0212 { get; set; }

        [JsonProperty("0214")]
        public string _0214 { get; set; }

        [JsonProperty("0216")]
        public int _0216 { get; set; }

        [JsonProperty("0282")]
        public int _0282 { get; set; }

        [JsonProperty("0291")]
        public int _0291 { get; set; }

        [JsonProperty("0292")]
        public int _0292 { get; set; }

        [JsonProperty("0283")]
        public string _0283 { get; set; }

        [JsonProperty("0284")]
        public string _0284 { get; set; }

        [JsonProperty("0287")]
        public int _0287 { get; set; }

        [JsonProperty("0288")]
        public string _0288 { get; set; }

        [JsonProperty("0289")]
        public string _0289 { get; set; }

        [JsonProperty("0290")]
        public string _0290 { get; set; }

        [JsonProperty("0297")]
        public int _0297 { get; set; }

        [JsonProperty("0862")]
        public int _0862 { get; set; }

        [JsonProperty("0293")]
        public bool _0293 { get; set; }

        [JsonProperty("0299")]
        public int _0299 { get; set; }

        [JsonProperty("0310")]
        public int _0310 { get; set; }

        [JsonProperty("0335")]
        public int _0335 { get; set; }

        [JsonProperty("0336")]
        public int _0336 { get; set; }

        [JsonProperty("0441")]
        public int _0441 { get; set; }

        [JsonProperty("0866")]
        public int _0866 { get; set; }

        [JsonProperty("0412")]
        public int _0412 { get; set; }

        [JsonProperty("0811")]
        public int _0811 { get; set; }

        [JsonProperty("0736")]
        public int _0736 { get; set; }

        [JsonProperty("0345")]
        public int _0345 { get; set; }

        [JsonProperty("0346")]
        public int _0346 { get; set; }

        [JsonProperty("0867")]
        public int _0867 { get; set; }

        [JsonProperty("0446")]
        public int _0446 { get; set; }

        [JsonProperty("0348")]
        public int _0348 { get; set; }

        [JsonProperty("0869")]
        public int _0869 { get; set; }

        [JsonProperty("0870")]
        public int _0870 { get; set; }

        [JsonProperty("0331")]
        public int _0331 { get; set; }

        [JsonProperty("0333")]
        public int _0333 { get; set; }

        [JsonProperty("0332")]
        public string _0332 { get; set; }

        [JsonProperty("0334")]
        public string _0334 { get; set; }

        [JsonProperty("0323")]
        public int _0323 { get; set; }

        [JsonProperty("0324")]
        public int _0324 { get; set; }

        [JsonProperty("0325")]
        public int _0325 { get; set; }

        [JsonProperty("0863")]
        public int _0863 { get; set; }

        [JsonProperty("0864")]
        public int _0864 { get; set; }

        [JsonProperty("0328")]
        public int _0328 { get; set; }

        [JsonProperty("0445")]
        public int _0445 { get; set; }

        [JsonProperty("0330")]
        public int _0330 { get; set; }

        [JsonProperty("0329")]
        public int _0329 { get; set; }

        [JsonProperty("0317")]
        public bool _0317 { get; set; }

        [JsonProperty("0320")]
        public int _0320 { get; set; }

        [JsonProperty("0311")]
        public int _0311 { get; set; }

        [JsonProperty("0312")]
        public int _0312 { get; set; }

        [JsonProperty("0314")]
        public int _0314 { get; set; }

        [JsonProperty("0315")]
        public int _0315 { get; set; }

        [JsonProperty("0316")]
        public int _0316 { get; set; }

        [JsonProperty("0321")]
        public int _0321 { get; set; }

        [JsonProperty("0322")]
        public int _0322 { get; set; }

        [JsonProperty("0865")]
        public int _0865 { get; set; }

        [JsonProperty("0337")]
        public string _0337 { get; set; }

        [JsonProperty("0339")]
        public string _0339 { get; set; }

        [JsonProperty("0341")]
        public string _0341 { get; set; }

        [JsonProperty("0368")]
        public string _0368 { get; set; }

        [JsonProperty("0371")]
        public int _0371 { get; set; }

        [JsonProperty("0373")]
        public int _0373 { get; set; }

        [JsonProperty("0374")]
        public int _0374 { get; set; }

        [JsonProperty("0376")]
        public int _0376 { get; set; }

        [JsonProperty("0818")]
        public int _0818 { get; set; }

        [JsonProperty("0377")]
        public int _0377 { get; set; }

        [JsonProperty("0350")]
        public int _0350 { get; set; }

        [JsonProperty("0872")]
        public string _0872 { get; set; }

        [JsonProperty("0372")]
        public _0372 _0372 { get; set; }

        [JsonProperty("0388")]
        public string _0388 { get; set; }

        [JsonProperty("0395")]
        public int _0395 { get; set; }

        [JsonProperty("0425")]
        public string _0425 { get; set; }

        [JsonProperty("0370")]
        public string _0370 { get; set; }

        [JsonProperty("0343")]
        public int _0343 { get; set; }

        [JsonProperty("0338")]
        public string _0338 { get; set; }

        [JsonProperty("0340")]
        public string _0340 { get; set; }

        [JsonProperty("0342")]
        public string _0342 { get; set; }

        [JsonProperty("0868")]
        public string _0868 { get; set; }

        [JsonProperty("0812")]
        public int _0812 { get; set; }

        [JsonProperty("0813")]
        public int _0813 { get; set; }

        [JsonProperty("0351")]
        public int _0351 { get; set; }

        [JsonProperty("0406")]
        public int _0406 { get; set; }

        [JsonProperty("0353")]
        public int _0353 { get; set; }

        [JsonProperty("0354")]
        public string _0354 { get; set; }

        [JsonProperty("0355")]
        public string _0355 { get; set; }

        [JsonProperty("0116")]
        public string _0116 { get; set; }

        [JsonProperty("0119")]
        public int _0119 { get; set; }

        [JsonProperty("0120")]
        public int _0120 { get; set; }

        [JsonProperty("0858")]
        public int _0858 { get; set; }

        [JsonProperty("0122")]
        public int _0122 { get; set; }

        [JsonProperty("0123")]
        public string _0123 { get; set; }

        [JsonProperty("0124")]
        public int _0124 { get; set; }

        [JsonProperty("0125")]
        public string _0125 { get; set; }

        [JsonProperty("0393")]
        public string _0393 { get; set; }

        [JsonProperty("0380")]
        public int _0380 { get; set; }

        [JsonProperty("0859")]
        public int _0859 { get; set; }

        [JsonProperty("0803")]
        public string _0803 { get; set; }

        [JsonProperty("0879")]
        public string _0879 { get; set; }

        [JsonProperty("0804")]
        public string _0804 { get; set; }

        [JsonProperty("0805")]
        public int _0805 { get; set; }

        [JsonProperty("0806")]
        public int _0806 { get; set; }

        [JsonProperty("0807")]
        public int _0807 { get; set; }

        [JsonProperty("0126")]
        public string _0126 { get; set; }

        [JsonProperty("0129")]
        public int _0129 { get; set; }

        [JsonProperty("0128")]
        public int _0128 { get; set; }

        [JsonProperty("0121")]
        public int _0121 { get; set; }
    }

    public class _2
    {
        [JsonProperty("0213")]
        public string _0213 { get; set; }

        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("0215")]
        public string _0215 { get; set; }
    }

    public class _3
    {
        [JsonProperty("0213")]
        public string _0213 { get; set; }

        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("0215")]
        public string _0215 { get; set; }
    }

    public class _4
    {
        [JsonProperty("0213")]
        public string _0213 { get; set; }

        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("0215")]
        public string _0215 { get; set; }
    }

    public class _5
    {
        [JsonProperty("0213")]
        public string _0213 { get; set; }

        [JsonProperty("line_id")]
        public string LineId { get; set; }

        [JsonProperty("0215")]
        public string _0215 { get; set; }
    }

    public class Children
    {
        [JsonProperty("1")]
        public DemographicsInformation _1 { get; set; }
    }

    public class Form
    {
        [JsonProperty("form")]
        public string Form1 { get; set; }

        [JsonProperty("editSessionId")]
        public string EditSessionId { get; set; }
    }

    public class Labor
    {
        [JsonProperty("1")]
        public DemographicsInformation _1 { get; set; }

        [JsonProperty("2")]
        public _2 _2 { get; set; }

        [JsonProperty("3")]
        public _3 _3 { get; set; }

        [JsonProperty("4")]
        public _4 _4 { get; set; }

        [JsonProperty("5")]
        public _5 _5 { get; set; }
    }

    public class Pregnancies
    {
        [JsonProperty("1")]
        public DemographicsInformation _1 { get; set; }
        [JsonProperty("2")]
        public DemographicsInformation _2 { get; set; }
        [JsonProperty("3")]
        public DemographicsInformation _3 { get; set; }
        [JsonProperty("4")]
        public DemographicsInformation _4 { get; set; }
        [JsonProperty("5")]
        public DemographicsInformation _5 { get; set; }
        [JsonProperty("6")]
        public DemographicsInformation _6 { get; set; }
        [JsonProperty("7")]
        public DemographicsInformation _7 { get; set; }
        [JsonProperty("8")]
        public DemographicsInformation _8 { get; set; }

    }

    public class Prenatal
    {
        [JsonProperty("1")]
        public DemographicsInformation _1 { get; set; }
    }

    public class Puerperium
    {
        [JsonProperty("1")]
        public DemographicsInformation _1 { get; set; }
    }

    #endregion
}
