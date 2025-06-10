using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_998k : SimTemplate //* 黄金狗头人 Golden Kobold
//<b>Taunt</b><b>Battlecry:</b> Replace your hand with <b>Legendary</b> minions.
//<b>嘲讽</b>，<b>战吼：</b>将你的手牌替换成<b>传说</b>随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay) p.evaluatePenality -= p.ownDeckSize;
            else p.evaluatePenality += p.enemyDeckSize;
		}
	}
}