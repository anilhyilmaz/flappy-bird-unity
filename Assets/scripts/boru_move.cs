using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boru_move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    void Start()
    {
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
