using UnityEngine;

public class Deneme : MonoBehaviour
{
    public Transform Parent;   // Horizontal/Vertical/Grid Layout Group component'i olan transformlar.
    public Transform Parent_2;

    public Transform Obje;   // pozisyonu bulunmak istenen objelerimiz.


    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Obje, transform.position, transform.rotation, Parent);

            print(Parent.GetChild(i).position);                      //------------------> Burada kullandığımız pozisyonlar ebeveynin pozisyonuyla aynı değeri verir.
        }

        Canvas.ForceUpdateCanvases();                               //-------------------> Tüm tuvalleri içeriklerini güncellemeye zorla.

        for (int i = 0; i < 5; i++)
        {
            Instantiate(Obje, transform.position, transform.rotation, Parent_2);

            print(Parent.GetChild(i).position);                     //-------------------> Doğru değerler.
        }

    }

}
