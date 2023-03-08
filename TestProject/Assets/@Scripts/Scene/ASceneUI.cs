using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class ASceneUI : BaseScene
{
    UI_AScene _ASceneUI;

    protected override bool Init()
    {
        
        if (base.Init() == false)
            return false;

        SceneType = Define.SceneType.AScene;
        Managers.UI.ShowSceneUI<UI_AScene>(callback: (ASceneUI) =>
        {
            _ASceneUI = ASceneUI;
        });

        Managers.Sound.Clear();
        //Managers.Sound.Play(Sound.Bgm, "Sound_OnStage");


        return true;
    }

}
