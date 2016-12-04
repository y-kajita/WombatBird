using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RankingSceneController : MonoBehaviour
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

    void Start()
    {
        AWSControl Obj = new AWSControl();

        string[,] RankTbl = Obj.GetRankingInfo();

        //  僩僢僾5埵偺傒昞帵
        for (int LineNo = 0; LineNo < 5; LineNo++)
        {
            Debug.Log(RankTbl[LineNo, 0].ToString() + " - " + RankTbl[LineNo, 1].ToString() + " - " + RankTbl[LineNo, 2].ToString());
        }

        System.Console.WriteLine("");
    }

    #endregion
}