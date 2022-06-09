using UnityEngine;
using TMPro;
using System;

public class distanceTravelled : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Distance Travelled: " + player.position.z.ToString("0");
    }
}