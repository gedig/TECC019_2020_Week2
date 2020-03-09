using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColourOnClick : MonoBehaviour
{
    private Material _mat;
    void Start()
    {
        _mat = GetComponent<Renderer>().material;
    }

    void OnMouseDown()
    {
        _mat.color = Random.ColorHSV();
    }
}
