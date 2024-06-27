using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TH_Background : MonoBehaviour
{
    private float moveSpeed = 1.5f; 

    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -11.75f)
        {
            transform.position = new Vector3(0f, 11.75f, 0f);
        }
    }
}
