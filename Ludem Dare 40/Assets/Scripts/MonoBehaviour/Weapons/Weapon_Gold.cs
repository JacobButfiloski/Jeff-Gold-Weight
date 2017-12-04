using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Gold : MonoBehaviour {

    Rigidbody2D _theRigidBody;
    public int speed;

    public bool destroy;

    public float lifeTime;

	// Use this for initialization
	void Start () {
        _theRigidBody= this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        _theRigidBody.velocity = new Vector2(speed * -transform.localScale.x, _theRigidBody.velocity.y);

        lifeTime -= Time.deltaTime;
        //Destroy(this.gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Destroy(other);
        }
    }
}
