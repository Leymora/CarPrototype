using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfHasFallen : MonoBehaviour
{

    public bool state = false;
    public string tagOfOtherObject = "";


    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Lane"))
        {
            state = true;
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(state);
 
    }
}
