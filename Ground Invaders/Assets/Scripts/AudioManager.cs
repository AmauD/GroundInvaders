using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region publics methods

    public void Play(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    #endregion
}
