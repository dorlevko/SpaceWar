using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public string itemID;
    public int itemPrice;
    public Slider levelSlider;


    public void TryToBuy()
    {
        if (itemPrice < Player.coins)
        {
            int currentItemLevel = PlayerPrefs.GetInt(itemID);
            PlayerPrefs.SetInt(itemID, currentItemLevel + 1);
            UpdateUI();
            Player.AddCoins(-itemPrice);
        }
    }

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        int currentItemLevel = PlayerPrefs.GetInt(itemID);
        levelSlider.value = currentItemLevel + 1;
    }
}
