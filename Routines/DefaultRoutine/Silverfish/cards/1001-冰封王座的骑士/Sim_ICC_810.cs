using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_810: SimTemplate //* 亡斧惩罚者 Deathaxe Punisher
//<b>Battlecry:</b> Give a random <b>Lifesteal</b> minion in your hand +2/+2.
//<b>战吼：</b>随机使你手牌中一个具有<b>吸血</b>的随从获得+2/+2。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.LIFESTEAL);
                if (hc != null)
                {
                    hc.addattack += 2;
                    hc.addHp += 2;
                    p.anzOwnExtraAngrHp += 4;
                }
            }
        }
    }
}