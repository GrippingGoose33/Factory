using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    [Header("Costs")]

    public float firstUpgrade;
    private float currentCost;
    public float upCost;
    public Text costText;

    [Header("Amounds & Production")]
    public static float amount;
    public Text amountText;

    public float production;
    public float productionUpgrade;
    public static float productionTotal;
    public Text productionText;

    [Header("Particles")]
    public GameObject upParticle;

    private float timer = 0;

    void Start()
    {
        currentCost = firstUpgrade;
        productionTotal += production;
        costText.text = "$" + currentCost;
        amountText.text = "" + amount;
        productionText.text = "" + productionTotal;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            amount += productionTotal;

            timer = 0;
        }
        amountText.text = "" + amount;
        productionText.text = "" + productionTotal;
    }

    public void Upgrade()
    {
        if(Money.dinero >= currentCost)
        {
            Money.dinero -= currentCost;
            currentCost += upCost;
            productionTotal += productionUpgrade;
            costText.text = "$" + currentCost;
            productionText.text = "" + productionTotal;
        }
    }
}
