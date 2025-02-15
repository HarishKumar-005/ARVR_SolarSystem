using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
            Debug.Log("Change location target is not specified.Defaulting to parent GameObj");
        }
    }

    private void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);

    }
}
