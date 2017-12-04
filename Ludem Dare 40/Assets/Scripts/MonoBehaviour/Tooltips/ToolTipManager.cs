using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipManager : MonoBehaviour {

    GameObject _player;

    public bool OpenToolTip = true;

    float _x;
    float _y;

	void Start () {
        _player = GameObject.Find("Player");
	}

    // Update is called once per frame
    void Update() {
        if (OpenToolTip)
        {
            this.gameObject.SetActive(true);
        } else if (!OpenToolTip)
        {
            this.gameObject.SetActive(false);
        }
        _x = _player.transform.position.x;
        _y = _player.transform.position.y;

        this.gameObject.transform.position = new Vector3(_x + 5, _y + 3, this.gameObject.transform.position.z);
	}
}
