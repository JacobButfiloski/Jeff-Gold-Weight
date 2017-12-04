using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int health = 6;
    public int maxHealth = 6;
    private Animator anim;
    public string sceneName;

	// Use this for initialization
	void Start () {
        anim = GameObject.Find("Player").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(health > maxHealth)
        {
            health = 6;
        }

        if(health <= 0)
        {
            KillPlayer();
        }
	}

    public void DamagePlayer(int dmgToDo)
    {
        health -= dmgToDo;
        anim.SetTrigger("hurt");
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(-5000, 100, this.gameObject.transform.position.z));
    }

    public void HealPlayer(int dmgToHeal)
    {
        health += dmgToHeal;
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene(sceneName);
        health = maxHealth;
    }
}
