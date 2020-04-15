using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTowerAttack : MonoBehaviour {

	public GameObject m_projectilePrefab;
	public Transform m_shootPoint;

	public void Attack(Monster monster)
	{
		//var projectile = Instantiate(m_projectilePrefab, transform.position + Vector3.up * 1.5f, Quaternion.identity) as GameObject;
		//var projectileBeh = projectile.GetComponent<GuidedProjectile>();
		//projectileBeh.m_target = monster.gameObject;

		//m_shootPoint = monster.transform;
		Debug.Log("Attack");
		var projectile = Instantiate(m_projectilePrefab, m_shootPoint.position, m_shootPoint.rotation);
		var projectileBeh = projectile.GetComponent<CannonProjectile>();
		projectileBeh.m_target = monster.gameObject;
	}
}
