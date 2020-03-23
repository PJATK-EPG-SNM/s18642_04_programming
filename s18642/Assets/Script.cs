using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    void Start()
    {
        int a;
        a = 10;

        int b = 20;

        Debug.Log(a);

        {//komentarz
            int c = 20;
        }
        //Debug.Log(c);


        float fa = 1.5f;
        fa = 20.0f;

        bool logic = true; //=false

        string str = "ciąg znaków";

        Debug.Log("fa:"+ fa + "logiczna: " + logic + "str: " + str);

        //operacja na zmiennych + - * / 

        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);

/*        if (warunek_logiczny)
        {

        }
*/

        if (a == b)
        {
            Debug.Log("Tak, jest taka sama!");
        } else if (a<b) {
            Debug.Log("a < b");
            Alternatywa();
        } else
        {
            Debug.Log("żadne z powyższych");
        }

        Koniunkcja(a,b);
        Alternatywa();

    }

    public void Koniunkcja(int a, int b)
    {
        Debug.Log((a != b) && (a > 0));

        if (a != b)
        {
            if (a > 0)
            {
                //kod
            }
        }

        if ((a != b) && (a > 0))
        {
            //kod
        }

    }

    public void Alternatywa()
    {
        // brzydal
        int hp = 2, time = 1;
        bool amulet = true;

        if (hp <= 0)
        {
            if (!amulet) //==false
            {

            }
            else
            {

            }
        }
        if (time <= 0)
        {
            if (!amulet) //==false
            {

            }
            else
            {

            }
        }

        //ładny
        if ((hp <= 0) || (time <= 0))
        {
            if (!amulet)
            {

            }
            else
            {

            }
        }
    }



    void Update()
    {
       // Debug.Log(b); nie
    }
}
