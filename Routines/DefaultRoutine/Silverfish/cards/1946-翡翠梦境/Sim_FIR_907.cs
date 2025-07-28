using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 德鲁伊 费用：4
	//Amirdrassil
	//阿梅达希尔
	//[x]Summon a @-Cost minion.Gain @ Armor. Draw @ |4(card, cards).Refresh @ Mana Crystal.<i>(Improves each use!)</i>
	//召唤一个法力值消耗为（@）的随从。获得@点护甲值。抽@张牌。复原@个法力水晶。<i>（每使用此效果一次都会提升！）</i>
	class Sim_FIR_907 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (p.mana < p.ownMaxMana)
				p.evaluatePenality -= 30;
			if (triggerMinion.handcard.card.CooldownTurn == 0)
			{
				//根据地标耐久判断提升数
				int enhance = triggerMinion.maxHp - triggerMinion.Hp;
				// 根据数随机获取一张随从
				CardDB.Card kid = p.getRandomCardForManaMinion(1 + enhance);
				//召唤一个随从
				p.callKid(kid, p.ownMinions.Count, true);
				//获取护甲
				p.minionGetArmor(p.ownHero, 1 + enhance);
				//抽牌
				for (int i = 0; i < 1 + enhance; i++)
				{
					p.drawACard(CardDB.cardNameEN.unknown, true);
				}
				p.mana = Math.Min(p.ownMaxMana, p.mana + 1 + enhance);
			}
		}

		// public override PlayReq[] GetUseAbilityReqs()
		// {
		// 	return new PlayReq[]{
		// 		new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1) // 需要一个位置
		// 	};
		// }

	}
}
