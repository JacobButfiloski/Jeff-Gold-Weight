using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBoar : MonoBehaviour {

	// Use this for initialization
	public void FlipRight()
    {
        this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
    }

    public void FlipLeft()
    {
        this.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
