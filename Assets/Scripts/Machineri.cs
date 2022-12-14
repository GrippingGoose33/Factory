using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machineri : MonoBehaviour
{
    [Header("Costs")]

    public float firstUpgrade;
    public static float currentCost;
    public float upCost;
    public Text costText;

    [Header("create")]

    public float create;
    public float createUpgrade;
    public static float createTotal;
    public Text createText;

    private float timer = 0;

    void Awake()
    {
        currentCost = firstUpgrade;
        createTotal += create;
        costText.text = "$" + currentCost;
        createText.text = "" + createTotal;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 7)
        {
            Items.productionTotal += createTotal; 
            timer = 0;
        }
        costText.text = "$" + currentCost;
        createText.text = "" + createTotal;
    }

    public void Upgrade()
    {
        if (Money.dinero >= currentCost)
        {
            Money.dinero -= currentCost;
            currentCost += upCost;
            createTotal += createUpgrade;
        }
    }
}
