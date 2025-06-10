using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_009 : SimTemplate //* 罗宁 Rhonin
//<b>Deathrattle:</b> Add 3 copies of Arcane Missiles to your hand.
//<b>亡语：</b>将三张奥术飞弹置入你的手牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.arcanemissiles, m.own, true);
            p.drawACard(CardDB.cardNameEN.arcanemissiles, m.own, true);
            p.drawACard(CardDB.cardNameEN.arcanemissiles, m.own, true);
        }
	}
}