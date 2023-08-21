using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BulletPlant : MonoBehaviour
{
    public float speed = 2;

    public float lifeTime = 2;

    public bool left;

    
    private void Start()
    {
        Destroy(gameObject,lifeTime);
        
    }

    private void Update()
    {


        if (left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            Destroy(gameObject);
           


        }
    }
}
