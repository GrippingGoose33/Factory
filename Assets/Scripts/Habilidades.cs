using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Habilidades : MonoBehaviour
{
    [Header("CoolDown")]

    public float coolDown = 0;

    public GameObject Bloqueo;

    void Update()
    {
        if(coolDown > 0)
        {
            coolDown -= Time.deltaTime;
            Debug.Log(coolDown);

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
            coolDown = 10;

            Items.speed = Items.speed / 2;

            Bloqueo.SetActive(false);

            Debug.Log("Bloqueo activado");
        }
    }

}
