﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    #endregion

    #region private property

    #endregion

    #region public method

    /// <summary>
    /// 遊び方シーンに遷移します。
    /// </summary>
    public void OnClick_Howto()
    {
        SceneManager.LoadScene(SceneName.Howto);
    }

    #endregion

    #region private method

    #endregion

    #region event

    #endregion
}