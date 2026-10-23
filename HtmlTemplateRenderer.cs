using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;

namespace oris2
{
    public class HtmlTemplateRenderer : IHtmlTemplateRenderer
    {
        public string RenderFromFile(string filePath, object dataModel)
        {
            throw new NotImplementedException();
        }

        public string RenderFromString(string htmlTemplate, object dataModel)
        {
            //2)
            //Type type = dataModel.GetType();
            //Regex regex = new Regex(@"\$\{(.*?)\}");
            //string result = regex.Replace(htmlTemplate, (match) =>
            //{
            //    string fullPath = match.Groups[1].Value;
            //    string propertyName = fullPath.Split('.')[1];
            //    PropertyInfo property = type.GetProperty(propertyName);
            //    if (property != null)
            //    {
            //        var value = property.GetValue(dataModel);
            //        return value?.ToString() ?? "";
            //    }
            //    return match.Value;
            //});
            //return result;

            //3)
            Type type = dataModel.GetType();
            Regex regex = new Regex(@"\$\{(.*?)\}");
            string result = regex.Replace(htmlTemplate, (match) =>
            {
                string[] fullPath = match.Groups[1].Value.Split(".");
                //Console.WriteLine(fullPath);
                //foreach (string s in fullPath) Console.WriteLine(s);
                if (fullPath.Length == 3)
                {
                    string propertyName1 = fullPath[1];
                    string propertyName2 = fullPath[2];
                    PropertyInfo property1 = type.GetProperty(propertyName1);
                    if (property1 != null)
                    {
                        object property1Value = property1.GetValue(dataModel);
                        if (property1Value != null)
                        {
                            Type property1Type = property1Value.GetType();
                            PropertyInfo property2 = property1Type.GetProperty(propertyName2);
                            if (property2 != null)
                            {
                                var value = property2.GetValue(property1Value);
                                return value?.ToString() ?? "";
                            }
                        }
                    }
                    return match.Value;
                }
                else 
                {
                    string propertyName = fullPath[1];
                    PropertyInfo property = type.GetProperty(propertyName);
                    if (property != null)
                    {
                        var value = property.GetValue(dataModel);
                        return value?.ToString() ?? "";
                    }
                    return match.Value;
                }

            });
            return result;
        }

        public string RenderToFile(string inputFilePath, string outputFilePath, object dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
