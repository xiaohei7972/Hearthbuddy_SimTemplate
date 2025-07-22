using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_043 : SimTemplate //* 星界沟通 Astral Communion
//Gain 10 Mana Crystals. Discard your hand.
//获得十个法力水晶。弃掉你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.discardCards(10, ownplay);
            if (ownplay)
            {
				p.mana = 10;
				p.ownMaxMana = 10;
            }
            else
            {
				p.mana = 10;
				p.enemyMaxMana = 10;
            }
        }
    }
}