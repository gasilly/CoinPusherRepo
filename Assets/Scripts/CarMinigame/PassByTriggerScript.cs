using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PassByTriggerScript : MonoBehaviour
{
    int coinsCollected;
    void Start()
    {
        coinsCollected = PlayerPrefs.GetInt("coins");
    }

    void OnTriggerEnter2D(Collider2D Coll){
        if(Coll.gameObject.tag == "EnemyCar")
        {
            coinsCollected += 1;
            PlayerPrefs.SetInt("coins",coinsCollected);
        }
    }
}
