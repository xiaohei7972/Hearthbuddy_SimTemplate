using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：4
	//Libram of Divinity
	//神性圣契
	//Give a minion +3/+3. If this costs (0), return this to your handat the end of your turn.
	//使一个随从获得+3/+3。如果本牌的法力值消耗为（0）点，在你的回合结束时将本牌移回你的手牌。
	class Sim_GDB_138 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            if (target != null)
			{
				target.Angr += 3;
				target.Hp += 3;
				if (hc.card.cost == 0)
				{
					p.cardsToReturnAtEndOfTurn.Add(hc.card.cardIDenum);
				}
			}
        }

		public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 如果是当前玩家的回合结束，并且列表中包含该卡牌ID
            if (turnEndOfOwner && p.cardsToReturnAtEndOfTurn.Contains(CardDB.cardIDEnum.GDB_138))
            {
                // 将卡牌返回手牌
                p.drawACard(CardDB.cardIDEnum.GDB_138, m.own, true);

                // 移除返回标记
                p.cardsToReturnAtEndOfTurn.Remove(CardDB.cardIDEnum.GDB_138);
            }
        }

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从

			};

		}
		
	}
}
