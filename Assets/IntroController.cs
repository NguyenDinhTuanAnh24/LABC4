using UnityEngine;
using UnityEngine.SceneManagement; // Cần thư viện này để chuyển cảnh
using UnityEngine.Video;           // Cần thư viện này để xử lý Video

public class IntroController : MonoBehaviour
{
    public VideoPlayer introVideo;
    public string sceneToLoad = "GameplayScene"; // Tên Scene đích

    void Start()
    {
        // Cách 1: Tự động chuyển cảnh khi video chạy hết
        // loopPointReached là sự kiện "khi video chạy đến điểm cuối cùng"
        introVideo.loopPointReached += OnVideoEnd;
    }

    // Hàm này được gọi khi video hết
    void OnVideoEnd(VideoPlayer vp)
    {
        LoadGameplay();
    }

    // Hàm này dùng cho nút SKIP (Public để nút bấm gọi được)
    public void SkipVideo()
    {
        LoadGameplay();
    }

    // Hàm chung để chuyển cảnh
    void LoadGameplay()
    {
        Debug.Log("Chuyển sang Gameplay...");
        SceneManager.LoadScene(sceneToLoad);
    }
}