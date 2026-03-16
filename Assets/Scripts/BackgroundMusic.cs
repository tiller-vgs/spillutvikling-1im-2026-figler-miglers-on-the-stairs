using UnityEngine;

namespace Assets.Scripts
{
	[RequireComponent(typeof(AudioSource))]
	public class BackgroundMusic : MonoBehaviour
	{
		[SerializeField] AudioClip musicClip;
		[Range(0f, 1f)] [SerializeField] float volume = 0.3f;

		AudioSource _audioSource;

		void Awake()
		{
			_audioSource = GetComponent<AudioSource>();
			_audioSource.clip = musicClip;
			_audioSource.volume = volume;
			_audioSource.loop = true;
			_audioSource.playOnAwake = true;
			_audioSource.spatialBlend = 0f; // 2d
			_audioSource.Play();
		}
	}
}
