using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 offset;
    private Material material;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        rigidbody2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        offset = (rigidbody2D.velocity.x * 0.1f) * velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;

    }


}
