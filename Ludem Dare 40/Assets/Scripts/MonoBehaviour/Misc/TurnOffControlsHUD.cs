using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffControlsHUD : MonoBehaviour {

    private GameObject hud;

    private void Start()
    {
        hud = GameObject.Find("controls");
    }

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        hud.SetActive(false);
        Destroy(this);
    }
}
