using UnityEngine;

namespace yo
{
    /// <summary>
    /// 音效系統
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 撥放音效
        /// </summary>
        /// <param name="sound">要撥放的音效</param>
        public void PlaySound(AudioClip sound)
        {
            aud.PlayOneShot(sound);
        }
    }
}
