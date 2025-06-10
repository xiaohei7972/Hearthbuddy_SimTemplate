using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_517 : SimTemplate //* 影光学者 Shadowlight Scholar
	{
        //<b>Battlecry:</b> Destroy a Soul Fragment in your deck to deal 3 damage.
        //<b>战吼：</b>摧毁一张你牌库中的灵魂残片，造成3点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.AnzSoulFragments > 0 && target != null)
                {
                    p.AnzSoulFragments--;
                    p.ownDeckSize--;
                    p.minionGetDamageOrHeal(target, 3);
                }
            }
            else
            {
                if(target != null)
                {
                    p.enemyDeckSize--;
                    p.minionGetDamageOrHeal(target, 3);
                }
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
