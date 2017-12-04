using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public Sprite hp3;
    public Sprite hp2;
    public Sprite hp1;
    public Sprite hp0;

    private GameObject _player;

    // Update is called once per frame
    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    void Update()
    {
        if (_player.GetComponent<PlayerHealthManager>().health == 3)
        {
            this.gameObject.GetComponent<Image>().sprite = hp3;
        }
        else if (_player.GetComponent<PlayerHealthManager>().health == 2)
        {
            this.gameObject.GetComponent<Image>().sprite = hp2;
        }
        else if (_player.GetComponent<PlayerHealthManager>().health == 1)
        {
            this.gameObject.GetComponent<Image>().sprite = hp1;
        }
        else if (_player.GetComponent<PlayerHealthManager>().health == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = hp0;
        }
    }
}
