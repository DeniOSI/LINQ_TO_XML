using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_TO_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region XML DOC
            //XElement employers = new XElement("Employee",
            //    new XElement("Prormamer",
            //        new XElement("FirstName", "Denis"),
            //        new XElement("LastName", "Osipenko")),
            //    new XElement("Deployer",
            //    new XElement("FirstName", "Denis"),
            //        new XElement("LastName", "Osipenko")));
            //Console.WriteLine(employers.ToString());
            //XNamespace nameSpace = "http://mySite.com/linq";
            //XDocument xDocument =
            //    new XDocument(
            //        new XElement("Employees", new XAttribute(XNamespace.Xmlns + "linq", nameSpace),
            //            new XElement("Employee",
            //                new XAttribute("type", "Programmer"),
            //                new XElement("FirstName", "Alex"),
            //                new XElement("LastName", "Erohin")),
            //             new XElement("Employee",
            //                new XAttribute("type", "Editor"),
            //                new XElement("FirstName", "Elena"),
            //                new XElement("LastName", "Volkova"))));

            //Console.WriteLine(xDocument/*.ToString()*/);

            //try
            //{
            //    XElement smoker = new XElement("Smoker", "Tre");
            //    Console.WriteLine((bool)smoker);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex);
            //}


            #endregion

            #region MyRegion
            //XDocument xdoc = new XDocument( new XElement("Company",
            //    new XElement("Employe", 
            //        new XAttribute("type", "Programmer"),
            //        new XElement("name", "Denis"),
            //        new XElement("SecondName", "Osipenko")
            //    ),
            //      new XElement("Employe",
            //        new XAttribute("type", "Programmer"),
            //        new XElement("name", "Alex"),
            //        new XElement("SecondName", "Soft")
            //    ),
            //    new XElement("Employe",
            //        new XAttribute("type", "Programmer"),
            //        new XElement("name", "Petro"),
            //        new XElement("SecondName", "Vodkin")
            //    )));

            //IEnumerable<XElement> iex = xdoc.Element("Company").Elements("Employe"); //XML - to IEnumerableLIST

            //foreach (var item in iex)
            //{
            //    Console.WriteLine(item.Name + " " + item.Value);

            //}
            //foreach (var it in iex/*.ToArray()*/) //решение проблемы хєлуина
            //{
            //    Console.WriteLine($"Remove {it.Name} - {it.Value}");
            //    it.Remove();
            //}

            //Console.WriteLine("\n" + xdoc); 
            #endregion

            #region CreateXML
            //Employe[] emps = new[]
            //{
            //        new Employe { FirstName = "Petr", LastName = "Alexeev", EmployerType = EmployeTypes.Editor},
            //        new Employe { FirstName = "Ivan", LastName = "Sidorov", EmployerType = EmployeTypes.Deployer},
            //        new Employe {FirstName = "Alexey", LastName = "Alexeev", EmployerType = EmployeTypes.Programmer }
            //};
            //XElement xe = new XElement("Employees",
            //    emps.Select(p =>
            //    new XElement("Employee",
            //        new XComment(" добавление нового сотрудника"),
            //        new XAttribute("type", p.EmployerType),
            //        new XElement("FirstName", p.FirstName),
            //        new XElement("LastName", p.LastName))));
            //Console.WriteLine(xe);
            #endregion

            #region XDeclaration
            //XDocument xmDoc = new XDocument(
            //new XProcessingInstruction("Employs", "Delete"), 
            //new XDocumentType("Employs", null, "Employs.tdt", null),
            //new XElement("Employee"));
            //XDeclaration xd = new XDeclaration("1.0", "UTF-8", "yes");
            //XDocumentType xdt = new XDocumentType("Employs", null, "Employs.tdt", null);
            //XProcessingInstruction xpi = new XProcessingInstruction("Employs", "Delete");
            //xmDoc.Declaration = xd;
            //Console.WriteLine(xmDoc);
            #endregion

            #region XSreamingElement - Образование неотложных
            //string[] names = { "bob", "mark", "Devid", "Joy" };
            //XElement xnames = new XElement("Class", from n in names select new XElement("Name", n)); //неотложная 
            //XStreamingElement xstn = new XStreamingElement("Class", from n in names select new XElement("Name", n));
            //names[2] = "Greg";

            //Console.WriteLine(xnames);
            //Console.WriteLine(xstn);
            #endregion

            #region SaveXML
            //XDocument sfd =
            //    new XDocument(
            //    new XElement("TestS",
            //    new XAttribute("Test", "SomeTest"),
            //    new XElement("Name", "Denis"),
            //    new XElement("Family", "Osypenko")));
            //sfd.Save("My.XML", SaveOptions.None | SaveOptions.DisableFormatting | SaveOptions.OmitDuplicateNamespaces);

            #endregion

            #region LoadXML
            //XDocument xdocum = XDocument.Load("My.XML", LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            //Console.WriteLine(xdocum);
            //Console.WriteLine(xdocum.BaseUri);

            #endregion

            #region ParseXML
            //string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Employees><Employee type=\"Programmer\" language=\"Russian\"><FirstName>Alex</FirstName><LastName>Erohin</LastName></Employee></Employees>";

            //XElement xElement = XElement.Parse(xml);
            //Console.WriteLine(xElement);
            #endregion

            #region ByPass
            //XElement firstEmployee;

            //XDocument xDocument = new XDocument(
            //  new XDeclaration("1.0", "UTF-8", "yes"),
            //  new XDocumentType("Employees", null, "Employees.dtd", null),
            //  new XProcessingInstruction("EmployeeCataloger", "out-of-print"),
            //  // Обратите внимание, что в следующей строке сохраняется 
            //  // ссылка на первый элемент

            //  new XElement("Employees",
            //  new XElement("XXX", "ZZZ"),
            //  new XComment("comment Beffore"),
            //  firstEmployee =
            //    new XElement("Employee",
            //      new XComment("Это программист"),
            //      new XProcessingInstruction("ProgrammerHandler", "new"),
            //      new XAttribute("type", "Programmer"),
            //      new XElement("FirstName",
            //          new XText("Alex"),
            //          new XElement("NickName", "alexsave")),
            //      new XElement("LastName", "Erohin")),
            //    new XElement("Employee",
            //      new XAttribute("type", "Editor"),
            //      new XElement("FirstName", "Elena"),
            //      new XElement("LastName", "Volkova"))));


            //Console.WriteLine(xDocument);

            //Console.WriteLine("-----------------NextNode-----------------------");
            //Console.WriteLine(firstEmployee.NextNode);
            //Console.WriteLine("-----------------PreviousNode-----------------------");
            //Console.WriteLine(firstEmployee.NextNode.PreviousNode);
            //Console.WriteLine("-----------------DocumentFormXElement----------------");
            //Console.WriteLine(firstEmployee.Document);
            //Console.WriteLine("------------------TopOneLevel--------------------------");
            //Console.WriteLine(firstEmployee.Parent);

            //Console.WriteLine("-------------------ByPassDown----------------------------");
            //foreach (XNode node in firstEmployee.Nodes())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------ByPassDownSomeTypes----------------------------");
            //foreach (XNode node in firstEmployee.Nodes().OfType<XComment>())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------ByPassDownOnlyAttributes----------------------------");
            //foreach (XAttribute node in firstEmployee.Attributes())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------ByPassDownOnlyElements----------------------------");
            //foreach (XElement node in firstEmployee.Elements())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------XContainer.Element----------------------------");
            //Console.WriteLine(firstEmployee.Element("LastName"));
            //Console.WriteLine("-------------------RecursiveUpAncestors----------------------------");
            //foreach (XElement node in firstEmployee.Element("FirstName").Element("NickName").Ancestors())
            //{
            //    Console.WriteLine(node.Value + "  " + node.Name);
            //}
            //Console.WriteLine("-------------------RecursiveUpAncestorsAndSelf----------------------------");
            //foreach (XElement node in firstEmployee.Element("FirstName").Element("NickName").AncestorsAndSelf())
            //{
            //    Console.WriteLine(node.Value + "  " + node.Name);
            //}
            //Console.WriteLine("-------------------Descendants----------------------------");
            //foreach (XElement node in firstEmployee.Element("FirstName").Element("NickName").DescendantsAndSelf())
            //{
            //    Console.WriteLine(node.Value + "  " + node.Name);
            //}
            //Console.WriteLine("-------------------NodeBefore----------------------------");
            //foreach (XNode node in firstEmployee.NodesBeforeSelf())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------NodeAfter----------------------------");
            //foreach (XNode node in firstEmployee.NodesAfterSelf())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------ElementAfter----------------------------");
            //foreach (XElement node in firstEmployee.ElementsAfterSelf())
            //{
            //    Console.WriteLine(node);
            //}
            //Console.WriteLine("-------------------ElementBefore----------------------------");
            //foreach (XElement node in firstEmployee.ElementsBeforeSelf())
            //{
            //    Console.WriteLine(node);
            //}
            #endregion

            #region AddNodes
            //XDocument xDoc = new XDocument(
            //    new XElement("Employees",
            //        new XElement("Employee",
            //            new XAttribute("type", "Programmer"),
            //            new XElement("FirstName", "Alex"),
            //            new XElement("LastName", "Erohin")
            //            )
            //            )
            //            );
            //Console.WriteLine(xDoc);
            //Console.WriteLine("------------AddFirst--------------------");
            //xDoc.Element("Employees").AddFirst(
            //    new XElement("Employee",
            //    new XAttribute("type", "Editor"),
            //    new XElement("FirstName", "Denis"),
            //    new XElement("LastName", "Osipenko")
            //    )
            //    );
            //Console.WriteLine("------------AddАfterSelf--------------------");
            //xDoc.Element("Employees")
            //    .Elements("Employee")
            //    .Where(e => (string)e.Element("FirstName") == "Denis")
            //    .Single<XElement>()
            //    .AddBeforeSelf(
            //    new XElement("Employee",
            //    new XAttribute("type", "Editor"),
            //    new XElement("FirstName", "DOS"),
            //    new XElement("LastName", "Osov")
            //    ));

            //Console.WriteLine(xDoc);
            #endregion

            #region XmlAnnotation
     //       XDocument xDocument = new XDocument(
     //new XElement("Employees", 
     //  new XElement("Employee",
     //    new XAttribute("type", "Programmer"),
     //    new XAttribute("experience", "first-time"),
     //    new XAttribute("language", "Russian"),
     //    new XElement("FirstName", "Alex"),
     //    new XElement("LastName", "Erohin")),
     //  new XElement("Employee",
     //    new XAttribute("type", "Editor"),
     //    new XElement("FirstName", "Elena"),
     //    new XElement("LastName", "Volkova"))));

     //       foreach (var item in xDocument.Element("Employees").Elements())

     //       {
     //           if((string)item.Attribute("type") == "Programmer")
     //           {
     //               ProgramHandler phh = new ProgramHandler();
     //               item.AddAnnotation(phh);
     //           }
     //           else if((string)item.Attribute("type") == "Editor")
     //           {
     //               EditorHandler ehh = new EditorHandler();
     //               item.AddAnnotation(ehh);
     //           }
     //       }
     //       xDocument.Save("AddNotation.xml");

     //       ProgramHandler ph;
     //       EditorHandler eh;
     //       foreach (var item in xDocument.Element("Employees").Elements())
     //       {
     //       if((string)item.Attribute("type") == "Editor")
     //           {
     //               eh = item.Annotation<EditorHandler>();
     //               if (eh != null)
     //                   eh.Display(item);
     //           }
     //       else if((string)item.Attribute("type") == "Programmer")
     //           {
     //               ph = item.Annotation<ProgramHandler>();
     //                   if(ph!=null)
     //               { ph.Display(item); }
     //           }
     //       }

     //       Console.WriteLine($"{xDocument} {System.Environment.NewLine}");
            #endregion


        }

    }
}
