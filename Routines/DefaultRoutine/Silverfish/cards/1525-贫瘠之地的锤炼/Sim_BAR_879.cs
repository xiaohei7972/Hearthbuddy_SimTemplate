using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_879 : SimTemplate //* 火炮长斯密瑟 Cannonmaster Smythe
	{
		//<b>Battlecry:</b> Transform your <b>Secrets</b> into 3/3 Soldiers. They transform back when they die.
		//<b>战吼：</b>将你的<b>奥秘</b>变形成为3/3的士兵。当士兵死亡时，会变回<b>奥秘</b>。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_879t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int pos = p.ownMinions.Count;
			for(int i = 0; i < p.ownSecretsIDList.Count; i ++){
				p.callKid(kid, pos, own.own);
				p.evaluatePenality += 10;
			}
		}
		
	}
}
