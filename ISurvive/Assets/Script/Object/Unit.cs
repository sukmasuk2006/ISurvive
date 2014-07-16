using UnityEngine;
using System.Collections;

public class Unit  {

	protected string iconPath;
	protected string name;
	protected string description;
	protected int level;
	protected float healthPoint;
	protected float attackPoint;
	protected float defensePoint;
	protected float movementPoint; // aspd
	protected float critical;
	protected float magicAttack;
	protected float magicDefense;
	protected float hitRate;
	protected float evasionRate;
	protected Status status;

	public Unit(string iconPath,string name,string desc, int lev,float str,float agi,float intel,
	           float dex, float vit){
		this.iconPath = iconPath;
		this.name = name;
		this.description = desc;
		this.level = lev;
		status = new Status (str, agi, intel, dex, vit);
		attackPoint = status.STR;
		defensePoint = status.VIT;
		movementPoint = status.AGI;
		healthPoint = ((status.VIT * (8 / 10)) + (status.STR * (2 / 10))) * 10;
	
	}

	public string IconPath {
		get {
			return iconPath;
		}
		set {
			iconPath = value;
		}
	}

	public string Name {
		get {
			return name;
		}
		set {
			name = value;
		}
	}

	public string Description {
		get {
			return description;
		}
		set {
			description = value;
		}
	}

	public int Level {
		get {
			return level;
		}
		set {
			level = value;
		}
	}

	public float HealthPoint {
		get {
			return healthPoint;
		}
		set {
			healthPoint = value;
		}
	}

	public float AttackPoint {
		get {
			return attackPoint;
		}
		set {
			attackPoint = value;
		}
	}

	public float DefensePoint {
		get {
			return defensePoint;
		}
		set {
			defensePoint = value;
		}
	}

	public float MovementPoint {
		get {
			return movementPoint;
		}
		set {
			movementPoint = value;
		}
	}

	public float Critical {
		get {
			return critical;
		}
		set {
			critical = value;
		}
	}

	public float MagicAttack {
		get {
			return magicAttack;
		}
		set {
			magicAttack = value;
		}
	}

	public float MagicDefense {
		get {
			return magicDefense;
		}
		set {
			magicDefense = value;
		}
	}

	public Status Status {
		get {
			return status;
		}
		set {
			status = value;
		}
	}
}
