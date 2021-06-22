using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Planet : MonoBehaviour
{
    public Vector3 planetRotation;
    private Transform planetTransform;
    private AudioSource audioSource;

    [SerializeField] private float durationOfRotation;

    private void Start()
    {
        planetTransform = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();

        PlanetRotation();
    }

    private void PlanetRotation()
    {
        planetTransform.DORotate(planetRotation, durationOfRotation, RotateMode.FastBeyond360)
        .SetEase(Ease.Linear)
        .OnComplete(() => { PlanetRotation(); audioSource.Play(); });
    }
}
