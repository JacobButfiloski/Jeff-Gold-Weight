using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {

    public GameObject titleScreen;
    public GameObject levelSelectScreen;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
        {
            titleScreen.SetActive(false);
            levelSelectScreen.SetActive(true);
        }
        if(Input.GetKeyDown("escape") && !titleScreen.activeSelf)
        {
            levelSelectScreen.SetActive(false);
            titleScreen.SetActive(true);
        }
	}
}
