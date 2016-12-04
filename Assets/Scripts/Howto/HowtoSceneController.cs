using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HowtoSceneController : MonoBehaviour
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
    /// タイトルシーンに遷移します。
    /// </summary>
    public void OnClick_Title()
    {
        SceneManager.LoadScene(SceneName.Title);
    }

    #endregion

    #region private method

    #endregion

    #region event

    #endregion
}