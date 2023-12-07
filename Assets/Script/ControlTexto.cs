using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTexto : MonoBehaviour
{
    [SerializeField, TextArea(3, 10)] private string [] arrayTextos;
    [SerializeField] private UIManager uIManager;
    [SerializeField] private Movimiento personaje;

    private int indice;

    private void Awake()
    {
        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>();
        uIManager.ActivaDesactivaCajaTextos(false);
    }

    private void OnMouseDown()
    {
        float distancia = Vector2.Distance(this.gameObject.transform.position, personaje.transform.position);
        if (distancia <=2)
        {
            uIManager.ActivaDesactivaCajaTextos(true);
            ActivaCartel();
        }
    }

    void ActivaCartel()
    {
        if (indice < arrayTextos.Length)
        {
            uIManager.MostrarTextos(arrayTextos[indice]);
            indice++;
        }else{
            uIManager.ActivaDesactivaCajaTextos(false);
        }
    }
}
