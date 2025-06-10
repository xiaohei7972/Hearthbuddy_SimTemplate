using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_166 : SimTemplate //* 丛林守护者 Keeper of the Grove
	{
		//<b>Choose One -</b> Deal_2_damage; or <b>Silence</b> a minion.
		//<b>抉择：</b>造成2点伤害；或者<b>沉默</b>一个随从。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.minionGetDamageOrHeal(target, 2);
            }

            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.minionGetSilenced(target);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}