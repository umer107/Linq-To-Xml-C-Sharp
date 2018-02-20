using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Xml_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/*********************************--Using XElement--**********************************************/");
            /*********************************--Using XElement--**********************************************/
            XElement xelement = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            //Manipulate Directly
            foreach (XElement doc in xelement.Elements())
            {
                Console.WriteLine(doc);
            }
            //FirstltChangeObjectIntoIEnumerable&& then manipulate

            IEnumerable<XElement> employess = xelement.Elements();
            foreach (var item in employess)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/*********************************--Using XDocument--**********************************************/");
            /*********************************--Using XDocument--**********************************************/
            XDocument xdocument = XDocument.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> demployess = xdocument.Elements();
            foreach (var ditem in demployess)
            {
                Console.WriteLine(ditem);
            }
            //_________________________________________________________________________________________________________//
            //2. How Do I Access a Single Element using LINQ to XML
            Console.WriteLine("2. How Do I Access a Single Element using LINQ to XML");
            XElement xEle = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> docs = xEle.Elements();
            foreach (var iuy in docs)
            {
                Console.WriteLine(iuy.Element("Name").Value);
            }
            //_________________________________________________________________________________________________________//
            //3. How Do I Access Multiple Elements using LINQ to XML
            Console.WriteLine("3. How Do I Access Multiple Elements using LINQ to XML");
            XElement fiu = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> fiuy = fiu.Elements();
            foreach(var oiu in fiuy)
            {
                Console.WriteLine("{0} has Employee Id {1}", oiu.Element("Name").Value, oiu.Element("EmpId").Value);
            }
            //_________________________________________________________________________________________________________//
            //4. How Do I Access all Elements having a Specific Attribute using LINQ to XML
            Console.WriteLine("4. How Do I Access all Elements having a Specific Attribute using LINQ to XML");
            XElement ciu = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> hjj = ciu.Elements();
            var query = from m in hjj
                        where (string)m.Element("Sex") == "Female"
                        select m;
            //_________________________________________________________________________________________________________//
            //5. How Do I access Specific Element having a Specific Attribute using LINQ to XML
            Console.WriteLine("5. How Do I access Specific Element having a Specific Attribute using LINQ to XML");
            XElement drf = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> ftr = drf.Elements();
            foreach (var uiui in ftr)
            {
                Console.WriteLine("{0} has Employee Id {1} and its Attribute is {2}", uiui.Element("Name").Value, uiui.Element("EmpId").Value,uiui.Element("Phone").Attribute("Type").Value);
            }
            //_________________________________________________________________________________________________________//
            //How Do I Find Nested Elements (using Descendants Axis) using LINQ to XML
            Console.WriteLine("How Do I Find Nested Elements (using Descendants Axis) using LINQ to XML");
            Console.WriteLine("5. How Do I access Specific Element having a Specific Attribute using LINQ to XML");
            XElement sdf = XElement.Load(@"C:\Users\Umar\Desktop\sample.xml");
            IEnumerable<XElement> ftfsdr = drf.Elements();
            foreach (XElement dasd in xelement.Descendants("Zip"))
            {
                Console.WriteLine((string)dasd);
            }

            Console.ReadKey();

        }
    }
}