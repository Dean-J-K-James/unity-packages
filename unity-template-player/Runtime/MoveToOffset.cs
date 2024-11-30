using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveToOffset : MonoBehaviour
{
    public Vector3 offset;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if ((speed -= Time.deltaTime) > 0)
        {
            //transform.position += new Vector3(offset.x, offset.y) * speed;
            transform.position = Vector2.MoveTowards(transform.position, transform.position + offset, speed * Time.deltaTime);
        }
    }
}
