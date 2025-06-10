using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_103 : SimTemplate //* 小型法术红宝石 Lesser Ruby Spellstone
//Add 1 random Mage spell to your hand. @<i>(Play 2 Elementals to_upgrade.)</i>
//随机将一张法师法术牌置入你的手牌。@<i>（使用两张元素牌后升级。）</i> 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.frostbolt, ownplay, true);
        }
    }
}