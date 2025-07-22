using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_103t2 : SimTemplate //* 大型法术红宝石 Greater Ruby Spellstone
//Add 3 random Mage spells to your hand.
//随机将三张法师法术牌置入你的手牌。 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.frostbolt, ownplay, true);
            p.drawACard(CardDB.cardNameEN.frostnova, ownplay, true);
            p.drawACard(CardDB.cardNameEN.frostnova, ownplay, true);
        }
    }
}