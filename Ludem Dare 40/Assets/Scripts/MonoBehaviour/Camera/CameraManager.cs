using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    GameObject _player;
    float _x;
    float _y;

	// Use this for initialization
	void Start () {
        _player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        _x = _player.transform.position.x;
        _y = _player.transform.position.y;
        this.transform.position = new Vector3(_x, _y, this.transform.position.z);
	}
}
