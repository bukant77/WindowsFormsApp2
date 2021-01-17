using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Квадрат1 = new Квадрат();
            Квадрат1.РазмерСтороны = 5;

            Квадрат1.РазмерСтороны = 6;

            var Квадрат2 = new Квадрат();
            Квадрат2.РазмерСтороны = 12;
            Квадрат квадра3 = new Квадрат();
            //int i = 5;

            var Квадрат3 = new Квадрат(8);
            var Квадрат4 = new Квадрат(Квадрат3);

            var array = new int[4];
            int[] array1 = new int[4];

            double t = 5.34;
            var t1 = 6.34;

            double Площадь1 = Квадрат1.ВернутьПлощадь();
            double Площадь2 = Квадрат2.ВернутьПлощадь();

            double a = 5;
            double a2 = 12;

            var прямоуг1 = new Прямоугольник();
            прямоуг1.РазмерСтороны1 = 4;
            прямоуг1.РазмерСтороны2 = 6;

            var ПлощадьПрямоуг = прямоуг1.ВернутьПлощадь();

            var круг1 = new Круг();
            круг1.Радиус = 5;

            var ПлощадьКруга = круг1.ВернутьПлощадь();

            var массивКвадратов = new Квадрат[10];

            ArrayList массивФигур = new ArrayList();
            массивФигур.Add(Квадрат1);
            массивФигур.Add(Квадрат2);
            массивФигур.Add(прямоуг1);
            массивФигур.Add(круг1);
            массивФигур.Add("строка");

            double ОбщаяПлощадь = 0.0;
            for(int i=0; i<массивФигур.Count - 1; i++)
            {
                var текущаяФигура = массивФигур[i];
                if (текущаяФигура.GetType().Name == "Квадрат")
                {
                    ОбщаяПлощадь += ((Квадрат)текущаяФигура).ВернутьПлощадь();
                }
                if (текущаяФигура.GetType().Name == "Прямоугольник")
                {
                    ОбщаяПлощадь += ((Прямоугольник)текущаяФигура).ВернутьПлощадь();
                }
                if (текущаяФигура.GetType().Name == "Круг")
                {
                    ОбщаяПлощадь += ((Круг)текущаяФигура).ВернутьПлощадь();
                }
            }
            MessageBox.Show(string.Format("Общая площадь фигур в массиве равна = {0}", ОбщаяПлощадь));


        }
    }
}
