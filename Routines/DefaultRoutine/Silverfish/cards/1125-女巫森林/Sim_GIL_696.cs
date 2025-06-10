using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_696 : SimTemplate //* 搜索 Pick Pocket
//<b>Echo</b>Add a random card to your hand <i>(from your opponent's class).</i>
//<b>回响</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardIDEnum.GIL_696, ownplay, true);
		}
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
		}
	}
}