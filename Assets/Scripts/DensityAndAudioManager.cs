using System.Collections.Generic;
using UnityEngine;

public class DensityAndAudioManager : MonoBehaviour
{
    [Header("Pasajeros")]
    public List<GameObject> passengers = new List<GameObject>();

    [Header("Audio")]
    public AudioSource busAudio;
    public float startVolume = 0f;
    public float endVolume = 1f;
    public float duration = 5f;

    [Header("City Movement")]
    public CityMover cityMover;

    private float elapsed = 0f;
    private bool isRunning = false;

    void Start()
    {
        foreach (var p in passengers)
            if (p != null)
                p.SetActive(false);

        if (busAudio != null)
        {
            busAudio.volume = startVolume;
            busAudio.loop = true;
        }

        if (cityMover != null)
            cityMover.StopAndReset();
    }

    public void StartScenario()
    {
        if (isRunning) return;

        isRunning = true;
        elapsed = 0f;

        if (busAudio != null && !busAudio.isPlaying)
            busAudio.Play();

        if (cityMover != null)
            cityMover.StartMoving();
    }

    public void ResetScenario()
    {
        isRunning = false;

        foreach (var p in passengers)
            if (p != null)
                p.SetActive(false);

        if (busAudio != null)
        {
            busAudio.volume = startVolume;
            busAudio.Stop();
        }

        if (cityMover != null)
            cityMover.StopAndReset();
    }

    void Update()
    {
        if (!isRunning) return;

        elapsed += Time.deltaTime;
        float t = Mathf.Clamp01(elapsed / duration);

        int total = passengers.Count;
        int shouldBeActive = Mathf.RoundToInt(t * total);

        for (int i = 0; i < total; i++)
        {
            bool active = i < shouldBeActive;

            if (passengers[i] != null && passengers[i].activeSelf != active)
                passengers[i].SetActive(active);
        }

        if (busAudio != null)
            busAudio.volume = Mathf.Lerp(startVolume, endVolume, t);

        if (t >= 1f)
            isRunning = false;
    }
}
