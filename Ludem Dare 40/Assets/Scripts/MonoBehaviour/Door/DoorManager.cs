using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorManager : MonoBehaviour {

    bool _levelComplete = false;

    public Sprite completeDoor;
    public Sprite lockedDoor;

    public GameObject levelComplete;

    public string levelCompleteName;
    GameObject screenwipe;
    Animator anim;

    // Use this for initialization
    void Start () {
         //screenwipe = GameObject.Find("screenwipe");
         //anim = GameObject.Find("screenwipe").GetComponent<Animator>();
        // anim.SetTrigger("open");
    }

    private void OnEnable()
    {
       // GameObject.Find("screenwipe").GetComponent<Animator>().SetTrigger("open");
    }

    // Update is called once per frame
    void Update () {
		if(GameObject.Find("gold (1)") == null)
        {
            _levelComplete = true;
        } else
        {
            _levelComplete = false;
        }

        if(_levelComplete)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = completeDoor;
            levelComplete.SetActive(true);
        } else if (!_levelComplete)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lockedDoor;
            levelComplete.SetActive(false);
        }
	}
    public IEnumerator LoadScene()
    {
        //yield return new WaitForSeconds(2);
        // if (anim.GetCurrentAnimatorStateInfo(0).IsName("close"))
        // {
        SceneManager.LoadScene("Title");
        yield return new WaitForSeconds(1);
        //screenwipe.SetActive(false);
        // }
    }
    public int boolToChange;
    private void OnTriggerStay2D(Collider2D other)
    {
        if(_levelComplete)
        {
            if (other.name == "Player")
            {
                GameObject scoreManager = GameObject.Find("ScoreManager");
                scoreManager.GetComponent<Indestructable>().ChangeBool(boolToChange);
                //GameObject.Find("screenwipe").GetComponent<Animator>().SetTrigger("close");
                StartCoroutine(LoadScene());
                //SceneManager.LoadScene("Title");
                

            }
        }
        
    }
}
