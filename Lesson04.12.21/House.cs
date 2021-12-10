using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._12._21
{
     public class House
    {
        private byte numberOfHome;
        private float height;
        private byte countFloors;
        private int countApartments;
        private byte countEntrance;

        private byte index;
        static byte indexer = 0;

        public House()
        {
            //Empty
            indexer++;
        }
        public House(float height, byte countFloors, int countApartments, byte countEntrance)
        {
            index = indexer++;
            this.numberOfHome = index;
            this.height = height;
            this.countFloors = countFloors;
            this.countApartments = countApartments;
            this.countEntrance = countEntrance;

        }
        public byte NumberOfHome
        {
            get { return numberOfHome; }
            set { numberOfHome = value; }
        }
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        public byte FloorsCounter
        {
            get { return countFloors; }
            set { countFloors = value; }
        }
        public int ApartmentsCounter
        {
            get { return countApartments; }
            set { countApartments = value; }
        }
        public byte EntrancesCounter
        {
            get { return countEntrance; }
            set { countEntrance = value; }
        }

        public override string ToString()
        {
            return $"Дом №{NumberOfHome}\n 1.Высота: {Height}\n 2.Этажи: {FloorsCounter}\n 3.Квартиры: {ApartmentsCounter}\n 4.Подъезды: {EntrancesCounter}";
        }

    }
}
