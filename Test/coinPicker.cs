using UnityEngine;
using TMPro;
using System;

public class coinPicker : MonoBehaviour
{

    private int coins = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {
            Destroy(other.gameObject);
            coins ++;
            textCoins.text = "Coins: " + coins.ToString();
        }
    }
}
