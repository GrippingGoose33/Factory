using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

    public static float dinero;
    public Text moneyText;

    void Start()
    {
        moneyText.text = "$" + dinero;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + dinero;
    }

    public void Cambiar()
    {
        if(Items.amount > 0)
        {
            dinero += Items.amount / 2;
            Items.amount = 0;
        }
    }
}
