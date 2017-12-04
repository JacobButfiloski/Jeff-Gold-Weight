using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarHurt : MonoBehaviour {


    int _health = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_health == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerHealthManager>().DamagePlayer(1);
        }
        if (other.name == "throwGold(Clone)")
        {
            _health -= 1;
            if(_health < 0)
            {
                Destroy(this.gameObject);
            }
            
        }
    }
}
