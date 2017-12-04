using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject followingTarget;
	public GameObject player1;
	private Vector3 targetPos;
	public float moveSpeed;

	//public BoxCollider2D cameraBorder;
	//private Vector3 minBounds;
	//rivate Vector3 maxBounds;

	private Camera mainCamera;
	private float halfHeight;
	private float halfWidth;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("Player");
		followingTarget = player1;

        /*minBounds = cameraBorder.bounds.min;
		maxBounds = cameraBorder.bounds.max;*/

        mainCamera = GetComponent<Camera>();
		halfHeight = mainCamera.orthographicSize;
		halfWidth = halfHeight * Screen.width / Screen.height;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//if(!followingTarget == null)
		//{
			targetPos = new Vector3(followingTarget.transform.position.x, followingTarget.transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);
	//	}

		//float clampedX = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
		//float clampedY = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
		//transform.position = new Vector3(clampedX, clampedY, transform.position.z);
		
	}
}
