using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTowerTargeting : MonoBehaviour {

	public float m_range = 10f;

	public Monster FindTarget()
	{
		Debug.Log("FindTarget");
		foreach (var monster in FindObjectsOfType<Monster>())
		{
			if (Vector3.Distance(transform.position, monster.transform.position) < m_range)
				return monster;
		}
		return null;
	}
}
