using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private int coinsCollected;
    private GameObject coinText;
    private UIController ui;

    void OnTriggerEnter2D(Collider2D Coll){
        coinsCollected = PlayerPrefs.GetInt("coins");
        coinsCollected += 1;
        PlayerPrefs.SetInt("coins", coinsCollected);
        Destroy(gameObject);
    }
}
