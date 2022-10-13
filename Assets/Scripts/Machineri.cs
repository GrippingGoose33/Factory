using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machineri : MonoBehaviour
{
    [Header("Costs")]

    public float firstUpgrade;
    private float currentCost;
    public float upCost;
    public Text costText;

    [Header("create")]

    public float create;
    public float createUpgrade;
    public static float createTotal;
    public Text createText;

    [Header("Particles")]
    public GameObject upParticle;

    private float timer = 0;

    void Start()
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
    }

    public void Upgrade()
    {
        if (Money.dinero >= currentCost)
        {
            Money.dinero -= currentCost;
            currentCost += upCost;
            createTotal += createUpgrade;
            costText.text = "$" + currentCost;
            createText.text = "" + createTotal;
        }
    }
}
