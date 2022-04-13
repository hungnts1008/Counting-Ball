using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float xdirection;
    public float speed;
    private void Start()
    {
        
    } 
   void Update()
    {
        xdirection = Input.GetAxisRaw("Horizontal");
        float movestep = xdirection * Time.deltaTime * speed;
        if (transform.position.x + movestep < -526 || transform.position.x + movestep > 526) return;
        transform.position = transform.position + new Vector3(movestep, 0, 0);
    }

}











