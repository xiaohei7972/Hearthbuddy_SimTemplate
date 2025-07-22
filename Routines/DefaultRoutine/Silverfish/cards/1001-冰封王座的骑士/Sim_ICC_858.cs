using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_858: SimTemplate //* 浴火者伯瓦尔 Bolvar, Fireblood
//<b>Divine Shield</b>After a friendly minion loses_<b>Divine Shield</b>, gain +2 Attack.
//<b>圣盾</b>在一个友方随从失去<b>圣盾</b>后，获得+2攻击力。 
    {
        

        public override void onMinionLosesDivineShield(Playfield p, Minion m, int num)
        {
            p.minionGetBuffed(m, 2 * num, 0);
        }
    }
}