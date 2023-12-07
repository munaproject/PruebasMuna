using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] public float velocidad = 5;

    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer spriteLille;


    Vector2 move;

    // Start is called before the first frame update
    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.freezeRotation = true; //evita que lille gire, se agradece
        anim = GetComponentInChildren<Animator>();
        spriteLille = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2();
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        //move.Normalize();   //Se normaliza las diagonales, sin esta linea de codigo se iria mas rapido en diagonal

        if (move != Vector2.zero)   //En cuanto move sea distinto de 0, es decir, en cuanto se pulse una tecla de movimiento
        {
            anim.SetFloat("Movimiento X", move.x);
            anim.SetFloat("Movimiento Y", move.y);
            anim.SetBool("Caminar", true);
        }
        else
        {
            anim.SetBool("Caminar", false);
        }

        if (Input.GetKey(KeyCode.LeftShift)) //Correr
        {
            velocidad=10;
        }
        else{
            velocidad=5;
        }
            rig.MovePosition(transform.position + (Vector3)move * Time.deltaTime * velocidad);  //Sirve para dejar al personaje mirando en la posicion que queda al parar de andar
                                                                                            //Time.deltaTime sirve para normalizar la velocidad independientemente de los frames
        
    }
}
