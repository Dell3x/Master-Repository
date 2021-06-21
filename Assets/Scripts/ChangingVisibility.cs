using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangingVisibility : MonoBehaviour
{
    private MeshRenderer fadeRenderer;

    private void Start()
    {
        fadeRenderer = GetComponent<MeshRenderer>();

        ChangeFade();
    }

    private void ChangeFade()
    {
        fadeRenderer.material.DOFade(Random.Range(0f, 1f), 2f)
        .OnComplete(ChangeFade);
    }

}
