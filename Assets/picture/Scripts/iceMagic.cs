using UnityEngine;
using System.Collections;

public class iceMagic : MonoBehaviour {

    public Texture[] frames;   //声明一个数组，存放贴图，声明后，在inspector会看到一个frames的数组，数组的长度可以自己填，填1，就代表只有1张图，可以把一张texture拖进去，填2就代表2张，以此类推

    public int framesPerSecond = 10;  //声明fps,每秒播放几帧，影响动画的速度。

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    int index = (int)(Time.time * framesPerSecond) % frames.Length;    //数组的索引，根据时间改变，当前时间乘以fps与总帧数取余，就是播放的当前帧，随着update更新
        renderer.material.mainTexture = frames[index];    //渲染这个贴图
	}
}
