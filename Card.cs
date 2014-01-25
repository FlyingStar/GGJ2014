using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	public static int width = 64;
	public static int height = 64;

	public enum Id
	{
		Attack = 0,
		AttackBuff,
		AttackMove,
		Defense,
		Move,
		MoveAttack,
		Stun,
		Max
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
