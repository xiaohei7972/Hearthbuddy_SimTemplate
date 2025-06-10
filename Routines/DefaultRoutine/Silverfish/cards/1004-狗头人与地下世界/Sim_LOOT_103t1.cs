using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_103t1 : SimTemplate //* 法术红宝石 Ruby Spellstone
//Add 2 random Mage spells to your hand.@
//随机将两张法师法术牌置入你的手牌。@ 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.frostbolt, ownplay, true);
            p.drawACard(CardDB.cardNameEN.frostnova, ownplay, true);
        }
    }
}