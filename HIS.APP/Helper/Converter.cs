using HIS.APP.Models;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;

namespace HIS.APP.Helper
{
    public static class Converter
    {
        public static string AssignValue(object obj, string code, object value)
        {
            PropertyInfo[] propertyInfos = obj.GetType().GetProperties();
            string codeName = code.Replace("ITSS-", "_");
            string propertyCode = code.Replace("ITSS-", "");
            foreach (var property in propertyInfos)
            {
                if (property.GetType() == typeof(Object))
                {
                    var result = AssignValue(property, code, value);
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        return result;
                    }
                }
                else if (property.PropertyType == typeof(NoYesNaNdEnum) && property.Name == codeName)
                {
                    if (!value.ToString().IsNullOrEmpty())
                    {
                        var setValue = new NoYesNaNdEnum();
                        string propertyValue = value.ToString().ToLower();
                        propertyValue = LookUpForYesNo(propertyValue);
                        if (!propertyValue.Equals("invalid"))
                        {
                            Enum.TryParse<NoYesNaNdEnum>(propertyValue, out setValue);
                            return GetResultString(propertyCode, (int)setValue);
                        }
                    }
                }
                else if (property.PropertyType == typeof(NoYesNdNaEnum) && property.Name == codeName)
                {
                    var setValue = new NoYesNdNaEnum();
                    string propertyValue = value.ToString().ToLower();
                    propertyValue = LookUpForYesNo(propertyValue);
                    if (!propertyValue.Equals("invalid"))
                    {
                        Enum.TryParse<NoYesNdNaEnum>(propertyValue, out setValue);
                        return GetResultString(propertyCode, (int)setValue);
                    }
                }
                else if (property.PropertyType == typeof(YesNoNaEnum) && property.Name == codeName)
                {
                    var setValue = new YesNoNaEnum();
                    string propertyValue = value.ToString().ToLower();
                    propertyValue = LookUpForYesNo(propertyValue);
                    if (!propertyValue.Equals("invalid"))
                    {
                        Enum.TryParse<YesNoNaEnum>(propertyValue, out setValue);
                        return GetResultString(propertyCode, (int)setValue);
                    }
                }
                else if (property.PropertyType == typeof(RhnegativeEnum) && property.Name == codeName)
                {
                    var setValue = new RhnegativeEnum();
                    string propertyValue = value.ToString().ToLower();
                    propertyValue = LookUpForRh(propertyValue);
                    if (!propertyValue.Equals("invalid"))
                    {
                        Enum.TryParse<RhnegativeEnum>(propertyValue, out setValue);
                        return GetResultString(propertyCode, (int)setValue);
                    }
                }
                else if (property.PropertyType == typeof(RhpositiveEnum) && property.Name == codeName)
                {
                    var setValue = new RhpositiveEnum();
                    string propertyValue = value.ToString().ToLower();
                    propertyValue = LookUpForRhPositive(propertyValue);
                    if (!propertyValue.Equals("invalid"))
                    {
                        Enum.TryParse<RhpositiveEnum>(propertyValue, out setValue);

                        return GetResultString(propertyCode, (int)setValue);
                    }
                }
                else if (property.PropertyType == typeof(NormalAbnormalNotDone) && property.Name == codeName)
                {
                    var setValue = new NormalAbnormalNotDone();
                    string propertyValue = value.ToString().ToLower();
                    propertyValue = LookUpForAbnormal(propertyValue);
                    if (!propertyValue.Equals("invalid"))
                    {
                        Enum.TryParse<NormalAbnormalNotDone>(propertyValue, out setValue);
                        return GetResultString(propertyCode, (int)setValue);
                    }
                }
                else if (property.PropertyType == typeof(SickleCellenum) && property.Name == codeName)
                {
                    var setValue = new SickleCellenum();
                    string propertyValue = value.ToString().ToLower();
                    propertyValue = LookUpForSickle(propertyValue);
                    if (!propertyValue.Equals("invalid"))
                    {
                        Enum.TryParse<SickleCellenum>(propertyValue, out setValue);
                        return GetResultString(propertyCode, (int)setValue);
                    }
                }
                else if (property.PropertyType == typeof(bool) && property.Name == codeName)
                {
                    string propertyValue = value.ToString().ToLower();
                    if (propertyValue.StartsWith('a') || propertyValue.StartsWith('t') || propertyValue.Contains("ab"))
                    {
                        return GetResultString(propertyCode, "true");
                    }
                }
                else if (property.PropertyType == typeof(string) && property.Name == codeName)
                {
                    return String.Format("\"{0}\":\"{1}\"", propertyCode, value.ToString());
                }
                else
                {
                    if (property.Name == codeName)
                    {
                        return string.Format("\"{0}\" : {1}", propertyCode, property.PropertyType == typeof(String) ? "\"" + value.ToString() + "\"" : value.ToString());
                    }
                }
            }
            return String.Empty;
        }

