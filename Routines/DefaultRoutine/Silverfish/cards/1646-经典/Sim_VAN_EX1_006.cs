using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_006 : SimTemplate //* 报警机器人 Alarm-o-Bot
	{
		//[x]At the start of your turn,swap this minion with a   random one in your hand.
		//在你的回合开始时，随机将你的手牌中的一张随从牌与该随从交换。
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (turnStartOfOwner && triggerEffectMinion.own == turnStartOfOwner)
            {
                List<Handmanager.Handcard> temp2 = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB) temp2.Add(hc);
                }
                temp2.Sort((a, b) => -a.card.Attack.CompareTo(b.card.Attack));//damage the stronges
                foreach (Handmanager.Handcard mins in temp2)
                {
                    CardDB.Card c = CardDB.Instance.getCardDataFromID(mins.card.cardIDenum);
                    p.minionTransform(triggerEffectMinion, c);
                    triggerEffectMinion.playedThisTurn = false;
                    triggerEffectMinion.Ready = true;
                    p.removeCard(mins);
                    p.drawACard(CardDB.cardNameEN.alarmobot, true, true);
                    break;
                }
                return;
            }

            if (!turnStartOfOwner && triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 4, 4);
                triggerEffectMinion.Hp = triggerEffectMinion.maxHp;
            }
        }
	}
}