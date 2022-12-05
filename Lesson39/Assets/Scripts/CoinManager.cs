using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CoinManager : MonoBehaviour
{
    [SerializeField] AudioSource audioS;
    private AudioClip audioC;
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        audioC = audioS.clip;
    }

    // Update is called once per frame
    void Update()
    {
        audioS.pitch = SoundManager.instance.pitchValue;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.CompareTag("Player")) {
            // audioS.Play();
            // AudioSource.PlayClipAtPoint()
            audioS.PlayOneShot(audioC);
            SoundManager.instance.collectRate = Time.time + SoundManager.instance.nextCollectTime / SoundManager.instance.collectSpeed;
            SoundManager.instance.pitchValue += 0.2f;
        }
    }
}
