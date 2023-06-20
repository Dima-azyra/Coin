using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_change : MonoBehaviour
{
    Material mat_obj;

    private void Awake()
    {
        mat_obj = GetComponent<Renderer>().material;
    }

    private void OnMouseDown()
    {
        mat_obj.SetColor("_Color", new Color(Random.Range(0.01f, 0.99f), Random.Range(0.01f, 0.99f), Random.Range(0.01f, 0.99f), 1));
    }
}
