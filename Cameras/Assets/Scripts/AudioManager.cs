using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;
    private string titleScene = "Title";
    private string creditScene = "EndGame";
    private string stageSelect = "ChooseStage";
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        foreach (Sound sound in sounds)
        {
            sound.AudioSource = gameObject.AddComponent<AudioSource>();
            sound.AudioSource.clip = sound.clip;
            sound.AudioSource.volume = sound.volume;
            sound.AudioSource.pitch = sound.pitch;
            sound.AudioSource.loop = sound.loop;


        }
    }
    private void Start()
    {
        if (SceneManager.GetActiveScene().name==titleScene )
        {
            Play("StartMenuMusic");
        }
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name != titleScene && SceneManager.GetActiveScene().name != creditScene && SceneManager.GetActiveScene().name != stageSelect)
        {
            Play("bgm");
            Stop("StartMenuMusic");
        }
        if(SceneManager.GetActiveScene().name==creditScene || SceneManager.GetActiveScene().name == stageSelect || SceneManager.GetActiveScene().name == titleScene)
        {
            Play("StartMenuMusic");
            Stop("bgm");
            
        }
    }

    public void Play(string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        if (!s.AudioSource.isPlaying)
        {
            s.AudioSource.Play();
        }
       


    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.AudioSource.Stop();

    }

}
