using UnityEngine;
using UnityEngine.Video;

public class Lab7_Events : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Đăng ký sự kiện khi video chạy hết
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video đã kết thúc!");
        // Tại đây có thể hiện UI Button hoặc chuyển Scene
    }
}