using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject cajaTexto;
    [SerializeField] private TMP_Text textoDialogo;

    public void ActivaDesactivaCajaTextos (bool activado)
    {
        cajaTexto.SetActive(activado);
    }

    public void MostrarTextos (string texto)
    {
        textoDialogo.text = texto.ToString();
    }
}
