using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangingOfSize : MonoBehaviour
{
    private Transform planetTransform;

    private void Start()
    {
        planetTransform = GetComponent<Transform>();

        ChangeScale();
    }

    private void ChangeScale()
    {
        planetTransform.DOScale(new Vector3(Random.Range(0f, 4f), Random.Range(0f, 4f), Random.Range(0f, 4f)), 1f)
        .OnComplete(ChangeScale);
    }

}
