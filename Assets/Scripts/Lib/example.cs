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
        //  ���[�U�f�[�^�V�K�쐬�E�X�V������łł��܂���
        //-------------------------------------------------
        Obj.UpdateUserData("AAAAAAAA", 10000000);
        Obj.UpdateUserData("BBBBBBBB", 9000000);
        Obj.UpdateUserData("CCCCCCCC", 8000000);
        Obj.UpdateUserData("DDDDDDDD", 7000000);
        Obj.UpdateUserData("EEEEEEEE", 6000000);
        //  �����L���O���X�g�擾
        string[,] RankTbl = Obj.GetRankingInfo();

        //  �g�b�v5�ʂ̂ݕ\��
        for (int LineNo = 0; LineNo < 5; LineNo++)
        {
            System.Console.WriteLine(RankTbl[LineNo, 0].ToString() + " - " + RankTbl[LineNo, 1].ToString() + " - " + RankTbl[LineNo, 2].ToString());
        }
        System.Console.WriteLine("");
    }
}
