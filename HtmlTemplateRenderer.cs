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
            Type type = dataModel.GetType();
            Regex regex = new Regex("\\${\\S*}");
            MatchCollection matches = regex.Matches(htmlTemplate);
            regex.Replace(htmlTemplate, (match) => {
                string fieldName = match.Groups[1].Value.Split(".")[1];
                Console.WriteLine(fieldName); return null;
            });
            return htmlTemplate.Replace("${name}", dataModel.ToString());
        }

        public string RenderToFile(string inputFilePath, string outputFilePath, object dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
