using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：3 攻击力：3 生命值：2
	//Ultraviolet Breaker
	//极紫外破坏者
	//[x]<b>Battlecry:</b> Deal 3 damage toan enemy minion. Shuffle 3Asteroids into your deck.
	//<b>战吼：</b>对一个敌方随从造成3点伤害。将3张小行星洗入你的牌库。
	class Sim_GDB_901 : SimTemplate
	{
		CardDB.Card eruptionCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_430); // 小行星
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetDamageOrHeal(target, 3);
			for (int i = 0; i < 3; i++) // 洗入3张小行星
			{
				p.AddToDeck(eruptionCard);
			}
		}
		
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}
