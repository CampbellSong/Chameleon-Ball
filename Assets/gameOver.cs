using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{

    public GameObject playAgain;
    // Use this for initialization
    private void OnTriggerStay(Collider other)
    {
        //  Debug.Log("111");
        playAgain.SetActive(true);
        Destroy(other.gameObject);
    }
}
