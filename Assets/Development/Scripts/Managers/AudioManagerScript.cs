using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioManagerScript instance;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _audioClips;
    

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void carEngineSound()
    {
        _audioSource.clip=_audioClips[1];
        _audioSource.Play();
    }
}
