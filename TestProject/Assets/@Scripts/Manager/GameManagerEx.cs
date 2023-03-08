using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using static Define;

[Serializable]
public class GameData
{
	public bool BGMOn = true;
	public bool EffectSoundOn = true;
}

public class GameManagerEx
{
	GameData _gameData = new GameData();
	public GameData SaveData { get { return _gameData; } set { _gameData = value; } }

	#region Stage

    #endregion

    #region Player

	#endregion

	#region Weapon

    #endregion

    #region Util
	
    #endregion

    #region Option
    public bool BGMOn
	{
		get { return _gameData.BGMOn; }
		set { _gameData.BGMOn = value; }
	}

	public bool EffectSoundOn
    {
        get { return _gameData.EffectSoundOn; }
		set { _gameData.EffectSoundOn = value; }
    }
	#endregion

    public float ZRotation { get; set; }
	public bool IsLoaded = false;

	public void Init()
    {
		_path = Application.persistentDataPath + "/SaveData.json";
		if (LoadGame())
			return;
		
		IsLoaded = true;

		SaveGame();
    }

	public event Action OnPlayerInput;
	public void PlayerInput()
    {
		OnPlayerInput?.Invoke();
    }

    public event Action OnPlayerAttack;

	public void PlayerAttack()
	{
		OnPlayerAttack?.Invoke();
	}

	#region Save&Load
	string _path;

	public void SaveGame()
    {
		string jsonStr = JsonUtility.ToJson(Managers.Game.SaveData);
		File.WriteAllText(_path, jsonStr);
    }

	public bool LoadGame()
    {
		if (File.Exists(_path) == false)
			return false;

        string fileStr = File.ReadAllText(_path);
		GameData data = JsonUtility.FromJson<GameData>(fileStr);
		if (data != null)
			Managers.Game.SaveData = data;

		IsLoaded = true;
		return true;
    }
    #endregion
}