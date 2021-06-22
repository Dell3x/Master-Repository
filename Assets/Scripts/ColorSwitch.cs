using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColorSwitch : MonoBehaviour
{
    [SerializeField] MeshRenderer planetRenderer;
    private void Start()
    {
        ChangingColor();
    }

    private void ChangingColor()
    {
        planetRenderer.material.DOColor(GetRandomColor(), 1f).OnComplete(ChangingColor);
    }


    private Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
    }
}
