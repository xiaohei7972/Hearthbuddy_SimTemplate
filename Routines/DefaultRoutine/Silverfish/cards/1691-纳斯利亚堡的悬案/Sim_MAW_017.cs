using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：2 攻击力：2 生命值：3
	//Class Action Lawyer
	//集体诉讼律师
	//[x]<b>Battlecry:</b> If your deckhas no Neutral cards, set_a minion's stats to 1/1.
	//<b>战吼：</b>如果你的牌库中没有中立卡牌，将一个随从的属性值变为1/1。
	class Sim_MAW_017 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			//TODO:If there is no neutral cards in deck
			if (target != null) {
				p.minionSetAngrToX(target, 1);
				p.minionSetLifetoX(target, 1);
			}
		}
		
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}
