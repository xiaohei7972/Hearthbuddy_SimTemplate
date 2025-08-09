using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：4 生命值：3
	//Cariel Roame
	//凯瑞尔·罗姆
	//[x]<b>Rush</b>, <b>Divine Shield</b>Whenever this attacks,reduce the Cost of Holy______spells in your hand by (1).___
	//<b>突袭</b>。<b>圣盾</b>每当本随从攻击时，使你手牌中神圣法术牌的法力值消耗减少（1）点。
	class Sim_BAR_902 : SimTemplate
	{
		public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
		{
			if (attacker.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.SpellSchool == CardDB.SpellSchool.HOLY)
					{
						hc.manacost--;
						//this.evaluatePenality -= 5; // TODO: 这里可能需要调整评分
					}
				}
			}
		}

	}
}
