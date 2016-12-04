using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class RankingSceneController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    #endregion

    #region private property

    [SerializeField]
    Text rank1Name;

    [SerializeField]
    Text rank1Score;

    [SerializeField]
    Text rank2Name;

    [SerializeField]
    Text rank2Score;

    [SerializeField]
    Text rank3Name;

    [SerializeField]
    Text rank3Score;

    [SerializeField]
    Text rank4Name;

    [SerializeField]
    Text rank4Score;

    [SerializeField]
    Text rank5Name;

    [SerializeField]
    Text rank5Score;

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

        rank1Name.text = RankTbl[0, 1].ToString();
        rank1Score.text = RankTbl[0, 2].ToString();

        rank2Name.text = RankTbl[1, 1].ToString();
        rank2Score.text = RankTbl[1, 2].ToString();

        rank3Name.text = RankTbl[2, 1].ToString();
        rank3Score.text = RankTbl[2, 2].ToString();

        rank4Name.text = RankTbl[3, 1].ToString();
        rank4Score.text = RankTbl[3, 2].ToString();

        rank5Name.text = RankTbl[4, 1].ToString();
        rank5Score.text = RankTbl[4, 2].ToString();
    }

    #endregion
}