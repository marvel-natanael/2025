using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    bool right = true, left = false;
    public float length;
    public float start;

    float pos, posLimit, posLimit2;

    public float posStart, posDestination;

    private void Start()
    {
        posStart = transform.position.x;
        pos = GetComponent<Transform>().position.x;
        posLimit = pos - 5;
        posLimit2 = pos + 5;
    }

    void Update()
    {

        if (transform.position.x <= posLimit)
         {
             right = true;
             left = false;
         }

         if (transform.position.x >= posLimit2)
         {
             left = true;
             right = false;
         }

         if (right)
         {
             //Debug.Log(posLimit2);
             transform.position = Vector3.MoveTowards(transform.position, new Vector2(posLimit2, transform.position.y), 0.05f);
         }


         if (left)
         {
             transform.position = Vector3.MoveTowards(transform.position, new Vector2(posLimit, transform.position.y), 0.05f);
         }
    }

}
