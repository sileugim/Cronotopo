using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieManagger : MonoBehaviour
{
    public Camera camera_;
    public VideoPlayer videoPlayer; 
    
    private void Awake()
    {
        camera_ = Camera.main;
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
