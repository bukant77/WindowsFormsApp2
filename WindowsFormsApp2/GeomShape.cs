using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Квадрат
    {
        public double РазмерСтороны;

        public Квадрат()
        {

        }

        public Квадрат(double a)
        {
            РазмерСтороны = a;
        }

        public Квадрат(Квадрат другойКвадрат)
        {
            РазмерСтороны = другойКвадрат.РазмерСтороны;
        }


        public double ВернутьПлощадь()
        {
            return РазмерСтороны * РазмерСтороны;
        }
    }

    class Прямоугольник
    {
        public double РазмерСтороны1;
        public double РазмерСтороны2;


        public double ВернутьПлощадь()
        {
            return РазмерСтороны1 * РазмерСтороны2;
        }
    }

    class Круг
    {
        public double Радиус;
        
        public double ВернутьПлощадь()
        {
            return Math.PI * Радиус * Радиус;
        }
    }
}
