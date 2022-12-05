using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public float nextCollectTime = 1;
    public float collectSpeed = 1;
    public float collectRate;
    [Header("Sound Pitch Value")]
    public float pitchValue = 1;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > collectRate) {
            pitchValue = 1;
        }
    }
}
