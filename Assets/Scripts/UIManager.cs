using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private bool isPressedStop;

    [SerializeField] private Slider slider;

    void Update()
    {
        if (!isPressedStop)
        {
            Time.timeScale = slider.value;
        }
    }


    public void PlayButton()
    {
        isPressedStop = false;
        Time.timeScale = slider.value;
    }

    public void StopButton()
    {
        isPressedStop = true;
        Time.timeScale = 0;
    }
}
