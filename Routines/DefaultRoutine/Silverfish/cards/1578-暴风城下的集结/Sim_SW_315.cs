using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_315 : SimTemplate //* 联盟旗手 Alliance Bannerman
	{
        //[x]<b>Battlecry:</b> Draw a minion.Give minions in yourhand +1/+1.
        //<b>战吼：</b>抽一张随从牌。使你手牌中的随从牌获得+1/+1。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        hc.addattack++;
                        hc.addHp++;
                        p.anzOwnExtraAngrHp += 2;
                    }
                }
            }
            p.evaluatePenality -= 10;
        }
    }
}
