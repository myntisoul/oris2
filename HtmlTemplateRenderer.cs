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
                string fullPath = match.Groups[1].Value;
                string propertyName = fullPath.Split('.')[1];
                PropertyInfo property = type.GetProperty(propertyName);
                if (property != null)
                {
                    var value = property.GetValue(dataModel);
                    return value?.ToString() ?? "";
                }
                return match.Value;
            });
            return result;
        }

        public string RenderToFile(string inputFilePath, string outputFilePath, object dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
