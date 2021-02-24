using UnityEngine;
using System.Collections;

public class playSound : MonoBehaviour
{

    [SerializeField] private AudioClip[] clips;
    private int clipIndex;
    private AudioSource audio;
    private bool audioPlaying = false;

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));

        clipIndex = Random.Range(0, clips.Length);
        audio.PlayOneShot(clips[clipIndex], 1f);

        yield return new WaitForSeconds(clips[clipIndex].length);
        StartCoroutine(PlaySound());
    }
}