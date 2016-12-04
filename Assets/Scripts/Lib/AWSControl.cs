using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net;
using System.IO;
using System.Collections.Specialized;

public class AWSControl
{
    public string sURL = "http://melon-group.net/";
    //------------------------------------------------------------------------
    //  コンストラクタ
    //------------------------------------------------------------------------
    public AWSControl()
    {
    }
    //------------------------------------------------------------------------
    //  ランキング情報の取得
    //------------------------------------------------------------------------
    public string[,] GetRankingInfo()
    {
        var httpWebRequest = (HttpWebRequest) WebRequest.Create(this.sURL);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            streamWriter.Write("GETRANKING,---");
            streamWriter.Flush();
            streamWriter.Close();
        }
        var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();

        string[,] RankingList = new string[5, 3] {
            { "1", "----", "0" },
            { "2", "----", "0" },
            { "3", "----", "0" },
            { "4", "----", "0" },
            { "5", "----", "0" }
        };

        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();

            string[] lines = result.Split('\n');
            for (int LineNo = 0; LineNo < 5; LineNo++)
            {
                string[] Values = lines[LineNo].Split(',');
                for (int Col = 0; Col < Values.Length; Col++)
                {
                    RankingList[LineNo, Col + 1] = Values[Col].ToString().Replace("post", "");
                }
            }
        }
        return RankingList;
    }

    public static string Mid(string str, int start, int len)
    {
        string retVal = "";
        if (start <= 0)
        {
            return retVal;
        }
        if (len < 0)
        {
            return retVal;
        }
        if (str == null || str.Length < start)
        {
            return retVal;
        }
        if (str.Length < (start + len))
        {
            return str.Substring(start - 1);
        }
        return str.Substring(start - 1, len);
    }
    //------------------------------------------------------------------------
    //  ユーザ情報のスコア更新(サーバで既存ユーザかどうか判定し、なければ自動
    //  生成するので基本これを呼び出すだけでよいです。)
    //------------------------------------------------------------------------
    public int UpdateUserData(String UserName = "", int Score = 0)
    {
        var httpWebRequest = (HttpWebRequest) WebRequest.Create(this.sURL);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            String Commnad = String.Format("UPDATEUSER,{0}-{1}", Mid(UserName, 1, 8), Score.ToString());
            streamWriter.Write(Commnad);
            streamWriter.Flush();
            streamWriter.Close();
        }
        var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();

        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
        }
        return 0;
    }
};
