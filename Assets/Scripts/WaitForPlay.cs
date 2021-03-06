﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaitForPlay : MonoBehaviour
{
    public Text countdown;

    void Awake()
    {
        Time.timeScale = 0.001f;
        StartCoroutine(GetReady());
    }

    /*
    IEnumerator Start()
    {
        yield return StartCoroutine("Pause");
    }


    IEnumerator Pause()
    {
        Time.timeScale = 0.001f;
        yield return StartCoroutine("GetReady");
        //yield return new WaitForSeconds(0.001f);
        Time.timeScale = 1;
    }
    */

    IEnumerator GetReady()
    {
        countdown.text = "3";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "2";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "1";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "GO!";
        yield return new WaitForSeconds(0.001f);

        countdown.text = "";
        Time.timeScale = 1;
    }
}