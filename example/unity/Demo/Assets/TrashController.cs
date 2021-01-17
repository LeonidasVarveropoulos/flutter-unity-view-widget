using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    public Object[] small_objects;
    public Object[] big_objects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 20 * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
    }
}
