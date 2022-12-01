using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float h= Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 pos = new Vector3(h,0,v);
        this.transform.position+=pos;
    }
}
