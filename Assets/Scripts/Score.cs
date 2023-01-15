using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Coins;
    public TMP_Text CoinsText;

    public void AddCoin()
    {
        Coins += 1;
        CoinsText.text = "Coins: " + Coins.ToString();
    }
}
