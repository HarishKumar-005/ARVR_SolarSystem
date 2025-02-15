using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    static public GameObject target;
   void Start()
    {
        if(target == null)
        {
            target=this.gameObject;
            Debug.Log("Look At target not specified.Defaulting to parent GameObj");
        }
    }

    void Update()
    {
        if(target )
        {
            transform.LookAt(target.transform);
        }
    }
}
