using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        AWSControl Obj = new AWSControl();

        //-------------------------------------------------
        //  ユーザデータ新規作成・更新もこれでできます♪
        //-------------------------------------------------
        Obj.UpdateUserData("AAAAAAAA", 10000000);
        Obj.UpdateUserData("BBBBBBBB", 9000000);
        Obj.UpdateUserData("CCCCCCCC", 8000000);
        Obj.UpdateUserData("DDDDDDDD", 7000000);
        Obj.UpdateUserData("EEEEEEEE", 6000000);
        //  ランキングリスト取得
        string[,] RankTbl = Obj.GetRankingInfo();

        //  トップ5位のみ表示
        for (int LineNo = 0; LineNo < 5; LineNo++)
        {
            System.Console.WriteLine(RankTbl[LineNo, 0].ToString() + " - " + RankTbl[LineNo, 1].ToString() + " - " + RankTbl[LineNo, 2].ToString());
        }
        System.Console.WriteLine("");
    }
}
