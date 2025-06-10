using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_080 : SimTemplate //* 毒心者夏克里尔 Xaril, Poisoned Mind
//<b>Battlecry and Deathrattle:</b> Add a random Toxin card to your hand.
//<b>战吼，亡语：</b>随机将一张毒素牌置入你的手牌。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.briarthorntoxin, own.own, true);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.fadeleaftoxin, m.own, true);
        }
    }
}