using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    private bool isSlowed = false;

    public AudioClip WitchTimeSound;

    void Update()
    {
        if (!isSlowed && Input.GetButtonDown("Fire2")) 
        {
            StartCoroutine(SlowTime());
        }
    }

    private IEnumerator SlowTime() 
    {
        AudioManager.instance.PlayAudio(WitchTimeSound, "WitchTimeSound");

        isSlowed = true;
        Time.timeScale = 0.25f;
        yield return new WaitForSecondsRealtime(5.512f);
        Time.timeScale = 1.0f;
        isSlowed = false;
    }
}
