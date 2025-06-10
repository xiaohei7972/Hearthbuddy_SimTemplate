using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_125 : SimTemplate //* 安全检查员 Safety Inspector
	{
        //[x]<b>Battlecry:</b> Shuffle the_lowest-Cost card from your hand into your deck. Draw a card.
        //<b>战吼：</b>把你手牌中法力值消耗最低的牌洗入牌库。抽一张牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int mincost = 10;
            Handmanager.Handcard hcard = new Handmanager.Handcard();
            foreach(Handmanager.Handcard hc in p.owncards)
            {
                if(hc.manacost < mincost)
                {
                    mincost = hc.manacost;
                    hcard = hc;
                }
            }
            p.removeCard(hcard);
            p.drawACard(CardDB.cardIDEnum.None, true);
        }
    }
}
