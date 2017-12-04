using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldBarManager : MonoBehaviour {
    public GameObject TheScoreManager;

    public AudioClip pickup;
    // Use this for initialization
    void Start () {
        TheScoreManager = GameObject.Find("scoreui");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
    {
        int _subMoveSpeed = 2;
		if (other.name == "Player")
        {
            TheScoreManager.GetComponent<ScoreManager>().Score = TheScoreManager.GetComponent<ScoreManager>().Score + 1;
            other.GetComponent<PlayerController>().moveSpeed -= _subMoveSpeed;
            other.GetComponent<PlayerController>()._lastMoveSpeed -= _subMoveSpeed;
            other.GetComponent<PlayerController>().jumpForce -= _subMoveSpeed;
            AudioSource.PlayClipAtPoint(pickup, GameObject.Find("Player").transform.position);
            Destroy(gameObject);
        }
	}
}
