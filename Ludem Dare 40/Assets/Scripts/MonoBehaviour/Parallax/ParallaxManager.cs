/* 
 * Note to anyone looking at this
 * Never do parallax's this way, its an awful way to do it.
 * end of PSA
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxManager : MonoBehaviour {

    private GameObject _parallaxImage1;
    public GameObject _parallaxImage2;
    public GameObject _parallaxImage3;
    public Camera MainCamera;

    private Vector3 _cameraLocation;

    float _x;
    float _y;

    // Use this for initialization
    private void Start()
    {
        _parallaxImage1 = this.gameObject;
    }
    // Update is called once per frame
    void Update () {
        _cameraLocation = MainCamera.transform.position;
        _x = MainCamera.transform.position.x;
        _y = MainCamera.transform.position.y;
        
        this.gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(_x, _y, this.gameObject.transform.position.z), 20 * Time.deltaTime);
        _parallaxImage2.transform.position = Vector3.Lerp(transform.position, new Vector3(_x, _y, _parallaxImage2.transform.position.z), 5 * Time.deltaTime);
        _parallaxImage3.transform.position = Vector3.Lerp(transform.position, new Vector3(_x, _y, _parallaxImage3.transform.position.z), 2 / 10 * Time.deltaTime);
    }
}
