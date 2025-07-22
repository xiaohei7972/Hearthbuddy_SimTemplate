using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：3 攻击力：3 生命值：2
	//Trogg Gemtosser
	//穴居人宝石投掷者
	//<b>Finale:</b> Deal 1 damage to a random enemy for each of your Mana Crystals.
	//<b>压轴：</b>你每有一个法力水晶，随机对一个敌人造成1点伤害。
	class Sim_DEEP_029 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.mana == 0)
			    p.allCharsOfASideGetRandomDamage(!own.own,p.ownMaxMana);
		}
		
	}
}
