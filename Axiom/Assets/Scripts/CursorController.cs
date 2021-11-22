using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    Transform pointer_transform;
    //GameObject pointer;

    void Awake()
    {
        pointer_transform = gameObject.transform;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            pointer_transform.Translate(Vector3.left * Time.deltaTime *12);
        }
        if (Input.GetKey(KeyCode.D))
        {
            pointer_transform.Translate(Vector3.right * Time.deltaTime *12);
        }
        if (Input.GetKey(KeyCode.W))
        {
            pointer_transform.Translate(Vector3.up * Time.deltaTime *12);
        }
        if (Input.GetKey(KeyCode.S))
        {
            pointer_transform.Translate(Vector3.down * Time.deltaTime *12);
        }
    }

}
