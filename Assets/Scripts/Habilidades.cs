using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Habilidades : MonoBehaviour
{
    [Header("CoolDown")]

    public float coolDown = 0;

    private float speedTime;

    private bool speedUp = false;

    public GameObject Bloqueo;

    void Update()
    {
        if(coolDown > 0)
        {
            coolDown -= Time.deltaTime;

            if (speedUp == true)
            {
                speedTime -= Time.deltaTime;

                if (speedTime <= 0)
                {
                    Items.speed = Items.speedProd;

                    Debug.Log("Fin de Speed");
                }

            }
            Bloqueo.SetActive(true);
        }
        else
        {
            Bloqueo.SetActive(false);
        }

    }

    public void DoubleDown()
    {
        if (coolDown <= 0)
        {
            coolDown = 10;

            Items.amount = Items.amount * 2;

            Bloqueo.SetActive(false);

            Debug.Log("Bloqueo activado");
        }
    }

    public void SpeedUp()
    {
        if (coolDown <= 0)
        {
            coolDown = 20;

            Items.speed = Items.speed / 2;

            speedUp = true;

            Bloqueo.SetActive(false);

            speedTime = 10;

            Debug.Log("Bloqueo activado");
        }
    }

    public void MoreValue()
    {
        if (coolDown <= 0)
        {
            coolDown = 30;

            Money.dinero += Items.amount * Random.Range(1, 5);

            Items.amount = 0;

            Bloqueo.SetActive(false);

            Debug.Log("Bloqueo activado");
        }
    }

}
