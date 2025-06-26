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
		{   //根据地标耐久判断提升数
			int enhance = triggerMinion.maxHp - triggerMinion.Hp + 1;
			// 根据数随机获取一张随从
			CardDB.Card kid = p.getRandomCardForManaMinion(enhance);
			//召唤一个随从
			p.callKid(kid, p.ownMinions.Count, true);
			//获取护甲
			p.minionGetArmor(p.ownHero, enhance);
			//抽牌
			for (int i = 0; i < enhance; i++)
			{
				p.drawACard(CardDB.cardNameEN.unknown, true);
			}
			p.mana = Math.Min(10, p.mana + enhance);
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1)
			};
        }
		
	}
}
