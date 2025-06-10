using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_080 : SimTemplate //* 暗影猎手沃金 Shadow Hunter Vol'jin
	{
		//<b>Battlecry:</b> Choose a minion. Swap it with a random one in its owner's hand.
		//<b>战吼：</b>选择一个随从，与其拥有者手牌中的随机一个随从交换。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_066); //acidicswampooze
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null && own.own == target.own)//我方
            {
                p.minionReturnToHand(target, target.own, 0);
				List<Handmanager.Handcard> temp2 = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB) temp2.Add(hc);
                }
                temp2.Sort((a, b) => -a.card.Attack.CompareTo(b.card.Attack));//damage the stronges
                foreach (Handmanager.Handcard mins in temp2)
                {
                    CardDB.Card c = CardDB.Instance.getCardDataFromID(mins.card.cardIDenum);
                    p.minionTransform(own, c);
                    own.playedThisTurn = false;
                    own.Ready = true;
                    break;
                }
                return;
			}
			if (target != null && own.own != target.own)//敌方
			{
                p.minionReturnToHand(target, target.own, 0);
				int zonepos = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
                p.callKid(kid, zonepos, !own.own);
			}
		}
		
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
