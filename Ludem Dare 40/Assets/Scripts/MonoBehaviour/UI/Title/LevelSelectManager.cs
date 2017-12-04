using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour {
    GameObject _screenwipe;
    Animator anim;
    //Animation animation;


    public IEnumerator LoadScene()
    {
        //yield return new WaitForSeconds(2);
       // if (anim.GetCurrentAnimatorStateInfo(0).IsName("close"))
       // {
        SceneManager.LoadScene("1-" + this.gameObject.name);
        yield return new WaitForSeconds(1);
        //_screenwipe.SetActive(false);
       // }
    }
    public void ButtonClick()
    {
        //_screenwipe.SetActive(true);
        //anim.SetTrigger("close");
        StartCoroutine(LoadScene());
        
    }
    GameObject _scoreManager;
    private void Start()
    {
        _scoreManager = GameObject.Find("ScoreManager");
        //_screenwipe = GameObject.Find("screenwipe");
        //animation = GameObject.Find("screenwipe").GetComponent<Animation>();
        //anim = GameObject.Find("screenwipe").GetComponent<Animator>();
    }
}
