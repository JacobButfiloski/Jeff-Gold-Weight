using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectVisualManager : MonoBehaviour
{

    /*public GameObject levelComplete1;
    public GameObject levelComplete2;
    public GameObject levelComplete3;
    public GameObject levelComplete4;
    public GameObject levelComplete5;
    public GameObject levelComplete6;
    public GameObject levelComplete7;
    public GameObject levelComplete8;
    public GameObject levelComplete9;
    public GameObject levelComplete10;
    public GameObject levelComplete11;
    public GameObject levelComplete12;
    public GameObject levelComplete13;
    public GameObject levelComplete14;
    public GameObject levelComplete15;
    public GameObject levelComplete16;
    public GameObject levelComplete17;
    public GameObject levelComplete18;
    public GameObject levelComplete19;
    public GameObject levelComplete20;
    public GameObject levelComplete21;
    public GameObject levelComplete22;
    public GameObject levelComplete23;
    public GameObject levelComplete24;
    */
    public GameObject[] levelComplete;

    GameObject _scoreManager;
    private void Start()
    {
        _scoreManager = GameObject.Find("ScoreManager");
    }
    private void Update()
    {
        for (int i = 0; i < 24; i++)
        {
            if (_scoreManager.GetComponent<Indestructable>().boolList[i] == true)
            {
                levelComplete[i].SetActive(true);
            }

        }
    }
}
