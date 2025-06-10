using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_003 : SimTemplate //* 应急木工 JerryRigCarpenter
    {
        //战吼：抽一张抉择法术牌并将其拆分。
        //Battlecry: Draw a Choose One spell and split it.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, own.own);
        }

    }
}
