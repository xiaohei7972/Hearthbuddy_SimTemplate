using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_619 : SimTemplate //* 暗金教炼金师 Kabal Chemist
//<b>Battlecry:</b> Add a random Potion to your hand.
//<b>战吼：</b>随机将一张药水牌置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.frostbolt, m.own, true);
        }
    }
}