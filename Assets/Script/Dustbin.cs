using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustbin : MonoBehaviour
{
    public Camera camera;
    public GameObject destory;
    GameObject _destory;
    // Use this for initialization
    //void Start () {
    //       StartCoroutine();
    //}
    void Start()
    {
        _destory = destory;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.transform.Equals(this.transform))
                {
                    if (this.transform.rotation.z != 0) return;
                        this.transform.Rotate(0,0,90);
                    
                    StartCoroutine("Rotate", 1F);
                }
            }
        }

    }

    IEnumerator Rotate(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        this.transform.Rotate(0,0,270);
    }

    private void OnCollisionEnter(Collision collision)
    {
        destory.transform.position = GameObject.FindGameObjectWithTag("smallball1").transform.position;
        Destroy(GameObject.FindGameObjectWithTag("smallball1"));
        Instantiate(_destory);

    } 
}
