using oris2;

//string template = "<p>имя: ${name}</p>";
//string name = "ваня";

HtmlTemplateRenderer renderer = new HtmlTemplateRenderer();
//string result = renderer.RenderFromString(template, name);
//Console.WriteLine(result);

User user = new User() { Name = "ivan", Group = "11-541", Age = 22, Sex = true};
string template = "<p>имя: ${User.Name}</p>" +
            "<p>возраст: ${User.Age}</p>" +
            "<p>группа: ${User.Group}</p>" +
            "<p>пол: ${User.Sex}</p>";

Book book = new Book() { Name = "москва-петушки", Year = "1970", Author = "в. ерофеев" };
string template1 = "<p>имя: ${Book.Name}</p>" +
                "<p>автор: ${Book.Author}</p>" +
                "<p>год: ${Book.Year}</p>";

Pen pen = new Pen() { Name = "pen", Color = "cyan", Width = 10, Price = 0 }; 
string template2 = "<p>имя: ${Pen.Name}</p>" +
                "<p>цвет: ${Pen.Color}</p>" +
                "<p>ширина: ${Pen.Width}</p>" +
                "<p>цена: ${Pen.Price}</p>";

string result = renderer.RenderFromString(template, user);
string result1 = renderer.RenderFromString(template1, pen);
string result2 = renderer.RenderFromString(template2, pen);
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);