using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTexto : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)] private string [] arrayTextos;
    [SerializeField] private UIManager uIManagar;
    [SerializeField] private Movimiento personaje;

    private int indice;

    private void Awake()
    {
        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>();
        uIManagar.ActivaDesactivaCajaTextos(false);
    }

    private void OnMouseDown()
    {
        float distancia = Vector2.Distance(this.gameObject.transform.position, personaje.transform.position);
        if (distancia <=2)
        {
            uIManagar.ActivaDesactivaCajaTextos(true);
            ActivaCartel();
        }
    }

    void ActivaCartel()
    {
        uIManagar.MostrarTextos("hola");
        if (indice < arrayTextos.Length)
        {
            uIManagar.MostrarTextos("hola");
            indice++;
        }
    }
}
