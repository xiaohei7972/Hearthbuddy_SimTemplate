using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_235 : SimTemplate //* 龙骑士塔瑞萨 Dragonrider Talritha
	{
        //<b>Deathrattle:</b> Give a Dragon in your hand +3/+3 and this <b>Deathrattle</b>.
        //<b>亡语：</b>使你手牌中的一张龙牌获得+3/+3以及此<b>亡语</b>。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.CARDRACE, TAG_RACE.DRAGON);
                if (hc != null)
                {
                    hc.addattack += 3;
                    hc.addHp += 3;
                    p.anzOwnExtraAngrHp += 6;
                }
            }
        }
    }
}