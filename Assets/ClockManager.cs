using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    [SerializeField] private GameObject hourHand;
    [SerializeField] private GameObject minuteHand;
    [SerializeField] private GameObject secondHand;

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;

        float secondAngle = 90 + time.Second * 3;
        float minuteAngle = 90 + time.Minute * 3 + time.Second / 20;
        float hourAngle = 90 + time.Hour / 24 * 180 + time.Minute / 8;

        hourHand.transform.rotation = Quaternion.Euler(0, hourAngle, 0);
        minuteHand.transform.rotation = Quaternion.Euler(0, minuteAngle, 0);
        secondHand.transform.rotation = Quaternion.Euler(secondAngle, 0, 0);
    }
}
