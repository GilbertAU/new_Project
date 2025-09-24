using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CurrecySystem : MonoBehaviour
{
    public Text txt_Currency;
    public int default_currency;
    public int currency;
    public void init()
    {
        currency = default_currency;
    }
    public void Gain(int val)
    {
        currency += val;
        UpdateUI();
    }
    public bool Use(int val)
    {
        if (EnoughCurrency(val))
        {
            currency -= val;
            UpdateUI();
            return true;
        }
        else
        {
            return false;
        }  
    }
    bool EnoughCurrency(int val)
    {
        if (currency >= val)
        {
            return true;
        }
        else
            return false;
    }
    void UpdateUI()
    {
        txt_Currency.text = currency.ToString();
    }
    public void UseTest()
    {
        Debug.Log(Use(5));
    }
}
