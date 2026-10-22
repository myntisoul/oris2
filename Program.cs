using oris2;

////string template = "<p>имя: ${name}</p>";
////string name = "ваня";

//HtmlTemplateRenderer renderer = new HtmlTemplateRenderer();
////string result = renderer.RenderFromString(template, name);
////Console.WriteLine(result);

//User user = new User() { Name = "ivan", Group = "11-541", Age = 22, Sex = true};
//string template = "<p>имя: ${User.Name}</p>\n" +
//            "<p>возраст: ${User.Age}</p>\n" +
//            "<p>группа: ${User.Group}</p>\n" +
//            "<p>пол: ${User.Sex}</p>\n";

//Book book = new Book() { Name = "москва-петушки", Year = "1970", Author = "в. ерофеев" };
//string template1 = "<p>имя: ${Book.Name}</p>\n" +
//                "<p>автор: ${Book.Author}</p>\n" +
//                "<p>год: ${Book.Year}</p>\n";

//Pen pen = new Pen() { Name = "pen", Color = "cyan", Width = 10, Price = 0 }; 
//string template2 = "<p>имя: ${Pen.Name}</p>\n" +
//                "<p>цвет: ${Pen.Color}</p>\n" +
//                "<p>ширина: ${Pen.Width}</p>\n" +
//                "<p>цена: ${Pen.Price}</p>\n";

//string result = renderer.RenderFromString(template, user);
//string result1 = renderer.RenderFromString(template1, pen);
//string result2 = renderer.RenderFromString(template2, pen);
//Console.WriteLine(result);
//Console.WriteLine(result1);
//Console.WriteLine(result2);

Bag bag = new Bag() { Name = "wgwegw", Size = new Size(1, 1, 1), Color = new Color(234, 2, 445), MadeIn = new MadeIn(1, "wfgw", "kazan"), Price = 100 };
string template = "<h1>${Bag.Name} (${Bag.Price})\n" +
    "<b>страна: ${Bag.MadeIn.Country} ${Bag.MadeIn";