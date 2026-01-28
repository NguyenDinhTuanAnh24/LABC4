using UnityEngine;

public class Lab3_GlobalControl : MonoBehaviour
{
    void Update()
    {
        // Phím M: Mute/Unmute
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Đảo ngược trạng thái pause của AudioListener
            AudioListener.pause = !AudioListener.pause;
            Debug.Log("Audio Paused: " + AudioListener.pause);
        }

        // Lưu ý: Đề bài ghi Mute là Volume, P là Pause, ta sửa lại cho đúng đề:

        // Phím M: Mute (Tắt tiếng hoàn toàn nhưng nhạc vẫn chạy ngầm)
        if (Input.GetKeyDown(KeyCode.M))
        {
            AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;
            Debug.Log("Global Volume: " + AudioListener.volume);
        }

        // Phím P: Pause (Dừng hẳn luồng âm thanh)
        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioListener.pause = !AudioListener.pause;
            Debug.Log("Audio Paused state: " + AudioListener.pause);
        }
    }
}