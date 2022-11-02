using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reinicio : MonoBehaviour
{
    public int rCoins = 0;

    public static int currentRCoin;

    public Text textRCoins;

    private void Awake()
    {
        currentRCoin = rCoins;

        textRCoins.text = "" + currentRCoin;
    }

    public void Restart()
    {
        currentRCoin += (int)Items.productionTotal / 4;

        textRCoins.text = "" + currentRCoin;

        Items.productionTotal = 1;

        Items.currentCost = 4;

        Items.amount = 0;

        Machineri.createTotal = 0;

        Machineri.currentCost = 50;

        Money.dinero = 0;
    }

}
