using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour {

    // Use this for initialization
    public GameObject ball;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = ball.transform.position;
	}
}
