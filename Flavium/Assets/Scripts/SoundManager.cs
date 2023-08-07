using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SoundManager : MonoBehaviour
{
    public static SoundManager snd;
    public AudioSource audio_;
    private AudioClip[] pianoSounds;
    private int iSounds = 0;

    void Start()
    {
        snd = this;
        audio_= GetComponent<AudioSource>();
        pianoSounds = Resources.LoadAll<AudioClip>("pianoSounds");
    }

    public void PlayPianoSounds()
    {
        // iSounds++;

        // randomSounds = Random.Range(0, 5);
        audio_.PlayOneShot(pianoSounds[iSounds++]);
        

        if(iSounds == 5) 
        {
            iSounds = 0; 
        }
    }


}
