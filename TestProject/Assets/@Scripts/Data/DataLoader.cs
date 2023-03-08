using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using static Define;

/*
[Serializable]
public class TextData
{
	public string TextID;
	public string Kor;
	public string Eng;
}

[Serializable]
public class TextDataLoader : ILoader<string, TextData>
{
	public List<TextData> texts = new List<TextData>();

	public Dictionary<string, TextData> MakeDic()
	{
		Dictionary<string, TextData> dic = new Dictionary<string, TextData>();

		foreach (TextData text in texts)
			dic.Add(text.TextID, text);

		return dic;
	}

	public bool Validate()
	{
		return true;
	}
}

[Serializable]
public class MonsterData
{
	public int TemplateID;
	public string NameID;
	public string Prefab;
	public string SpriteID;
	public int Hp;
	public int Damage;
	public int MoveTurn;
	public int MoveSpeed;
	public int AttackRange;
	public int DropCoin;
	public int SpecialAbility;
}

[Serializable]
public class MonsterDataLoader : ILoader<int, MonsterData>
{
	public List<MonsterData> monsters = new List<MonsterData>();

	public Dictionary<int, MonsterData> MakeDic()
	{
		Dictionary<int, MonsterData> dic = new Dictionary<int, MonsterData>();

		foreach (MonsterData monster in monsters)
			dic.Add(monster.TemplateID, monster);

		return dic;
	}

	public bool Validate()
	{
		return true;
	}
}
*/