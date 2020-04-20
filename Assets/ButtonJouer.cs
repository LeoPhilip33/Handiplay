using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJouer : MonoBehaviour
{
    public GameObject hideOptions;
    public GameObject hideJouer;
    public GameObject hideCredits;

    public AudioClip impact;
    AudioSource audioSource;

    public void ButtonClick()
    {
        hideOptions.SetActive(false);
        hideJouer.SetActive(false);
        hideCredits.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(impact, 0.7F);
    }
}
