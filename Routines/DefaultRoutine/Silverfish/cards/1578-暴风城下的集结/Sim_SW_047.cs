using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_047 : SimTemplate //* 大领主弗塔根 Highlord Fordragon
	{
        //[x]<b>Divine Shield</b>After a friendly minion loses<b>Divine Shield</b>, give a minion__in your hand +5/+5.
        //<b>圣盾</b>在一个友方随从失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+5/+5。
        public override void onMinionLosesDivineShield(Playfield p, Minion m, int num)
        {
            if (m.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                if (hc != null)
                {
                    hc.addattack += 5;
                    hc.addHp += 5;
                    p.anzOwnExtraAngrHp += 10;
                }
            }
        }
    }
}
