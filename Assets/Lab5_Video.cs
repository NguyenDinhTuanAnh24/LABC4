using UnityEngine;
using UnityEngine.Video; // Nhớ dòng này

public class Lab5_Video : MonoBehaviour
{
    public VideoPlayer myVideo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            myVideo.Play();
        }
    }
}