        private static string LookUpForYesNo(string propertyValue)
        {
            if (propertyValue.Equals('n') || propertyValue.Equals("no") || propertyValue.StartsWith('p') || propertyValue.StartsWith('+') || propertyValue.StartsWith("noo"))
            {
                return "no";
            }
            else if (propertyValue.StartsWith('y') || propertyValue.StartsWith("ne") || propertyValue.StartsWith('-'))
            {
                return "yes";
            }
            else if (propertyValue.Contains("n/a") || propertyValue.Contains("nota") || propertyValue.Contains("n/c"))
            {
                return "na";
            }
            else if (propertyValue.Contains("n/d") || propertyValue.Contains("notd"))
            {
                return "nd";
            }
            return "invalid";
        }
        private static string LookUpForRh(string propertyValue)
        {
            if (propertyValue.Contains("-ve") || propertyValue.StartsWith('-') || propertyValue.Contains("negative") || propertyValue.StartsWith("ne"))
            {
                return "negative";
            }
            else if (propertyValue.Contains("+ve") || propertyValue.StartsWith('+') || propertyValue.Contains('p'))
            {
                return "positive";
            }
            else if (propertyValue.Contains("n/a") || propertyValue.Contains("nota") || propertyValue.StartsWith("na"))
            {
                return "na";
            }
            else if (propertyValue.Contains("n/d") || propertyValue.Contains("notd") || propertyValue.Contains("nd"))
            {
                return "nd";
            }
            return "invalid";
        }
        private static string LookUpForRhPositive(string propertyValue)
        {
            if (propertyValue.StartsWith('+') ||propertyValue.Contains("+ve")  || propertyValue.Contains('p'))
            {
                return "positive";
            }
            else if (propertyValue.StartsWith('-') || propertyValue.Contains("-ve") || propertyValue.Contains('n'))
            {
                return "negative";
            }
            return "invalid";
        }
        private static string LookUpForSickle(string propertyValue)
        {
            if (propertyValue.Contains("-ve") || propertyValue.Contains('-') || propertyValue.StartsWith('n'))
            {
                return "negative";
            }
            else if (propertyValue.Contains("hbs"))
            {
                return "hbss";
            }
            else if (propertyValue.Contains("hba"))
            {
                return "hbas";
            }
            return "invalid";
        }
        private static string LookUpForAbnormal(string propertyValue)
        {
            if (propertyValue.StartsWith('a') || propertyValue.Contains("ab"))
            {
                return "abnormal";
            }
            else if ((propertyValue.StartsWith('n') && propertyValue.Length <= 1) || propertyValue.Contains("nor"))
            {
                return "normal";
            }
            else if (propertyValue.Contains("nd") || propertyValue.Contains("not"))
            {
                return "nd";
            }
            return "invalid";
        }

        
        private static string GetResultString(string code, int result)
        {
            return string.Format("\"{0}\" : {1}", code, result);
        }
        private static string GetResultString(string code, string result)
        {
            return string.Format("\"{0}\" : {1}", code, result);
        }
    }
}