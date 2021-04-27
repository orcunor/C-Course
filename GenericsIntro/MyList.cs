using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; // Add metodumuz var ama nereye eklicek o yüzden T tipinde arraye ekleme yapıcak. Arka planda array kullanıyor list ler. O yüzden array oluşturduk T tipinde.
        public MyList() // constructor.
        {
            items = new T[0]; // MyList ile her newlediğimde instance oluşturduğpumda constructor çalışacak ve 0 elemenlı bir array oluşturacak.
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++) // tempteki elkemanlarımızı boyutu 1 artmış olan boş arrayimize ekkliyoruz
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // en sonda boş kalan en son indexe parametre ile yolladığımız değeri atıyoruz. 
        }

    }
}
