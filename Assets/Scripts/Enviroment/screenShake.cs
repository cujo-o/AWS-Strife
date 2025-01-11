using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class screenShake : MonoBehaviour
{
    public static screenShake instance { get; private set; }
    private CinemachineVirtualCamera cinemachine;
    private float shaketimer;

    void Awake()
    {
        instance = this;
        cinemachine = GetComponent<CinemachineVirtualCamera>();
    }
  
    void Update()
    {
        if (shaketimer > 0f)
        { 
            shaketimer -= Time.deltaTime;
            if (shaketimer <= 0f)
            {
                CinemachineBasicMultiChannelPerlin basicMultiChannelPerlin = cinemachine.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                basicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }

    public void shakeCamera(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin basicMultiChannelPerlin = cinemachine.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        basicMultiChannelPerlin.m_AmplitudeGain = intensity;
        shaketimer = time;
    }
}
 
