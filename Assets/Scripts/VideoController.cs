using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public Renderer rend;
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (rend.isVisible)
        {
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
        else
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
        }
    }
}
