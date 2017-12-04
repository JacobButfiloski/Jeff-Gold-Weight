using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleAI : MonoBehaviour {

    public GameObject Mole;
    public Animator anim;
    GameObject _player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = Mole.transform.position;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            anim.SetTrigger("popup");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            anim.SetTrigger("exit");
        }
    }

}
