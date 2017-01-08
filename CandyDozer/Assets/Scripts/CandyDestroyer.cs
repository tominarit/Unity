using UnityEngine;
using System.Collections;

public class CandyDestroyer : MonoBehaviour 
{
	public CandyHolder candyHolder;
	public int reward;
	public GameObject effectPrefab;
	public Vector3 effectRotation;
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Candy")
		{
			// 指定数だけCandyのストックを増やす			
			candyHolder.AddCandy(reward);
			
			// オブジェクトを削除
			Destroy(other.gameObject);
			
			if (effectPrefab != null) 
			{
				// Candyのポジションにエフェクトを生成	
				Instantiate(
					effectPrefab, 
					other.transform.position, 
					Quaternion.Euler(effectRotation)
				);
			}
		}
	}
}