using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_362: SimTemplate //* 巨龙怒吼 Dragon Roar
//Add 2 random Dragons to your hand.
//随机将两张龙牌置入你的手牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.drawACard(CardDB.cardNameEN.faeriedragon, ownplay);
			p.drawACard(CardDB.cardNameEN.deathwing, ownplay);
        }
    }
}