using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract class  Фигура
    {
        abstract public double Площадь();
    }

    class Квадрат : Фигура
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

        public override double Площадь()
        {
            return РазмерСтороны * РазмерСтороны;
        }
    }

    class Прямоугольник : Фигура
    {
        public double РазмерСтороны1;
        public double РазмерСтороны2;


        public double ВернутьПлощадь()
        {
            return РазмерСтороны1 * РазмерСтороны2;
        }

        public override double Площадь()
        {
            return РазмерСтороны1 * РазмерСтороны2;
        }
    }

    class Круг : Фигура
    {
        public double Радиус;
        
        public double ВернутьПлощадь()
        {
            return Math.PI * Радиус * Радиус;
        }

        public override double Площадь()
        {
            return Math.PI * Радиус * Радиус;
        }
    }
}
