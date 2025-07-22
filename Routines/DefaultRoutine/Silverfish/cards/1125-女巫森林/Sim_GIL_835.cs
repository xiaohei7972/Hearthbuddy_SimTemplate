using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_835 : SimTemplate //* 南瓜宝宝 Squashling
//[x]<b>Echo</b><b>Battlecry:</b> Restore #2 Health.
//<b>回响，战吼：</b>恢复#2点生命值。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int heal = (own.own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
            p.minionGetDamageOrHeal(target, -heal);
			p.drawACard(CardDB.cardIDEnum.GIL_835, own.own, true);
		}
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}