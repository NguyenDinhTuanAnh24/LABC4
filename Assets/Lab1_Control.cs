using UnityEngine;

public class Lab1_Control : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // Nếu chưa gán ở Inspector thì tự lấy component trên object này
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Nhấn Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            Debug.Log("Audio Playing");
        }

        // Nhấn S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
            Debug.Log("Audio Stopped");
        }
    }
}