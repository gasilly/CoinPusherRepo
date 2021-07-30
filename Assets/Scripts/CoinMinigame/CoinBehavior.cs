using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinsCollected;
    private GameObject coinText;
    private UIController ui;
    void Start()
    {
        coinsCollected = PlayerPrefs.GetInt("coins");
    }
    
    void OnTriggerEnter2D(Collider2D Coll){
        Destroy(gameObject);
        coinsCollected ++;
        PlayerPrefs.SetInt("coins", coinsCollected);
    }
}
