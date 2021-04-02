using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public float velocity = 2f;
    public Rigidbody2D rg2D;
    public bool isDead;
    public GameManager managergame;
    public GameObject DeadScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rg2D.velocity = Vector2.up * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "score_area")
        {
            managergame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "deadarea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeadScreen.SetActive(true);
        }
    }
}
