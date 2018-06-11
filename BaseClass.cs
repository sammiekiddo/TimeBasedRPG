using System.Collections;
using System.Collections.Generic;//for List
using UnityEngine;




[System.Serializable]
public class BaseClass
{
	//public string name;
	public string theName;

	//changed from float
	public int baseHP;
	public float curHP;

	public int baseMP;
	public float curMP;

	public int baseATK;
	public float curATK;
	public int baseDEF;
	public float curDEF;

	public List<BaseAttack> Attacks = new List<BaseAttack> ();//list for inputing melee attacks
	//public List<BaseAttack> MagicAttack = new List<BaseAttack>();//list for inputing magic attacks


}