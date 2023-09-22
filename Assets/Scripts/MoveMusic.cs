using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMusic : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float radio;
    private float angulo;
 
    void Start()
    {
 
    }
 
    void FixedUpdate()
    {
        angulo += velocidad / (radio * Mathf.PI * 2.0f);
        transform.position = new Vector3(Mathf.Cos(angulo), 0, Mathf.Sin(angulo)) * radio;
    }
}
