using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

    private const int bufferFrames = 100;
    private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];

    void Start() {
        MyKeyFrame testKey = new MyKeyFrame(1.0f, Vector3.up, Quaternion.identity);
    }

    void Update() {
        
    }

}

public class MyKeyFrame {

    public float frameTime;
    public Vector3 position;
    public Quaternion rotation;

    public MyKeyFrame(float time, Vector3 pos, Quaternion rot) {
        frameTime = time;
        position = pos;
        rotation = rot;
    }

}
