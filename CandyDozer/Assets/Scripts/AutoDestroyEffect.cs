using UnityEngine;
using System.Collections;

public class AutoDestroyEffect : MonoBehaviour 
{
	ParticleSystem particle;
	
	void Start ()
	{
		particle = GetComponent<ParticleSystem>();
	}
	
	void Update ()
	{
		// パーティクルの再生が終了したらGameObjectを削除
		if (particle.isPlaying == false) Destroy(gameObject);
	}
}