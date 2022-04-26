using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] soundEffects;

    public AudioSource bgm, LevelEndMusic, bossMusic;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }


    void Update()
    {

    }

    public void PlaySFX(int soundToPlay)
    {
        soundEffects[soundToPlay].Stop();

        soundEffects[soundToPlay].pitch = Random.Range(.9f, 1.1f);

        soundEffects[soundToPlay].Play();
    }

    public void PlayLevelVictory()
    {
        bgm.Stop();
        LevelEndMusic.Play();
    }

    public void PlayBossMusic()
    {
        bgm.Stop();
        bossMusic.Play();
    }

    public void StopBossMusic()
    {
        bossMusic.Stop();
        bgm.Play();
    }

}
