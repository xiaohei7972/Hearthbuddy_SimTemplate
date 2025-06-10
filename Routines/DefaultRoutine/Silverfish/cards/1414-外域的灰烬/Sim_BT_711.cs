using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_711 : SimTemplate //* 钉棍终结者 Blackjack Stunner
	{
		//[x]<b>Battlecry:</b> If you control a<b>Secret</b>, return a minionto its owner's hand.It costs (1) more.
		//<b>战吼：</b>如果你控制一个<b>奥秘</b>，将一个随从移回其拥有者的手牌，并且法力值消耗增加（1）点。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.ownSecretsIDList.Count >= 1)
			{
				if (target != null) p.minionReturnToHand(target, target.own, 1);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
