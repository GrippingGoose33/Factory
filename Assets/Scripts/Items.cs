using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    [Header("Costs")]

    public float firstUpgrade;
    public static float currentCost;
    public float upCost;
    public Text costText;

    [Header("Amounds & Production")]
    public static float amount;
    public Text amountText;

    public static float speed;

    public static float speedProd = 2;

    public float production;
    public float productionUpgrade;
    public static float productionTotal;
    public Text productionText;

    private float timer = 0;

    void Awake()
    {
        currentCost = firstUpgrade;
        productionTotal += production;
        costText.text = "" + currentCost;
        amountText.text = "" + amount;
        productionText.text = "" + productionTotal;
        speed = speedProd;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= speed)
        {
            amount += productionTotal;

            timer = 0;
        }
        amountText.text = "" + amount;
        productionText.text = "" + productionTotal;
        costText.text = "$" + currentCost;
    }

    public void Upgrade()
    {
        if(Money.dinero >= currentCost)
        {
            Money.dinero -= currentCost;
            currentCost += upCost;
            productionTotal += productionUpgrade;
            costText.text = "$" + currentCost;
        }
    }
}
