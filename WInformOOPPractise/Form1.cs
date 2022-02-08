using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInformOOPPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a = "form1method";
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            class1 c = new class1();
            c.interface1method("interface1 method");
            c.interface2method("interface2 method");
            //GeeksforGeeks obj = new GeeksforGeeks();
            //obj.languages();
            //obj.courses();

        }
    }
    interface Interface1
    {
        void interface1method(string name);
    }
    public class ClassInterface1 : Interface1
    {
        public void interface1method(string name)
        {
            MessageBox.Show(name);
        }
    }
    interface Interface2
    {
        void interface2method(string name);
    }


    public class ClassInterface2 : Interface2
    {
        public void interface2method(string name)
        {
            MessageBox.Show(name);
        }
    } 
    public class class1 : Interface1, Interface2
    {
        ClassInterface1 c1 = new ClassInterface1();
        ClassInterface2 c2 = new ClassInterface2();

        public void interface1method(string name)
        {
            c1.interface1method(name);
        }
        
        public void interface2method(string name)
        {
            c2.interface2method(name);
        }
        
    }

    //interface GFG1
    //{
    //    void languages();
    //}

    //// Parent class 1
    //class Geeks1 : GFG1
    //{

    //    // Providing the implementation
    //    // of languages() method
    //    public void languages()
    //    {

    //        // Creating ArrayList
    //        ArrayList My_list = new ArrayList();

    //        // Adding elements in the
    //        // My_list ArrayList
    //        My_list.Add("C");
    //        My_list.Add("C++");
    //        My_list.Add("C#");
    //        My_list.Add("Java");

    //        MessageBox.Show("Languages provided by GeeksforGeeks:");
    //        foreach (var elements in My_list)
    //        {
    //            MessageBox.Show(elements.ToString());
    //        }
    //    }
    //}

    //// Interface 2
    //interface GFG2
    //{
    //    void courses();
    //}

    //// Parent class 2
    //class Geeks2 : GFG2
    //{

    //    // Providing the implementation
    //    // of courses() method
    //    public void courses()
    //    {

    //        // Creating ArrayList
    //        ArrayList My_list = new ArrayList();

    //        // Adding elements in the
    //        // My_list ArrayList
    //        My_list.Add("System Design");
    //        My_list.Add("Fork Python");
    //        My_list.Add("Geeks Classes DSA");
    //        My_list.Add("Fork Java");

    //        MessageBox.Show("\nCourses provided by GeeksforGeeks:");
    //        foreach (var elements in My_list)
    //        {
    //            MessageBox.Show(elements.ToString());
    //        }
    //    }
    //}

    //// Child class
    //class GeeksforGeeks : GFG1, GFG2
    //{

    //    // Creating objects of Geeks1 and Geeks2 class
    //    Geeks1 obj1 = new Geeks1();
    //    Geeks2 obj2 = new Geeks2();

    //    public void languages()
    //    {
    //        obj1.languages();
    //    }

    //    public void courses()
    //    {
    //        obj2.courses();
    //    }
    //}

    // Driver Class
    



}
