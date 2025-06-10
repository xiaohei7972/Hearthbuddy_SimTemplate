using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_432 : SimTemplate //* 女巫杂酿 Witch's Brew
//Restore #4 Health. Repeatable this turn.
//恢复#4点生命值。在本回合可以重复使用。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(4) : p.getEnemySpellHeal(4);
            p.minionGetDamageOrHeal(target, -heal);
			p.drawACard(CardDB.cardIDEnum.DAL_432, ownplay, true);
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