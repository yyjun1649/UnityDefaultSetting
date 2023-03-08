using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class UI_DefaultPopup : UI_Popup
{
    enum GameObjects
    {

    }

    enum Images
    {

    }

    enum Texts
    {

    }

    enum Buttons
    {

    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindObject(typeof(GameObjects));
        BindImage(typeof(Images));
        BindButton(typeof(Buttons));
        BindText(typeof(Texts));

        //GetButton((int)Buttons.).gameObject.BindEvent();

        Refresh();

        return true;
    }

    public void SetInfo()
    {

    }

    void Refresh()
    {
        if (_init == false)
            return;
    }

    #region EventHandler

    void OnClickButton()
    {

    }

    #endregion
}
