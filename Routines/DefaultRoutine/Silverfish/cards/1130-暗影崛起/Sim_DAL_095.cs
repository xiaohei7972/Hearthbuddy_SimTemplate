using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_095 : SimTemplate //* 紫罗兰魔剑士 Violet Spellsword
//[x]<b>Battlecry:</b> Gain +1 Attackfor each spell in your hand.
//<b>战吼：</b>你手牌中每有一张法术牌，便获得+1攻击力。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, (own.own) ? p.owncards.Count : p.enemyAnzCards, 0);
		}
	}
}