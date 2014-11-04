using UnityEngine;
using System.Collections;

public class iceMagic : MonoBehaviour {

    public Texture[] frames;   //����һ�����飬�����ͼ����������inspector�ῴ��һ��frames�����飬����ĳ��ȿ����Լ����1���ʹ���ֻ��1��ͼ�����԰�һ��texture�Ͻ�ȥ����2�ʹ���2�ţ��Դ�����

    public int framesPerSecond = 10;  //����fps,ÿ�벥�ż�֡��Ӱ�춯�����ٶȡ�

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    int index = (int)(Time.time * framesPerSecond) % frames.Length;    //���������������ʱ��ı䣬��ǰʱ�����fps����֡��ȡ�࣬���ǲ��ŵĵ�ǰ֡������update����
        renderer.material.mainTexture = frames[index];    //��Ⱦ�����ͼ
	}
}
