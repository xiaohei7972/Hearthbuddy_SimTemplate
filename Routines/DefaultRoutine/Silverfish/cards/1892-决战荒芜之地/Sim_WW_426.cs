using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：6 攻击力：4 生命值：4
	//Blastmage Miner
	//矿工炎术师
	//[x]<b>Battlecry: Excavate</b> atreasure. For each card inyour hand, deal 1 damageto a random enemy.
	//<b>战吼：发掘</b>一个宝藏。你每有一张手牌，便随机对一个敌人造成1点伤害。
	class Sim_WW_426 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 触发发掘效果
			p.drawACard(p.handleExcavation().cardIDenum, own.own, true);
			int cardNumber = own.own ? p.owncards.Count : p.enemyAnzCards;
			p.allCharsOfASideGetRandomDamage(!own.own, cardNumber);
		}
		
	}
}
