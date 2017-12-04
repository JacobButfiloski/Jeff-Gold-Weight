using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarAI : MonoBehaviour {

    public GameObject PathLeft;
    public GameObject PathRight;

    bool _touchedLeft = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if(!_touchedLeft)
        {
            this.gameObject.transform.position = Vector3.Lerp(PathLeft.transform.position, this.gameObject.transform.position, 6 * Time.deltaTime);
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        } else if (_touchedLeft)
        {
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
            this.gameObject.transform.position = Vector3.Lerp(PathRight.transform.position, this.gameObject.transform.position, 6 * Time.deltaTime);
        }*/
        
    }
}
