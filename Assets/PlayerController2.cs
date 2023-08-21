using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    private Rigidbody2D rb;
    private bool isGrounded;


    public Transform armaPadre;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float actualY = armaPadre.localEulerAngles.y;
        armaPadre.localEulerAngles = new Vector3(0, actualY + 180, 0);

    }

    void Update()
    {
        // Movimiento del jugador con las flechas direccionales
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        transform.position += movement * Time.deltaTime * speed;

        // Salto del jugador con la tecla espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }

        // Ataque del jugador con la tecla "a"
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Código para el ataque aquí
        }

        // Barrido del jugador con la tecla "w"
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Código para el barrido aquí
        }

        // Lanzamiento de objeto del jugador con la tecla "d"
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Código para el lanzamiento de objeto aquí
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}