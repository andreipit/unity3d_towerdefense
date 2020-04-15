using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTowerAttack : MonoBehaviour {
	public GameObject m_projectilePrefab;

	public void Attack(Monster monster)
	{
		var projectile = Instantiate(m_projectilePrefab, transform.position + Vector3.up * 1.5f, Quaternion.identity) as GameObject;
		var projectileBeh = projectile.GetComponent<GuidedProjectile>();
		projectileBeh.m_target = monster.gameObject;
	}
}
