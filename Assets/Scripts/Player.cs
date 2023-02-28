using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /* Script comentado para coparar commits en Git */
    // Segunco comment
    Rigidbody2D rB; // Variable que almacera el Rigidbody2D
    [SerializeField] float xSpeed; //  Velocidad de movimiento
    float xMove; // Guarda el input en esta variable
    [SerializeField] private string horizontal;

    void Start()
    {
        rB = GetComponent<Rigidbody2D>(); // Trae el RB de desde unity
    }
    //Comentario entre el starr y el update
    void Update()
    {
        // xMove    
        xMove = Input.GetAxisRaw(horizontal);
        rB.velocity = new Vector2(xMove * xSpeed, rB.velocity.y);
    }
}