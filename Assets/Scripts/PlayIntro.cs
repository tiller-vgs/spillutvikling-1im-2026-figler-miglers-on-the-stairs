using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayIntro : MonoBehaviour
{
    public VideoClip introVideo;
    public string nextSceneName;
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.clip = introVideo;
        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        videoPlayer.isLooping = false;
        videoPlayer.loopPointReached += OnVideoFinished;
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
