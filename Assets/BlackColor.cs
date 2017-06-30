using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackColor : MonoBehaviour
{
    public Camera camera;
    public GameObject Blackcolor;
    public GameObject _Black;
    GameObject Egg;
    GameObject egg;
    // Use this for initialization
    //void Start () {
    //       StartCoroutine();
    //}
       void Start()
      {
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
                        if (egg != null) return;
                        this.transform.Rotate(0, 0, 35);
                        Egg = Instantiate(_Black);
                        StartCoroutine("CreateEggcolor", 0.8F);
                        StartCoroutine("DestoryEggcolor", 2.0F);
                    }
                }
            }

        }

        IEnumerator DestoryEggcolor(float waitTime)
        {

            yield return new WaitForSeconds(waitTime);
            this.transform.Rotate(0, 0, 325);
            Destroy(egg);
            Destroy(Egg);
        }
        IEnumerator CreateEggcolor(float waitTime)
        {

            yield return new WaitForSeconds(waitTime);
            egg = Instantiate(Blackcolor); 
        }
    }
