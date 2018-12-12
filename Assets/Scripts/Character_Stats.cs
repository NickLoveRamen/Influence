using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stats : MonoBehaviour {
	//characters stats
	public Stat maxHealth;
	public Stat Damage;
	
	//keep current health private
	private int currentHealth;

	//constructor *basically*
	void Awake(){
		Debug.Log(transform.name + " Awake() has run");
		currentHealth = maxHealth.GetValue();
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.G)){
			TakeDamage(20);
		}
	}

	//take damage
	public void TakeDamage(int damage){
		currentHealth -= damage;
		Debug.Log(transform.name + " takes " + damage + " points of damage");

		//if health is now less than 0, die
		if(currentHealth <= 0){
			Die();
		}
	}

	//death method to be overridden in child classes
	protected virtual void Die(){
		Debug.Log(transform.name + " died");
	}
}
