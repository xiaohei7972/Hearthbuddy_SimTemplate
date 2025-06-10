using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_110 : SimTemplate //* 砰砰博士 Dr. Boom
//<b>Battlecry:</b> Summon two 1/1 Boom EmbeddedRoutine. <i>WARNING: EmbeddedRoutine may explode.</i>
//<b>战吼：</b>召唤两个1/1的砰砰机器人。<i>警告：该机器人随时可能爆炸。</i> 
    {

        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_110t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos, own.own);
            p.callKid(kid, own.zonepos - 1, own.own);
        }


    }

}