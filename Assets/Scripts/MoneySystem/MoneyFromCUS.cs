using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyFromCUS : MonoBehaviour
{
    public int gold = 0;
    public TextMeshProUGUI MoneyAmount;

    public void ServeCustomer()
    {
        gold += 5;
        MoneyAmount.text = gold.ToString();
    }
}
