using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_019t2 : SimTemplate //* 黄金猿 Golden Monkey
//<b>Taunt</b><b>Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
//<b>嘲讽</b><b>战吼：</b>将你的手牌和牌库里的卡牌替换成<b>传说</b>随从。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int bonus = 0;
            if (own.own) bonus = -5 * p.owncards.Count;
            else bonus = 5 * p.enemyAnzCards;
			p.evaluatePenality += bonus;
		}
	}
}